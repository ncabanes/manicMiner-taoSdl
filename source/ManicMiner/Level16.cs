/* 
Level16: Map of tiles for the Level 16 / 20
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level16 : Level
{

    public Level16()
    {
        name = "The Sixteenth Cavern";
        startingLevelData[ 0] = "LV                             L";
        startingLevelData[ 1] = "L                              L";
        startingLevelData[ 2] = "L                             VL";
        startingLevelData[ 3] = "L                              L";
        startingLevelData[ 4] = "L                              L";
        startingLevelData[ 5] = "LS     S    LPPL      SSS      L"; 
        startingLevelData[ 6] = "L           LPPLL              L"; 
        startingLevelData[ 7] = "L    S      L VLLL       SSSSSSL"; 
        startingLevelData[ 8] = "L           L  LLLL            L"; 
        startingLevelData[ 9] = "LSSDDDDDDDDDDDDDDDDDDDDDDDD    L"; 
        startingLevelData[10] = "L                V             L"; 
        startingLevelData[11] = "L         LLSS            S    L"; 
        startingLevelData[12] = "LSSSSSSSSS                     L"; 
        startingLevelData[13] = "L                   S     S    L";
        startingLevelData[14] = "L                              L";
        startingLevelData[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";

        numEnemies = 2;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy(myGame);
        enemyList[0].MoveTo(400, 352);
        enemyList[0].SetSpeed(2, 0);
        enemyList[0].SetMinMaxX(100, 700);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[1] = new Enemy(myGame);
        enemyList[1].MoveTo(200, 280);
        enemyList[1].SetSpeed(2, 0);
        enemyList[1].SetMinMaxY(100, 300);
        enemyList[1].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        /*enemyList[2] = new Enemy(c);
        enemyList[2].MoveTo(400, 352);
        enemyList[2].SetSpeed(2, 0);
        enemyList[2].SetMinMaxX(100, 700);
        enemyList[1].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[3] = new Enemy(c);
        enemyList[3].MoveTo(400, 352);
        enemyList[3].SetSpeed(2, 0);
        enemyList[3].SetMinMaxX(100, 700);
        enemyList[3].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);*/

        Restart();
    } 
}
