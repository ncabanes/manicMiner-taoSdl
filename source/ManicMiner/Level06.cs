/* 
Level06: Map of tiles for the Level 06 / 20
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level06 : Level
{

    public Level06()
    {
        name = "Processing Plant";
        startingLevelData[ 0] = "L                            PPL";
        startingLevelData[ 1] = "L                            PPL";
        startingLevelData[ 2] = "L                              L";
        startingLevelData[ 3] = "L                              L";
        startingLevelData[ 4] = "L                    A         L";
        startingLevelData[ 5] = "L       NNN    NN    NNNNN     L"; 
        startingLevelData[ 6] = "L  NN          VLV          NNNL"; 
        startingLevelData[ 7] = "L               L             VL"; 
        startingLevelData[ 8] = "L                      NNNNN   L"; 
        startingLevelData[ 9] = "LNN                            L"; 
        startingLevelData[10] = "LV     NNNNNNNNNLNNNNNNNNN     L"; 
        startingLevelData[11] = "L            V  LA             L"; 
        startingLevelData[12] = "L               L           NNNL"; 
        startingLevelData[13] = "L  DDDD               NN       L";
        startingLevelData[14] = "L                              L";
        startingLevelData[15] = "LNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNL";

        numEnemies = 5;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy("data/level06_enemy1.png", myGame);
        enemyList[0].MoveTo(400, 352);
        enemyList[0].SetSpeed(2, 0);
        enemyList[0].SetMinMaxX(100, 700);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[1] = new Enemy("data/level06_enemy1.png", myGame);
        enemyList[1].MoveTo(150, 200);
        enemyList[1].SetSpeed(0, 2);
        enemyList[1].SetMinMaxY(100, 300);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        enemyList[2] = new Enemy("data/level06_enemy1.png", myGame);
        enemyList[2].MoveTo(400, 352);
        enemyList[2].SetSpeed(2, 0);
        enemyList[2].SetMinMaxX(100, 700);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[3] = new Enemy("data/level06_enemy1.png", myGame);
        enemyList[3].MoveTo(400, 352);
        enemyList[3].SetSpeed(2, 0);
        enemyList[3].SetMinMaxX(100, 700);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[4] = new Enemy("data/level06_enemy2.png", myGame);
        enemyList[4].MoveTo(400, 352);
        enemyList[4].SetSpeed(2, 0);
        enemyList[4].SetMinMaxX(100, 700);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        Restart();
    } 
}
