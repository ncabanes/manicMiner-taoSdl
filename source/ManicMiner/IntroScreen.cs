/*
IntroScreen: Welcome screen
Part of Manic Miner Remake
@see Game CreditsScreen OptionsScreen

Nacho, 2011 & 2017

Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class IntroScreen
{
    private Image imagenFondo, movingTriangle;
    private Font font;
    private int chosenOption;

    // Available options
    public const byte OPT_GAME = 0;
    public const byte OPT_EXIT = 1;
    public const byte OPT_CREDITS = 2;
    public const byte OPT_OPTIONS = 3;

    public IntroScreen()
    {
        imagenFondo = new Image("data/intro.png");
        movingTriangle = new Image("data/introTriangle.png");
        font = new Font("FreeSansBold.ttf", 24);
    }

    public void Run()
    {
        int x = 100, y = 100;
        int xSpeed = 4, ySpeed = 4;

        do
        {
            SdlHardware.ClearScreen();
            SdlHardware.DrawHiddenImage(imagenFondo, 112, 10);

            SdlHardware.WriteHiddenText(
                    "Press P to Play",
                    420, 530, 0xAA, 0xAA, 0xAA, font);
            SdlHardware.WriteHiddenText(
                    "Q to Quit, C for Credits, O for Options",
                    280, 555, 0xAA, 0xAA, 0xAA, font);

            SdlHardware.DrawHiddenImage(movingTriangle, x, y);
            x += xSpeed;
            y += ySpeed;

            if ((x < 10) || (x > 1000 - 10 - 192))
                xSpeed = -xSpeed;
            if ((y < 10) || (y > 600 - 10 - 196))
                ySpeed = -ySpeed;

            SdlHardware.ShowHiddenScreen();

            if (SdlHardware.IsKeyPressed(SdlHardware.KEY_F2))
                SdlHardware.ToggleFullScreen();

            SdlHardware.Pause(20);  // 50 fps
        }
        while ((!SdlHardware.IsKeyPressed(SdlHardware.KEY_P))
            && (!SdlHardware.IsKeyPressed(SdlHardware.KEY_Q))
            && (!SdlHardware.IsKeyPressed(SdlHardware.KEY_C))
            && (!SdlHardware.IsKeyPressed(SdlHardware.KEY_O)));

        chosenOption = OPT_GAME;
        if (SdlHardware.IsKeyPressed(SdlHardware.KEY_Q))
            chosenOption = OPT_EXIT;
        if (SdlHardware.IsKeyPressed(SdlHardware.KEY_C))
            chosenOption = OPT_CREDITS;
        if (SdlHardware.IsKeyPressed(SdlHardware.KEY_O))
            chosenOption = OPT_OPTIONS;
    }

    public int GetChosenOption()
    {
        return chosenOption;
    }
}
