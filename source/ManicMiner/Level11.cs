/* 
Level11: Map of tiles for the Level 11 / 20
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level11 : Level
{
    public Level11()
    {
        name = "Attack of the Mutant Telephones";
        startingLevelData[ 0] = "LLLLLLL                 V      L";
        startingLevelData[ 1] = "LPP                           VL";
        startingLevelData[ 2] = "LPP                            L";
        startingLevelData[ 3] = "LFFFF                          L";
        startingLevelData[ 4] = "LV                             L";
        startingLevelData[ 5] = "L    FFFFFF    FFFFFFFFFFF     L"; 
        startingLevelData[ 6] = "L                  V         FFL"; 
        startingLevelData[ 7] = "L                              L"; 
        startingLevelData[ 8] = "LFF                          FFL"; 
        startingLevelData[ 9] = "L          FFFFFFFFF           L"; 
        startingLevelData[10] = "L                           F  L"; 
        startingLevelData[11] = "L     DDDF                     L"; 
        startingLevelData[12] = "L                           FFFL"; 
        startingLevelData[13] = "LFF                    FFF    VL";
        startingLevelData[14] = "L                              L";
        startingLevelData[15] = "LFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFL";

        numEnemies = 2;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy("data/level11_enemy2.png", myGame);
        enemyList[0].MoveTo(100, 100);
        enemyList[0].SetSpeed(2, 0);
        enemyList[0].SetMinMaxX(150, 300);
        enemyList[0].SetWidthHeight(36, 48);


        enemyList[1] = new Enemy("data/level11_enemy2.png", myGame);
        enemyList[1].MoveTo(600, 200);
        enemyList[1].SetSpeed(2, 0);
        enemyList[1].SetMinMaxX(280, 380);
        enemyList[1].SetWidthHeight(36, 48);

        Restart();
    }
     
}
