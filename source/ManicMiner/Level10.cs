/* 
Level10: Map of tiles for the Level 10 / 20
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level10 : Level
{

    public Level10()
    {
        name = "The Endorian Forest";
        startingLevelData[ 0] = "M             LLLM   LLLLLLLLLLM";
        startingLevelData[ 1] = "M              V M             M";
        startingLevelData[ 2] = "MLLLLLL          M   V     LLLLM";
        startingLevelData[ 3] = "M                M             M";
        startingLevelData[ 4] = "M                MLLLL         M";
        startingLevelData[ 5] = "M        LFFFFFFFM     LLLLLLLLM"; 
        startingLevelData[ 6] = "MLLLL            M             M"; 
        startingLevelData[ 7] = "M                MLLLLLLLFFF   M"; 
        startingLevelData[ 8] = "MLLLLL           M V           M"; 
        startingLevelData[ 9] = "M         LLLLLLLM           LLM"; 
        startingLevelData[10] = "MLLLLFF          MLLLLLLL      M"; 
        startingLevelData[11] = "M                M       FFF   M"; 
        startingLevelData[12] = "M         MMMMMMMMM            M"; 
        startingLevelData[13] = "MLLL         PP             LLLM";
        startingLevelData[14] = "M            PP                M";
        startingLevelData[15] = "NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN";

        numEnemies = 4;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy("data/level10_enemy.png", myGame);
        enemyList[0].MoveTo(400, 352);
        enemyList[0].SetSpeed(2, 0);
        enemyList[0].SetMinMaxX(100, 700);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[1] = new Enemy("data/level10_enemy.png", myGame);
        enemyList[1].MoveTo(400, 200);
        enemyList[1].SetSpeed(2, 0);
        enemyList[1].SetMinMaxY(200, 400);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        enemyList[2] = new Enemy("data/level10_enemy.png", myGame);
        enemyList[2].MoveTo(400, 250);
        enemyList[2].SetSpeed(2, 0);
        enemyList[2].SetMinMaxY(200, 400);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        enemyList[3] = new Enemy("data/level10_enemy.png", myGame);
        enemyList[3].MoveTo(600, 100);
        enemyList[3].SetSpeed(2, 0);
        enemyList[3].SetMinMaxY(550, 750);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        Restart();
    } 
}
