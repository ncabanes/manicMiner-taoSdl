/*
CreditsScreen: Info about the author(s)
Part of Manic Miner Remake
@see Game IntroScreen OptionsScreen

Nacho, 2011 & 2017

Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class CreditsScreen
{
    private Font FontSans18;
    private Font FontSans12;

    public CreditsScreen()
    {
        FontSans18 = new Font("FreeSansBold.ttf", 18);
        FontSans12 = new Font("FreeSansBold.ttf", 12);
    }

    public void Run()
    {
        bool exit = false;

        byte color = 0x55;
        while ( !exit )
        {

            SdlHardware.ClearScreen();

            SdlHardware.WriteHiddenText(
                "Manic Miner (Remake) - Credits", 110, 100,
                  0x77, 0x77, color, FontSans18);

            SdlHardware.WriteHiddenText("Original game:", 200, 240,
                  color, color, 0, FontSans18);
            SdlHardware.WriteHiddenText("Matthew Smith", 200, 270,
                  color, color, 0, FontSans18);
            SdlHardware.WriteHiddenText("(c) Software Projects, 1984", 200, 300,
                  color, color, 0, FontSans18);

            SdlHardware.WriteHiddenText("(Partial) Remake:", 200, 360,
                  color, color, 0, FontSans18);
            SdlHardware.WriteHiddenText("Nacho Cabanes, 2011", 200, 390,
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
