/*
Level01: Map of tiles for the first Level
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017

Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level01 : Level
{

    public Level01()
    {
        name = "Central Cavern";
        startingLevelData[ 0] = "L        V T    T            V L";
        startingLevelData[ 1] = "L               V              L";
        startingLevelData[ 2] = "L                              L";
        startingLevelData[ 3] = "L                              L";
        startingLevelData[ 4] = "L                      VA  A   L"; 
        startingLevelData[ 5] = "LSS  SSSSSSSSSFFFFSFFFFSSSSSSSSL"; 
        startingLevelData[ 6] = "L                             VL"; 
        startingLevelData[ 7] = "LSSS                           L"; 
        startingLevelData[ 8] = "L                LLL A         L"; 
        startingLevelData[ 9] = "LSSSS   DDDDDDDDDDDDDDDDDDDD   L"; 
        startingLevelData[10] = "L                            SSL"; 
        startingLevelData[11] = "L                              L"; 
        startingLevelData[12] = "L            A      LLL  FFFSSSL"; 
        startingLevelData[13] = "L    SSSSSSSSSSSSSSS         P L";
        startingLevelData[14] = "L                              L";
        startingLevelData[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

        numEnemies = 2;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy(myGame);
        enemyList[0].MoveTo(400, 352);
        enemyList[0].SetSpeed(3, 0);
        enemyList[0].SetMinMaxX(100, 700);
        enemyList[0].SetWidthHeight(36, 48);
        enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[1] = new Enemy(myGame);
        enemyList[1].MoveTo(200, 150);
        enemyList[1].SetSpeed(0, 3);
        enemyList[1].SetMinMaxY(100, 300);
        enemyList[0].SetWidthHeight(36, 48);
        enemyList[0].ChangeDirection(Sprite.DOWN);

        Restart();
    }
}
