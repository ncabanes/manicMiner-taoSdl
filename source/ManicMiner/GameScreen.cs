/*
GameScreen: Logic which is common to all the levels
Part of Manic Miner Remake
@see Game Level

Nacho, 2011 & 2017

Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class GameScreen
{
    Level currentLevel;
    Level[] levels;
    const int MAX_LEVEL = 20;
    int currentLevelNumber = 0;
    Font font;
  
    public GameScreen(Game p)
    {
        levels = new Level[MAX_LEVEL];
        levels[0] = new Level01();
        levels[1] = new Level02();
        levels[2] = new Level03();
        levels[3] = new Level04();
        levels[4] = new Level05();
        levels[5] = new Level06();
        levels[6] = new Level07();
        levels[7] = new Level08();
        levels[8] = new Level09();
        levels[9] = new Level10();
        levels[10] = new Level11();
        levels[11] = new Level12();
        levels[12] = new Level13();
        levels[13] = new Level14();
        levels[14] = new Level15();
        levels[15] = new Level16();
        levels[16] = new Level17();
        levels[17] = new Level18();
        levels[18] = new Level19();
        levels[19] = new Level20();

        currentLevel = levels[ currentLevelNumber ];
        font = new Font("FreeSansBold.ttf", 18);
  }

   public void Restart()
   {
       currentLevelNumber = 0;  
       currentLevel = levels[ currentLevelNumber ];
       currentLevel.Restart();
   }

   public void DrawOnHiddenScreen()
   {
       currentLevel.DrawOnHiddenScreen();
   }

   public bool CanMoveTo(int x, int y, int xmax, int ymax)
   {
       return currentLevel.CanMoveTo(x, y, xmax, ymax); 
   }

   public int ObtenerPuntosPosicion(int x, int y, int xmax, int ymax)
   {
       return currentLevel.GetPointsFromPos(x, y, xmax, ymax); 
   }

   public void ProceedToNextLevel()
   {
       currentLevelNumber++;
       if (currentLevelNumber >= MAX_LEVEL)
           currentLevelNumber = 0;

       SdlHardware.FilledRectangleRGBA(
          200, 100, 600, 300,  // Position, width and height
          200, 200, 200,   // Light grey
          200);         // And a bit of transparency

       SdlHardware.WriteHiddenText(
               "Entering Level "+(currentLevelNumber+1),
               300, 200, 0, 0, 0, font);

       SdlHardware.ShowHiddenScreen();
       SdlHardware.Pause(2000);

       currentLevel = levels[currentLevelNumber];
       currentLevel.Restart();
   }

   public string Getname()
   {
       return currentLevel.GetName();
   }

   public int GetNumEnemies()
   {
       return currentLevel.GetNumEnemies();
   }

   public Enemy GetEnemy(int i)
   {
       return currentLevel.GetEnemy(i);
   }
  
}
