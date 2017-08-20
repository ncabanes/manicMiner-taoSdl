/* 
Level07: Map of tiles for the Level 07 / 20
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level07 : Level
{

    public Level07()
    {
        name = "The vat";
        startingLevelData[ 0] = "M             MMMMMMMMMMMMMMMMMM";
        startingLevelData[ 1] = "M                              M";
        startingLevelData[ 2] = "M                              M";
        startingLevelData[ 3] = "M              NNMFFFFFFFFFFFFVM";
        startingLevelData[ 4] = "M                MFFFFFFFFFFFFFM";
        startingLevelData[ 5] = "M             NNNMFFFFFFFFFFAFFM"; 
        startingLevelData[ 6] = "MNNN             MFFVFFFFFFFFFFM"; 
        startingLevelData[ 7] = "M                MFFFFFFFFFVFFFM"; 
        startingLevelData[ 8] = "MN               MFFFFFAFFFFFFFM"; 
        startingLevelData[ 9] = "M             NNNMFFFFFFFFFFFFFM"; 
        startingLevelData[10] = "MNNNNNNNNNNN     MFVFFFFFFFFAFFM"; 
        startingLevelData[11] = "M                MFFFFFFFFFFFFVM"; 
        startingLevelData[12] = "M             MMMMFFFFFAFFFFFFFM"; 
        startingLevelData[13] = "M       NNN   MPP              M";
        startingLevelData[14] = "M             MPP              M";
        startingLevelData[15] = "MNNNNNNNNNNNNNMMMMMMMMMMMMMMMMMM";

        numEnemies = 3;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy("data/level07_enemy.png", myGame);
        enemyList[0].MoveTo(430, 350);
        enemyList[0].SetSpeed(2, 0);
        enemyList[0].SetMinMaxX(430, 726);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[1] = new Enemy("data/level07_enemy.png", myGame);
        enemyList[1].MoveTo(70, 231);
        enemyList[1].SetSpeed(2, 0);
        enemyList[1].SetMinMaxX(70, 275);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[2] = new Enemy("data/level07_enemy.png", myGame);
        enemyList[2].MoveTo(375, 64);
        enemyList[2].SetSpeed(2, 0);
        enemyList[2].SetMinMaxX(375, 726);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        Restart();
    } 
}
