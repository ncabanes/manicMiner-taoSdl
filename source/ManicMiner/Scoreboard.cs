/* 
Scoreboard: Displays points, lives, air, best score
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Scoreboard
{
    private Image imgLives;
    private Image imgAirRed, imgAirRedEmpty, imgAirGreen, imgAirGreenEmpty;
    private Image imgMetalBack;
    private int air;
    private int score;
    private int highScore;
    private int lives;
    private string levelName;

    private Game myGame;
    Font font;


    public Scoreboard(Game p)
    {
        myGame = p;
        font = new Font("FreeSansBold.ttf", 22);
        imgLives = new Image("data/player-r-01.png");
        imgAirRed = new Image("data/airRed.png");
        imgAirRedEmpty = new Image("data/airRedE.png");
        imgAirGreen = new Image("data/airGreen.png");
        imgAirGreenEmpty = new Image("data/airGreenE.png");
        //imgMetalBack = new Image("data/metal.png");
    }

    public int GetAir()
    {
        return air;
    }

    public void SetAir(int a)
    {
        air = a;
    }

    public void IncrAir(int a)
    {
        air += a;
    }

    public int GetScore()
    {
        return score;
    }

    public void SetHighScore(int s)
    {
        highScore = s;
    }

    public void SetName(string n)
    {
        levelName = n;
    }

    public void SetScore(int s)
    {
        score = s;
    }

    public void IncrScore(int s)
    {
        score += s;
    }

    public void DrawOnHiddenScreen()
    {

        SdlHardware.WriteHiddenText("High score: 000000",
            200, 570, 0xFF, 0xFF, 0x00, font);
        SdlHardware.WriteHiddenText("Score: " + score.ToString("000000"),
            550, 570, 0xFF, 0xFF, 0x00, font);

        // Borders and level name
        //SdlHardware.DrawHiddenImage(imgMetalBack, 0, 0);
        //SdlHardware.DrawHiddenImage(imgMetalBack, 0, 420);
        SdlHardware.WriteHiddenText(levelName,
            350, 540, 255, 255, 255, font);

        // Air indicator
        int i;
        for (i = 0; i < 200; i++)
        {
            if (i < 25) SdlHardware.DrawHiddenImage(imgAirRed, i * 4, 512);
            else if (i < 60) SdlHardware.DrawHiddenImage(imgAirRedEmpty, i * 4, 512);
            else if (i < 175) SdlHardware.DrawHiddenImage(imgAirGreenEmpty, i * 4, 512);
            else SdlHardware.DrawHiddenImage(imgAirGreen, i * 4, 512);
        }
        SdlHardware.WriteHiddenText("Air",
         10, 514, 0, 0, 0, font);

        // Lives indicator
        int livesToBeShown = lives;
        if (livesToBeShown > 5) livesToBeShown = 5;
        for (i = 0; i < livesToBeShown; i++)
        {
            SdlHardware.DrawHiddenImage(imgLives, 20 + 40 * i, 535);
        }
    }

    public void SetLives(int l)
    {
        lives = l;
    }

    public int GetLives()
    {
        return lives;
    }
}
