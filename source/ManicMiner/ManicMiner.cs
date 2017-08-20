/*
ManicMiner.cs - Main class (game controller)
Part of Manic Miner Remake
@see Game IntroScreen

Nacho, 2011 & 2017

Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class ManicMiner
{
    private IntroScreen intro;
    private Game game;
    private CreditsScreen credits;
    private OptionsScreen options;

    public ManicMiner()
    {
        bool fullScreen = false;
        SdlHardware.Init(1024, 600, 24, fullScreen);

        intro = new IntroScreen();
        game = new Game();
        credits = new CreditsScreen();
        options = new OptionsScreen();
    }

    public void Run()
    {
        do
        {
            intro.Run();
            switch (intro.GetChosenOption())
            {
                case IntroScreen.OPT_CREDITS:
                    credits.Run();
                    break;
                case IntroScreen.OPT_GAME:
                    game.MainLoop();
                    break;
                case IntroScreen.OPT_OPTIONS:
                    options.Run();
                    break;
            }
        }
        while (intro.GetChosenOption() != IntroScreen.OPT_EXIT);
    }


    public static void Main()
    {
        ManicMiner gameController = new ManicMiner();
        gameController.Run();
    }
}
