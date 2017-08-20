/* 
Level19: Map of tiles for the Level 19 / 20
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level19 : Level
{

    public Level19()
    {
        name = "Solar Power Generator";
        startingLevelData[ 0] = "LLL                     F      L";
        startingLevelData[ 1] = "LPP                     F     VL";
        startingLevelData[ 2] = "LPP                     F      L";
        startingLevelData[ 3] = "L                       F      L";
        startingLevelData[ 4] = "L                       F      L";
        startingLevelData[ 5] = "LV SS     SSSSSS        FSSSSSSL"; 
        startingLevelData[ 6] = "L                       F      L"; 
        startingLevelData[ 7] = "L                       F      L"; 
        startingLevelData[ 8] = "L                   SSS FSSSSSSL"; 
        startingLevelData[ 9] = "LSS         SSS         F      L"; 
        startingLevelData[10] = "L                       F      L"; 
        startingLevelData[11] = "L                   SS  FSSSSSSL"; 
        startingLevelData[12] = "LSSSS                   F     VL"; 
        startingLevelData[13] = "L       DDDD    SSSSS   F      L";
        startingLevelData[14] = "LLL                     F      L";
        startingLevelData[15] = "LLLSSSSSSSSSSSSSSSSSSSSSLSSSSSSL";

        numEnemies = 7;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy("data/level19_enemy2.png", myGame);
        enemyList[0].MoveTo(700, 111);
        enemyList[0].SetSpeed(2, 0);
        enemyList[0].SetMinMaxX(625, 725);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[1] = new Enemy("data/level19_enemy2.png", myGame);
        enemyList[1].MoveTo(700, 183);
        enemyList[1].SetSpeed(2, 0);
        enemyList[1].SetMinMaxX(625, 725);
        enemyList[1].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        enemyList[2] = new Enemy("data/level19_enemy2.png", myGame);
        enemyList[2].MoveTo(700, 255);
        enemyList[2].SetSpeed(2, 0);
        enemyList[2].SetMinMaxX(625, 725);
        enemyList[2].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[3] = new Enemy("data/level19_enemy2.png", myGame);
        enemyList[3].MoveTo(500, 350);
        enemyList[3].SetSpeed(2, 0);
        enemyList[3].SetMinMaxX(93, 555);
        enemyList[3].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);



        enemyList[4] = new Enemy("data/level19_enemy1.png", myGame);
        enemyList[4].MoveTo(150, 100);
        enemyList[4].SetSpeed(0, 2);
        enemyList[4].SetMinMaxY(100, 350);
        enemyList[4].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        enemyList[5] = new Enemy("data/level19_enemy1.png", myGame);
        enemyList[5].MoveTo(260, 200);
        enemyList[5].SetSpeed(0, 2);
        enemyList[5].SetMinMaxY(187, 300);
        enemyList[5].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[6] = new Enemy("data/level19_enemy1.png", myGame);
        enemyList[6].MoveTo(420, 101);
        enemyList[6].SetSpeed(0, 2);
        enemyList[6].SetMinMaxY(100, 300);
        enemyList[6].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        Restart();
    } 
}
