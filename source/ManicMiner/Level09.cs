/* 
Level09: Map of tiles for the Level 09 / 20
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level09 : Level
{

    public Level09()
    {
        name = "Wacky Amobeatrons";
        startingLevelData[ 0] = "LPP                            L";
        startingLevelData[ 1] = "LPP             V              L";
        startingLevelData[ 2] = "L                              L";
        startingLevelData[ 3] = "L                              L";
        startingLevelData[ 4] = "L                              L";
        startingLevelData[ 5] = "LSSSS  SSS  SSSSSSSS  SSS  SS  L"; 
        startingLevelData[ 6] = "L                              L"; 
        startingLevelData[ 7] = "L                            SSL"; 
        startingLevelData[ 8] = "L  SS  SSS  FFFFFFFF           L"; 
        startingLevelData[ 9] = "L                     SSS  SS  L"; 
        startingLevelData[10] = "LSS                            L"; 
        startingLevelData[11] = "L                              L"; 
        startingLevelData[12] = "L  SS  SSS  SSSSSSSS  SSS  SS  L"; 
        startingLevelData[13] = "L                            SSL";
        startingLevelData[14] = "L                              L";
        startingLevelData[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

        numEnemies = 5;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy("data/level09_enemy1.png", myGame);
        enemyList[0].MoveTo(150, 200);
        enemyList[0].SetSpeed(0, 2);
        enemyList[0].SetMinMaxY(100, 350);
        enemyList[0].SetWidthHeight(30, 39);

        enemyList[1] = new Enemy("data/level09_enemy1.png", myGame);
        enemyList[1].MoveTo(275, 200);
        enemyList[1].SetSpeed(0, 2);
        enemyList[1].SetMinMaxY(100, 350);
        enemyList[1].SetWidthHeight(30, 39);

        enemyList[2] = new Enemy("data/level09_enemy1.png", myGame);
        enemyList[2].MoveTo(500, 200);
        enemyList[2].SetSpeed(0, 2);
        enemyList[2].SetMinMaxY(100, 350);
        enemyList[2].SetWidthHeight(30, 39);

        enemyList[3] = new Enemy("data/level09_enemy1.png", myGame);
        enemyList[3].MoveTo(625, 200);
        enemyList[3].SetSpeed(0, 2);
        enemyList[3].SetMinMaxY(100, 350);
        enemyList[3].SetWidthHeight(30, 39);

        enemyList[4] = new Enemy("data/level09_enemy2.png", myGame);
        enemyList[4].MoveTo(310, 110);
        enemyList[4].SetSpeed(2, 0);
        enemyList[4].SetMinMaxX(310, 470);
        enemyList[4].SetWidthHeight(30, 48);

        /*enemyList[5] = new Enemy("enemyLevel09a", c);
        enemyList[5].MoveTo(310, 110);
        enemyList[5].SetSpeed(2, 0);
        enemyList[5].SetMinMaxX(310, 470);
        enemyList[5].SetWidthHeight(30, 48);*/

        Restart();
    } 
}
