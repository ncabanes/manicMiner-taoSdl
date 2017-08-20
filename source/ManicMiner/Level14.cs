/* 
Level14: Map of tiles for the Level 14 / 20
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level14 : Level
{

    public Level14()
    {
        name = "Skylab Landing Bay";
        startingLevelData[0] = "b              PP              b";
        startingLevelData[1] = "b              PP              b";
        startingLevelData[2] = "b                      V       b";
        startingLevelData[3] = "b                              b";
        startingLevelData[4] = "b                              b";
        startingLevelData[5] = "b              []              b";
        startingLevelData[6] = "b  []      []      []      []  b";
        startingLevelData[7] = "b      []       V      []  V   b";
        startingLevelData[8] = "b  V                           b";
        startingLevelData[9] = "b    []      []      []      []b";
        startingLevelData[10] = "b                              b";
        startingLevelData[11] = "b[]      []     OOOOOO    []   b";
        startingLevelData[12] = "b                              b";
        startingLevelData[13] = "bL      []                      b";
        startingLevelData[14] = "b                              b";
        startingLevelData[15] = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb";

        numEnemies = 3;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy("data/level14_enemy1.png", myGame);
        enemyList[0].MoveTo(200, 300);
        enemyList[0].SetSpeed(2, 0);
        enemyList[0].SetMinMaxY(200, 800);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        enemyList[1] = new Enemy("data/level14_enemy1.png", myGame);
        enemyList[1].MoveTo(270, 370);
        enemyList[1].SetSpeed(2, 0);
        enemyList[1].SetMinMaxY(200, 800);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        enemyList[2] = new Enemy("data/level14_enemy1.png", myGame);
        enemyList[2].MoveTo(150, 200);
        enemyList[2].SetSpeed(2, 0);
        enemyList[2].SetMinMaxY(200, 800);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        Restart();
    } 
}
