/* 
Level17: Map of tiles for the Level 17 / 20
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level17 : Level
{
    public Level17()
    {
        name = "The Warehouse";
        startingLevelData[ 0] = "L                            LLL";
        startingLevelData[ 1] = "L                            PPL";
        startingLevelData[ 2] = "L                            PPL";
        startingLevelData[ 3] = "L                              L";
        startingLevelData[ 4] = "L     A  A   A  A     A A      L";
        startingLevelData[ 5] = "LSSFFFFFFF  FFFFFFF  FFFVFF  SSL";
        startingLevelData[ 6] = "LFFTFFFFFF  FFFFFFF  FFFFFF  FFL";
        startingLevelData[ 7] = "LFFFFFFFFF  FFFVFFF  FFFFFT  FFL";
        startingLevelData[ 8] = "LFF  FFFFF  FFDDDDD  FFFFFF  FFL";
        startingLevelData[ 9] = "LVF  FFFFF  FFFFFFF  FFFFFF  FFL";
        startingLevelData[10] = "LFF  FFFFF  FFFFFFFVFFTFFFF  FFL";
        startingLevelData[11] = "LFF  FFFFT  FFFFFFFFFFFFFFV  FFL";
        startingLevelData[12] = "LFF  FFFFF  FFFFFFFFFFFFFFF  FFL";
        startingLevelData[13] = "L                              L";
        startingLevelData[14] = "L                          SSSSL";
        startingLevelData[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

        numEnemies = 4;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy("data/level17_enemy1.png", myGame);
        enemyList[0].MoveTo(400, 352);
        enemyList[0].SetSpeed(2, 0);
        enemyList[0].SetMinMaxX(50, 635);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[1] = new Enemy("data/level17_enemy1.png", myGame);
        enemyList[1].MoveTo(90, 250);
        enemyList[1].SetSpeed(0, 2);
        enemyList[1].SetMinMaxY(225, 300);
        enemyList[1].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        enemyList[2] = new Enemy("data/level17_enemy2.png", myGame);
        enemyList[2].MoveTo(300, 352);
        enemyList[2].SetSpeed(2, 0);
        enemyList[2].SetMinMaxX(50, 635);
        enemyList[2].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[3] = new Enemy("data/level17_enemy1.png", myGame);
        enemyList[3].MoveTo(260, 300);
        enemyList[3].SetSpeed(0, 2);
        enemyList[3].SetMinMaxY(100, 300);
        enemyList[3].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);
        Restart();
    }
}
