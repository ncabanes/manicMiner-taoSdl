/*
Level02: Map of tiles for the second Level
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level02 : Level
{
    public Level02()
    {
        name = "The Cold Room";
        startingLevelData[ 0] = "L                  LLLLLLLLLLLLL";
        startingLevelData[ 1] = "L      V                V     TL";
        startingLevelData[ 2] = "L                              L";
        startingLevelData[ 3] = "L                    FFFF      L";
        startingLevelData[ 4] = "L                              L";
        startingLevelData[ 5] = "LSSSSSSSSSSSSSSSSSSS        L  L"; 
        startingLevelData[ 6] = "L                    SSSSLFFL  L"; 
        startingLevelData[ 7] = "LSFFFFF                  LV L  L"; 
        startingLevelData[ 8] = "L                        LFFL  L"; 
        startingLevelData[ 9] = "L  V     SSSSSSS         LFFL  L"; 
        startingLevelData[10] = "L                  FFFF  LFFL  L"; 
        startingLevelData[11] = "L  DDDD                  LFFL  L"; 
        startingLevelData[12] = "L             SSSS V     LFFL  L"; 
        startingLevelData[13] = "L       FFFF                 PPL";
        startingLevelData[14] = "L                            PPL";
        startingLevelData[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

        numEnemies = 2;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy("data/level02_enemy1.png", myGame);
        enemyList[0].MoveTo(400, 352);
        enemyList[0].SetSpeed(2, 0);
        enemyList[0].SetMinMaxX(45, 680);
        enemyList[0].SetWidthHeight(36, 48);

         enemyList[1] = new Enemy("data/level02_enemy1.png", myGame);
        enemyList[1].MoveTo(45, 110);
        enemyList[1].SetSpeed(2, 0);
        enemyList[1].SetMinMaxX(45, 465);
        enemyList[1].SetWidthHeight(36, 48);

        Restart();
    }
}
