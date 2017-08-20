/* 
Player: The user-controlled character
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Player : Sprite
{

    Game myGame;
    short lives;
    bool jumping, falling;
    int xJumpSpeed;
    int frameOfTheMovement;
    int amountOfStepsInJump;
    int[] stepsOfJump = {-13, -13, -10, -10, -8, -8, -5, -5, -2, -2, -1, -1, 0,
                               0, 1, 1, 2, 2, 5, 5, 8, 8, 10, 10, 13, 13 };

    public Player(Game p)
    {
        myGame = p;
        MoveTo(48, 416);

        SetSpeed(4, 4);
        lives = 3;
        jumping = false;
        xJumpSpeed = 0;
        amountOfStepsInJump = stepsOfJump.Length;

        LoadSequence(RIGHT,
                new string[] {"data/player-r-01.png", "data/player-r-02.png",
                            "data/player-r-03.png", "data/player-r-02.png",
                            "data/player-r-01.png"});
        LoadSequence(LEFT,
                new string[] {"data/player-l-01.png", "data/player-l-02.png",
                            "data/player-l-03.png", "data/player-l-02.png",
                            "data/player-l-01.png"});
        currentDirection = RIGHT;
        SetWidthHeight(40, 64);
        updatesPerFrame = 5;
    }


    public void MoveRight()
    {
        if (jumping || falling) return;

        ChangeDirection(RIGHT);
        if (myGame.GetMap().CanMoveTo(x + xSpeed, y + height - 4,
                  x + width + xSpeed, y + height))
        {
            x += xSpeed;
            NextFrame();
        }
        falling = true;
    }

    public void MoveLeft()
    {
        if (jumping || falling) return; 

        ChangeDirection(LEFT);
        if (myGame.GetMap().CanMoveTo(x - xSpeed, y + height - 4,
                  x + width - xSpeed, y + height))
        {
            x -= xSpeed;
            NextFrame();
        }
        falling = true;
    }


    // Used when the player must move on his own, e.g. jumping
    public new void Move()
    {
        if (jumping)
        {
            // First, let's calculate next position and
            // check if it is valid
            short xNextMove = (short)(x + xJumpSpeed);
            short yNextMove = (short)(y + stepsOfJump[frameOfTheMovement]);
            bool jumpingUpwards = (stepsOfJump[frameOfTheMovement] < 0);

            // If we can still move, let's do it
            if (myGame.GetMap().CanMoveTo(
                xNextMove, yNextMove + height - 4,
                xNextMove + width, yNextMove + height)
                || jumpingUpwards)
            {
                x = xNextMove;
                y = yNextMove;
                NextFrame();
            }
            // Otherwise, we might be falling
            else
            {
                jumping = false;
                falling = true;
            }

            frameOfTheMovement++;
            if (frameOfTheMovement >= amountOfStepsInJump)
            {
                jumping = false;
                falling = true;
            }
        }
        else if (falling)
        {
            if (myGame.GetMap().CanMoveTo(
                x, y + ySpeed + height - 4,
               x + width, y + ySpeed + height))
            {
                y += ySpeed;
            }
            else
                falling = false;
        }
    }


    // Starts the jump sequence
    public void Jump()
    {
        if (jumping || falling)
            return;
        jumping = true;
        frameOfTheMovement = 0;
        xJumpSpeed = 0;
    }

    // Starts the jump right sequence
    public void JumpRight()
    {
        Jump();
        xJumpSpeed = xSpeed;
    }


    // Starts the jump left sequence
    public void JumpLeft()
    {
        Jump();
        xJumpSpeed = -xSpeed;
    }

    public int GetLives()
    {
        return lives;
    }

    public void SetLives(short n)
    {
        lives = n;
    }

    public void Die()
    {
        lives--;
    }
}
