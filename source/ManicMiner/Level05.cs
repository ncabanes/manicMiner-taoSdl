/* 
Level05: Map of tiles for the fifth Level  
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level05 : Level
{

    public Level05()
    {
        name = "Eugene Was Here";
        startingLevelData[ 0] = "L                   T          L";
        startingLevelData[ 1] = "L                             VL";
        startingLevelData[ 2] = "L                              L";
        startingLevelData[ 3] = "L                              L";
        startingLevelData[ 4] = "L                       A      L";
        startingLevelData[ 5] = "LNNNNNNNNNNNNN    DDDDNNNNNN   L";
        startingLevelData[ 6] = "L         V                  DDL";
        startingLevelData[ 7] = "L                    A       V L";
        startingLevelData[ 8] = "L                 FFFFFFFFFF   L";
        startingLevelData[ 9] = "L   NNNNNNNNNN                 L";
        startingLevelData[10] = "L                              L";
        startingLevelData[11] = "LDDNNNNNNNNNNN    NNNNNNN     NL";
        startingLevelData[12] = "L      VLV                     L";
        startingLevelData[13] = "LNN     L     LPPL             L";
        startingLevelData[14] = "L    A  L     LPPLLLLLLLAA     L";
        startingLevelData[15] = "LNNNNNNNLLLLLLLLLLLLLLLLNNNNNNNL";

        numEnemies = 3;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy("data/level05_enemy1.png", myGame);
        enemyList[0].MoveTo(400, 352);
        enemyList[0].SetSpeed(2, 0);
        enemyList[0].SetMinMaxX(100, 700);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[1] = new Enemy("data/level05_enemy2.png", myGame);
        enemyList[1].MoveTo(380, 100);
        enemyList[1].SetSpeed(0, 2);
        enemyList[1].SetMinMaxY(100, 300);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        enemyList[2] = new Enemy("data/level05_enemy1.png", myGame);
        enemyList[2].MoveTo(150, 200);
        enemyList[2].SetSpeed(0, 2);
        enemyList[2].SetMinMaxY(100, 300);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        Restart();
    }
}
