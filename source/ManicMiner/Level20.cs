/* 
Level20: Map of tiles for the Level 20 / 20
Part of Manic Miner Remake
@see Game Level Map

Nacho, 2011 & 2017
 
Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level20 : Level
{

    public Level20()
    {
        name = "This, folks, is the Last Cavern!";
        startingLevelData[ 0] = "MMMMMMMMMMMMMMMMTTTTTTTTTTTTMMMM";
        startingLevelData[ 1] = "MA  V    V     A      A    A  VM";
        startingLevelData[ 2] = "M                              M";
        startingLevelData[ 3] = "M                              M";
        startingLevelData[ 4] = "M                 MMMMMMMMMMMMMM";
        startingLevelData[ 5] = "M                 MPPM V       M"; 
        startingLevelData[ 6] = "MS    S    S    SSMPPM        VM"; 
        startingLevelData[ 7] = "M    FFFFFFFFFFFMMM  M         M"; 
        startingLevelData[ 8] = "M  SS                        SSM"; 
        startingLevelData[ 9] = "M                              M"; 
        startingLevelData[10] = "MDDDDDDDDDDDDDDDDDDDDDD   F    M"; 
        startingLevelData[11] = "M        AV A V A V         S  M"; 
        startingLevelData[12] = "MSS                            M"; 
        startingLevelData[13] = "M    SS                        M";
        startingLevelData[14] = "M                              M";
        startingLevelData[15] = "MSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSM";

        numEnemies = 4;
        enemyList = new Enemy[numEnemies];

        enemyList[0] = new Enemy(myGame);
        enemyList[0].MoveTo(400, 352);
        enemyList[0].SetSpeed(2, 0);
        enemyList[0].SetMinMaxX(100, 700);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[1] = new Enemy(myGame);
        enemyList[1].MoveTo(600, 300);
        enemyList[1].SetSpeed(0, 2);
        enemyList[1].SetMinMaxY(200, 350);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.DOWN);

        enemyList[2] = new Enemy(myGame);
        enemyList[2].MoveTo(100, 233);
        enemyList[2].SetSpeed(2, 0);
        enemyList[2].SetMinMaxX(100, 500);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        enemyList[3] = new Enemy(myGame);
        enemyList[3].MoveTo(420, 100);
        enemyList[3].SetSpeed(2, 0);
        enemyList[3].SetMinMaxX(100, 700);
        enemyList[0].SetWidthHeight(36, 48);
        //enemyList[0].ChangeDirection(Sprite.RIGHT);

        Restart();
    }
}
