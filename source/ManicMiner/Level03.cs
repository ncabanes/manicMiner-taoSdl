/* 
Level03: Map of tiles for the third Level  
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level03 : Level
{

    public Level03()
    {
        name = "The Menagerie";
        startingLevelData[ 0] = "M    V   T     V  T    V   T   M";
        startingLevelData[ 1] = "M                              M";
        startingLevelData[ 2] = "M                              M";
        startingLevelData[ 3] = "M                              M";
        startingLevelData[ 4] = "M                              M";
        startingLevelData[ 5] = "MNNNNOOOOOOOOOOOOOOOOOOOOOO  OOM"; 
        startingLevelData[ 6] = "M                    V        VM"; 
        startingLevelData[ 7] = "MNNNNNN                    NNNNM"; 
        startingLevelData[ 8] = "MT                             M"; 
        startingLevelData[ 9] = "M     DDDDDD                   M"; 
        startingLevelData[10] = "M                        NNNNNNM"; 
        startingLevelData[11] = "M             NNNNN          PPM"; 
        startingLevelData[12] = "M    NNNNNN                  PPM"; 
        startingLevelData[13] = "M                    NNNNNNNNNNM";
        startingLevelData[14] = "M                              M";
        startingLevelData[15] = "MNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNM";

        numEnemies = 3;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy("data/level03_enemy1.png", myGame);
        enemyList[0].MoveTo(400, 352);
        enemyList[0].SetSpeed(2, 0);
        enemyList[0].SetMinMaxX(100, 480);
        enemyList[0].SetWidthHeight(36, 48);

        enemyList[1] = new Enemy("data/level03_enemy1.png", myGame);
        enemyList[1].MoveTo(300, 110);
        enemyList[1].SetSpeed(-2, 0);
        enemyList[1].SetMinMaxX(50, 725);
        enemyList[1].SetWidthHeight(36, 48);

        enemyList[2] = new Enemy("data/level03_enemy1.png", myGame);
        enemyList[2].MoveTo(350, 110);
        enemyList[2].SetSpeed(2, 0);
        enemyList[2].SetMinMaxX(50, 725);
        enemyList[2].SetWidthHeight(36, 48);

        Restart();
    } 
}
