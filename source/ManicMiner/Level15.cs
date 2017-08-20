/* 
Level15: Map of tiles for the Level 15 / 20
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level15 : Level
{

    public Level15()
    {
        name = "The Bank";
        startingLevelData[ 0] = "L    LLLLLLLLLLLLLLLLLLLLLLLLLLL";
        startingLevelData[ 1] = "L                            MML";
        startingLevelData[ 2] = "L                       V    MML";
        startingLevelData[ 3] = "LPP     DDDDDDDDDDDDDDDDSSSSSMML";
        startingLevelData[ 4] = "LPP                          MML";
        startingLevelData[ 5] = "LSSSSS                       MML"; 
        startingLevelData[ 6] = "L           V           SS   MML"; 
        startingLevelData[ 7] = "L      F    SS               MML"; 
        startingLevelData[ 8] = "L  SS             SS         MML"; 
        startingLevelData[ 9] = "L                            MML"; 
        startingLevelData[10] = "LSS         SS           SS  MML"; 
        startingLevelData[11] = "L                 SS         MML"; 
        startingLevelData[12] = "L    SSS               SS    MML"; 
        startingLevelData[13] = "L           SS               MML";
        startingLevelData[14] = "L                         V  MML";
        startingLevelData[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

        numEnemies = 3;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy("data/level15_enemy1.png", myGame);
        enemyList[0].MoveTo(200, 65);
        enemyList[0].SetSpeed(2, 0);
        enemyList[0].SetMinMaxX(100, 670);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[1] = new Enemy("data/level15_enemy1.png", myGame);
        enemyList[1].MoveTo(250, 300);
        enemyList[1].SetSpeed(0, 2);
        enemyList[1].SetMinMaxY(140, 350);
        enemyList[1].SetWidthHeight(36, 48);

        enemyList[2] = new Enemy("data/level15_enemy1.png", myGame);
        enemyList[2].MoveTo(520, 160);
        enemyList[2].SetSpeed(0, 2);
        enemyList[2].SetMinMaxY(140, 350);
        enemyList[2].SetWidthHeight(36, 48);

        Restart();
    }
}
