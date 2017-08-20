/* 
Level12: Map of tiles for the Level 12 / 20
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level12 : Level
{

    public Level12()
    {
        name = "Return Of The Alien Kong Beast";
        startingLevelData[ 0] = "L T   A   T      LA  L         L";
        startingLevelData[ 1] = "L                              L";
        startingLevelData[ 2] = "L              FF              L";
        startingLevelData[ 3] = "L              V               L";
        startingLevelData[ 4] = "L                              L";
        startingLevelData[ 5] = "LFFF     FFFFFL  LFFFFFFFF     L"; 
        startingLevelData[ 6] = "L V           L  L            FL"; 
        startingLevelData[ 7] = "L     FF      L VL             L"; 
        startingLevelData[ 8] = "L  F          L  L       FFFFFFL"; 
        startingLevelData[ 9] = "L         FFFFL  L             L"; 
        startingLevelData[10] = "L     F          LFFF          L"; 
        startingLevelData[11] = "L                L       FF    L"; 
        startingLevelData[12] = "LFFFFFF          L     A    A  L"; 
        startingLevelData[13] = "L          FFFLPPLDDDDDDDDDDDV L";
        startingLevelData[14] = "L             LPPL             L";
        startingLevelData[15] = "LFFFFFFFFFFFFFLLLLFFFFFFFFFFFFFL";

        numEnemies = 3;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy("data/level12_enemy1.png", myGame);
        enemyList[0].MoveTo(200, 352);
        enemyList[0].SetSpeed(2, 0);
        enemyList[0].SetMinMaxX(150, 300);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[1] = new Enemy("data/level12_enemy1.png", myGame);
        enemyList[1].MoveTo(280, 300);
        enemyList[1].SetSpeed(2, 0);
        enemyList[1].SetMinMaxX(280, 380);
        enemyList[1].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        enemyList[2] = new Enemy("data/level12_enemy1.png", myGame);
        enemyList[2].MoveTo(625, 185);
        enemyList[2].SetSpeed(2, 0);
        enemyList[2].SetMinMaxX(625, 725);
        enemyList[2].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        Restart();
    } 
}
