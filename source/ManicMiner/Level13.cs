/* 
Level13: Map of tiles for the Level 13 / 20
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level13 : Level
{

    public Level13()
    {
        name = "Ore Refinery";
        startingLevelData[ 0] = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
        startingLevelData[ 1] = "L  O                           L";
        startingLevelData[ 2] = "L  O                           L";
        startingLevelData[ 3] = "L  O   MMMMMMMMMMMMMMMMMM VMMMML";
        startingLevelData[ 4] = "L  O                           L";
        startingLevelData[ 5] = "L  O                           L"; 
        startingLevelData[ 6] = "L  O   MM VMMMM  MMMMM  MMMM  ML"; 
        startingLevelData[ 7] = "L  O                           L"; 
        startingLevelData[ 8] = "L  O                           L"; 
        startingLevelData[ 9] = "L  O   MMMMM  MMM  VMMMMM VMMMML"; 
        startingLevelData[10] = "L  O                           L"; 
        startingLevelData[11] = "L  O                           L"; 
        startingLevelData[12] = "L  O   MMM VMMM  MMMM  MMMM  MML"; 
        startingLevelData[13] = "LPPO                           L";
        startingLevelData[14] = "LPPO                           L";
        startingLevelData[15] = "LMMFFFFFFFFFFFFFFFFFFFFFFFFFFMML";

        numEnemies = 4;
        enemyList = new Enemy[numEnemies];

        // Enemy in the floor 4
        enemyList[1] = new Enemy("data/level13_enemy1.png", myGame);
        enemyList[1].MoveTo(227, 64);
        enemyList[1].SetSpeed(2, 0);
        enemyList[1].SetMinMaxX(200, 700);
        enemyList[1].SetWidthHeight(36, 48);

        // Enemy in the floor 3
        enemyList[2] = new Enemy("data/level13_enemy1.png", myGame);
        enemyList[2].MoveTo(340, 136);
        enemyList[2].SetSpeed(2, 0);
        enemyList[2].SetMinMaxX(200, 700);
        enemyList[2].SetWidthHeight(36, 48);

        // Enemy in the floor 2
        enemyList[0] = new Enemy("data/level13_enemy1.png", myGame);
        enemyList[0].MoveTo(400, 208);
        enemyList[0].SetSpeed(2, 0);
        enemyList[0].SetMinMaxX(200, 700);
        enemyList[0].SetWidthHeight(36, 48);

        // Enemy in the floor 1
        enemyList[3] = new Enemy("data/level13_enemy1.png", myGame);
        enemyList[3].MoveTo(420, 280);
        enemyList[3].SetSpeed(2, 0);
        enemyList[3].SetMinMaxX(200, 700);
        enemyList[3].SetWidthHeight(36, 48);

        Restart();
    } 
}
