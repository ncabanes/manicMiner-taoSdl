/*
OptionsScreen: Options screen
Part of Manic Miner Remake
@see Game IntroScreen CreditsScreen

Nacho, 2011 & 2017

Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class OptionsScreen
{
    private Font FontSans18;
    private Font FontSans12;

    public OptionsScreen()
    {
        FontSans18 = new Font("FreeSansBold.ttf", 18);
        FontSans12 = new Font("FreeSansBold.ttf", 12);
    }

    public void Run()
    {
        bool exit = false;

        byte color = 0x55;
        while ( ! exit )
        {

            SdlHardware.ClearScreen();

            SdlHardware.WriteHiddenText(
                "Options", 110, 100,
                  0x77, 0x77, color, FontSans18);

            SdlHardware.WriteHiddenText("Soon available...", 200, 240,
                  color, color, 0, FontSans18);
            SdlHardware.WriteHiddenText(
                  "Press ESC to return to the welcome screen...",
                  110, 550, 0xAA, 0xAA, 0xAA, FontSans12);


            SdlHardware.ShowHiddenScreen();
            SdlHardware.Pause(40);

            exit = SdlHardware.IsKeyPressed(SdlHardware.KEY_ESC);
        }
    }
}
