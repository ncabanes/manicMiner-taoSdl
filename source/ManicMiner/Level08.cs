/* 
Level08: Map of tiles for the Level 08 / 20
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level08 : Level
{

    public Level08()
    {
        name = "Miner Willy Meets The Kong Beast";
        startingLevelData[ 0] = "M T   L   L    AAML M          M";
        startingLevelData[ 1] = "M              AAM  M          M";
        startingLevelData[ 2] = "M            V DDM           DDM";
        startingLevelData[ 3] = "M                M             M";
        startingLevelData[ 4] = "M                M             M";
        startingLevelData[ 5] = "MDDD     DDDDDD  MDD           M"; 
        startingLevelData[ 6] = "M             V  M   DDDD     DM"; 
        startingLevelData[ 7] = "M DDD            M         D   M"; 
        startingLevelData[ 8] = "M V     DDD      M             M"; 
        startingLevelData[ 9] = "M                MDDDDDD       M"; 
        startingLevelData[10] = "MD          DDD  M         DDDDM"; 
        startingLevelData[11] = "M        DD      M             M"; 
        startingLevelData[12] = "M   DD           M    DDDDD    M"; 
        startingLevelData[13] = "M          NNNMPPMDD         V M";
        startingLevelData[14] = "M             MPPM     A       M";
        startingLevelData[15] = "MDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDM";

        numEnemies = 2;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy(myGame);
        enemyList[0].MoveTo(380, 40);
        enemyList[0].SetSpeed(0, 0);
        enemyList[0].SetWidthHeight(36, 48);

        enemyList[1] = new Enemy(myGame);
        enemyList[1].MoveTo(150, 350);
        enemyList[1].SetSpeed(2, 0);
        enemyList[1].SetMinMaxX(55, 315);
        enemyList[1].SetWidthHeight(36, 48);
        /*
        enemyList[2] = new Enemy(c);
        enemyList[2].MoveTo(150, 200);
        enemyList[2].SetSpeed(0, 2);
        enemyList[2].SetMinMaxY(100, 300);
        enemyList[2].SetWidthHeight(36, 48);

        enemyList[3] = new Enemy(c);
        enemyList[3].MoveTo(150, 200);
        enemyList[3].SetSpeed(0, 2);
        enemyList[3].SetMinMaxY(100, 300);
        enemyList[3].SetWidthHeight(36, 48);
        */

        Restart();
    } 
}
