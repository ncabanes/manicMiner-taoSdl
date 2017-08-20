/* 
Level04: Map of tiles for the fourth Level  
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level04 : Level
{

    public Level04()
    {
        name = "Abandoned Uranium Workings";
        startingLevelData[ 0] = "LV     T      LLLLLLLLLLLLLLLLLL";
        startingLevelData[ 1] = "L           V            V   PPL";
        startingLevelData[ 2] = "L                            PPL";
        startingLevelData[ 3] = "L                  SSSSSS      L";
        startingLevelData[ 4] = "L                          SSSSL";
        startingLevelData[ 5] = "LS     S         S             L";
        startingLevelData[ 6] = "L           SS  V    SSS      VL";
        startingLevelData[ 7] = "LFFF                           L";
        startingLevelData[ 8] = "L      SS                 SSS  L";
        startingLevelData[ 9] = "L                 SSS          L";
        startingLevelData[10] = "LDDD                          SL";
        startingLevelData[11] = "L           SSS       SSS      L";
        startingLevelData[12] = "L     SS               T    SSSL";
        startingLevelData[13] = "L                 SS           L";
        startingLevelData[14] = "L                              L";
        startingLevelData[15] = "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL";


        numEnemies = 2;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy("data/level04_enemy.png", myGame);
        enemyList[0].MoveTo(300, 352);
        enemyList[0].SetSpeed(2, 0);
        enemyList[0].SetMinMaxX(100, 700);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[1] = new Enemy("data/level04_enemy.png", myGame);
        enemyList[1].MoveTo(400, 352);
        enemyList[1].SetSpeed(2, 0);
        enemyList[1].SetMinMaxX(100, 700);
        enemyList[1].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        Restart();
    }
}
