/*
Game.cs - Game logic
Part of Manic Miner Remake
@see ManicMiner GameScreen Level

Nacho, 2011 & 2017

Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Game
{
    private Player player;
    private Font font;
    private GameScreen gameScreen;
    private Scoreboard scoreBoard;

    int score;
    bool gameFinished;

    public Game()
    {
        player = new Player(this);
        gameScreen = new GameScreen(this);
        scoreBoard = new Scoreboard(this);
        score = 0;
        gameFinished = false;
        font = new Font("FreeSansBold.ttf", 18);
    }


    // --- Checking keyboard, mouse and joystick -----
    void checkInput()
    {
        // Let's move if any arrow in the keyboard is pressed
        if (SdlHardware.IsKeyPressed(SdlHardware.KEY_SPC))
        {
            if (SdlHardware.IsKeyPressed(SdlHardware.KEY_RIGHT))
                player.JumpRight();
            else if (SdlHardware.IsKeyPressed(SdlHardware.KEY_LEFT))
                player.JumpLeft();
            else
                player.Jump();
        }
        if (SdlHardware.IsKeyPressed(SdlHardware.KEY_RIGHT))
            player.MoveRight();

        if (SdlHardware.IsKeyPressed(SdlHardware.KEY_LEFT))
            player.MoveLeft();

        if ((SdlHardware.IsKeyPressed(SdlHardware.KEY_T)) &&
            (SdlHardware.IsKeyPressed(SdlHardware.KEY_N)))
            gameScreen.ProceedToNextLevel();


        // Let's check the Joystick
        int posXJoystick, posYJoystick;
        bool joystickInUse = SdlHardware.JoystickMoved(out posXJoystick, out posYJoystick);

        if (SdlHardware.JoystickPressed(0))
        {
            if (posXJoystick > 0) player.JumpRight();
            else if (posXJoystick < 0) player.JumpLeft();
            else player.Jump();
        }
        else if (joystickInUse)
        {
            if (posXJoystick > 0) player.MoveRight();
            else if (posXJoystick < 0) player.MoveLeft();
        }

        // Let's check the mouse
        // Note: only as an usage example 
        // and for cheating purposes  ;-)
        int posXmouse = 0, posYmouse = 0;
        if (SdlHardware.MouseClicked())
        {
            posXmouse = SdlHardware.GetMouseX();
            posYmouse = SdlHardware.GetMouseY();
            player.MoveTo(posXmouse, posYmouse);
        }


        // ESC ends the game
        if (SdlHardware.IsKeyPressed(SdlHardware.KEY_ESC))
            gameFinished = true;

        // And F2 toggles Full Screen mode
        if (SdlHardware.IsKeyPressed(SdlHardware.KEY_F2))
            SdlHardware.ToggleFullScreen();
    }


    // --- Animating enemies and other "self moving" objects -----
    void moveElements()
    {
        for (int i = 0; i < gameScreen.GetNumEnemies(); i++)
            gameScreen.GetEnemy(i).Move();
        player.Move();
    }


    // --- Checking collisons with enemies and background ---
    void checkCollision()
    {
        // Collisions between player and background: get points or lose life
        int pointsFromMoving = gameScreen.ObtenerPuntosPosicion(
          player.GetX(),
          player.GetY(),
          player.GetX() + player.GetWidth(),
          player.GetY() + player.GetHeight());

        // If an object has been grabbed, let's sum the points
        if (pointsFromMoving > 0)
        {
            score += pointsFromMoving;

            // If it is a door, let's advance to the next level
            if (pointsFromMoving == 50)
                gameScreen.ProceedToNextLevel();
        }

        // If score is -1, we have hit a dangerous obstacle:
        // One life less + restart
        if (pointsFromMoving < 0)
        {
            player.Die();
            player.Restart();
            for (int i = 0; i < gameScreen.GetNumEnemies(); i++)
                gameScreen.GetEnemy(i).Restart();
        }

        // And the same if we hit an enemy
        for (int i = 0; i < gameScreen.GetNumEnemies(); i++)
            if (player.CollisionsWith(gameScreen.GetEnemy(i)))
            {
                player.Die();
                player.Restart();
                for (int j = 0; j < gameScreen.GetNumEnemies(); j++)
                    gameScreen.GetEnemy(i).Restart();
                break;
            }

        if (player.GetLives() == 0)
            gameFinished = true;
    }


    // --- Drawing all the visible elements ---
    void drawElements()
    {
        // Let's clear the screen  
        SdlHardware.ClearScreen();

        // And draw all the elemnets
        gameScreen.DrawOnHiddenScreen();
        SdlHardware.DrawHiddenImage(player);
        for (int i = 0; i < gameScreen.GetNumEnemies(); i++)
            SdlHardware.DrawHiddenImage(gameScreen.GetEnemy(i));

        // And the scoreboard
        scoreBoard.SetLives(player.GetLives());
        scoreBoard.SetScore(score);
        scoreBoard.SetName(gameScreen.Getname());
        scoreBoard.DrawOnHiddenScreen();

        // Finally, let's show everything
        SdlHardware.ShowHiddenScreen();
    }


    // --- Pause afer each frame (20 ms, for a speed of 50 fps) -----
    void pauseTillNextFrame()
    {
        SdlHardware.Pause(20);
    }


    // --- Main loop for the game -----
    public void MainLoop()
    {

        gameFinished = false;
        score = 0;
        player.Restart();
        player.SetLives(3);
        for (int i = 0; i < gameScreen.GetNumEnemies(); i++)
            gameScreen.GetEnemy(i).Restart();
        gameScreen.Restart();

        do
        {
            checkInput();
            moveElements();
            checkCollision();
            drawElements();
            pauseTillNextFrame();
        } while (!gameFinished);
    }

    // --- So that the player and enemies can know about the current map
    public GameScreen GetMap()
    {
        return gameScreen;
    }
}
