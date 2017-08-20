/* 
Level18: Map of tiles for the Level 18 / 20
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level18 : Level
{

    public Level18()
    {
        name = "Amoebatrons' Revenge";
        startingLevelData[ 0] = "L                           LPPL";
        startingLevelData[ 1] = "L               V            PPL";
        startingLevelData[ 2] = "L                              L";
        startingLevelData[ 3] = "L                              L";
        startingLevelData[ 4] = "L                              L";
        startingLevelData[ 5] = "L  SS  SSS  SSSSSSSS  SSS  SSSSL"; 
        startingLevelData[ 6] = "L                              L"; 
        startingLevelData[ 7] = "LSS                            L"; 
        startingLevelData[ 8] = "L           SSSSSSSS  SSS  SS  L"; 
        startingLevelData[ 9] = "L  SS  SSS                     L"; 
        startingLevelData[10] = "L                            SSL"; 
        startingLevelData[11] = "L                              L"; 
        startingLevelData[12] = "L  SS  SSS  SSSSSSSS  SSS  SS  L"; 
        startingLevelData[13] = "LSS                            L";
        startingLevelData[14] = "L                              L";
        startingLevelData[15] = "SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS";

        numEnemies = 8;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy("data/level09_enemy1.png", myGame);
        enemyList[0].MoveTo(400, 352);
        enemyList[0].SetSpeed(2, 0);
        enemyList[0].SetMinMaxX(100, 700);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[1] = new Enemy("data/level09_enemy1.png", myGame);
        enemyList[1].MoveTo(310, 280);
        enemyList[1].SetSpeed(2, 0);
        enemyList[1].SetMinMaxX(300, 475);
        enemyList[1].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        enemyList[2] = new Enemy("data/level09_enemy1.png", myGame);
        enemyList[2].MoveTo(350, 183);
        enemyList[2].SetSpeed(2, 0);
        enemyList[2].SetMinMaxX(300, 475);
        enemyList[2].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        enemyList[3] = new Enemy("data/level09_enemy1.png", myGame);
        enemyList[3].MoveTo(450, 111);
        enemyList[3].SetSpeed(2, 0);
        enemyList[3].SetMinMaxX(300, 475);
        enemyList[3].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        enemyList[4] = new Enemy("data/level18_enemy1.png", myGame);
        enemyList[4].MoveTo(150, 200);
        enemyList[4].SetSpeed(0, 2);
        enemyList[4].SetMinMaxY(100, 300);
        enemyList[4].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        enemyList[5] = new Enemy("data/level18_enemy1.png", myGame);
        enemyList[5].MoveTo(270, 110);
        enemyList[5].SetSpeed(0, 2);
        enemyList[5].SetMinMaxY(100, 300);
        enemyList[5].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        enemyList[6] = new Enemy("data/level18_enemy1.png", myGame);
        enemyList[6].MoveTo(500, 250);
        enemyList[6].SetSpeed(0, 2);
        enemyList[6].SetMinMaxY(100, 300);
        enemyList[6].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        enemyList[7] = new Enemy("data/level18_enemy1.png", myGame);
        enemyList[7].MoveTo(625, 180);
        enemyList[7].SetSpeed(0, 2);
        enemyList[7].SetMinMaxY(100, 300);
        enemyList[7].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        Restart();
    }
}
