/*
Enemy: A first enemy moving side to side
Part of Manic Miner Remake
@see Game Sprite Player

Nacho, 2011 & 2017

Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Enemy : Sprite
{

    Game myGame;
    protected int minX, maxX, minY, maxY;

    public Enemy(Game p)
    {
        myGame = p;

        LoadSequence(RIGHT,
                    new string[] {"data/level01_enemy-r-01.png",
                          "data/level01_enemy-r-02.png",
                          "data/level01_enemy-r-03.png",
                          "data/level01_enemy-r-02.png",
                          "data/level01_enemy-r-01.png"});
        LoadSequence(LEFT,
                    new string[] {"data/level01_enemy-l-01.png",
                          "data/level01_enemy-l-02.png",
                          "data/level01_enemy-l-03.png",
                          "data/level01_enemy-l-02.png",
                          "data/level01_enemy-l-01.png"});
        LoadSequence(UP,
                    new string[] {"data/level01_enemy-r-01.png",
                          "data/level01_enemy-r-02.png",
                          "data/level01_enemy-r-03.png",
                          "data/level01_enemy-r-02.png",
                          "data/level01_enemy-r-01.png"});
        LoadSequence(DOWN,
                    new string[] {"data/level01_enemy-l-01.png",
                          "data/level01_enemy-l-02.png",
                          "data/level01_enemy-l-03.png",
                          "data/level01_enemy-l-02.png",
                          "data/level01_enemy-l-01.png"});

        ChangeDirection(RIGHT);
        updatesPerFrame = 4;
    }


    public Enemy(string fileName, Game p)
        : base(fileName)
    {
        myGame = p;
    }


    public new void Move()
    {
        if (xSpeed != 0)
        {
            x += xSpeed;
            NextFrame();

            if ((x < minX) || (x > maxX))
            {
                xSpeed = (short)(-xSpeed);
                if (xSpeed < 0)
                    ChangeDirection(LEFT);
                else
                    ChangeDirection(RIGHT);
            }
        }
        if (ySpeed != 0)
        {
            y += ySpeed;
            NextFrame();

            if ((y < minY) || (y > maxY))
            {
                ySpeed = (short)(-ySpeed);
                if (ySpeed < 0)
                    ChangeDirection(UP);
                else
                    ChangeDirection(DOWN);
            }
        }
    }

    public void SetMinMaxX(int minX, int maxX)
    {
        this.minX = minX;
        this.maxX = maxX;
    }

    public void SetMinMaxY(int minY, int maxY)
    {
        this.minY = minY;
        this.maxY = maxY;
    }
}
