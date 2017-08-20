/*
Level: Basic logic for a level
Part of Manic Miner Remake
@see Game GameScreen

Nacho, 2011 & 2017

Versions:
   
Num.  Date         Changes
----  -----------  --------------------------------
0.20  20-Ago-2017  Almost identical to 0.15, but translated to English
*/

public class Level
{

    protected Game myGame;

    private int mapHeight = 16, mapWidth = 32;
    private int tileWidth = 32, tileHeight = 32;
    private int leftMargin = 0, topMargin = 0;
    private int remainingItems = 4;   // Arbitrary; 0 = end of the game

    protected int numEnemies;
    protected Enemy[] enemyList;

    private Image tree, sliding, brick, brickX, key, door,
        floorThin, floorFragile, floorFragile2, floorThick, stalactite;


    protected string name = "(Nonamed)";

    string[] levelData;  // Data are filled when entering each real level

    protected string[] startingLevelData =  // Starting data
    {"LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL",
     "L                              L",
     "L                              L",
     "L                              L",
     "L                              L",
     "L                              L",
     "L                              L",
     "L                              L",
     "L                              L",
     "L                              L",
     "L                              L",
     "L                              L",
     "L                              L",
     "L                            PPL",
     "L                            PPL",
     "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL"};

    public Level()
    {
        tree = new Image("data/level01_tree.png");
        sliding = new Image("data/level01_floorSliding1.png");
        brick = new Image("data/level01_wall.png");
        brickX = new Image("data/level02_wall.png");
        key = new Image("data/level01_item.png");
        door = new Image("data/level01_door.png");
        floorThin = new Image("data/level01_floor.png");
        floorThick = new Image("data/level03_floor.png");
        floorFragile = new Image("data/level01_floorFragile.png");
        floorFragile2 = new Image("data/level02_floorFragile.png");
        stalactite = new Image("data/level01_stalactite.png");

        levelData = new string[mapHeight];

        numEnemies = 0;
        Restart();
    }

    public void Restart()
    {
        for (int fila = 0; fila < mapHeight; fila++)
            levelData[fila] = startingLevelData[fila];
    }

    public void DrawOnHiddenScreen()
    {
        // Let's draw the background
        remainingItems = 0;
        for (int row = 0; row < mapHeight; row++)
            for (int column = 0; column < mapWidth; column++)
            {
                int posX = column * tileWidth + leftMargin;
                int posY = row * tileHeight + topMargin;
                switch (levelData[row][column])
                {
                    case 'A': SdlHardware.DrawHiddenImage(tree, posX, posY); break;
                    case 'D': SdlHardware.DrawHiddenImage(sliding, posX, posY); break;
                    case 'F': SdlHardware.DrawHiddenImage(floorFragile, posX, posY); break;
                    case 'L': SdlHardware.DrawHiddenImage(brick, posX, posY); break;
                    case 'M': SdlHardware.DrawHiddenImage(brickX, posX, posY); break;
                    case 'N': SdlHardware.DrawHiddenImage(floorThick, posX, posY); break;
                    case 'O': SdlHardware.DrawHiddenImage(floorFragile2, posX, posY); break;
                    case 'P': SdlHardware.DrawHiddenImage(door, posX, posY); break;
                    case 'S': SdlHardware.DrawHiddenImage(floorThin, posX, posY); break;
                    case 'T': SdlHardware.DrawHiddenImage(stalactite, posX, posY); break;
                    case '[': SdlHardware.DrawHiddenImage(floorThin, posX, posY); break;
                    case ']': SdlHardware.DrawHiddenImage(floorThin, posX, posY); break;
                    case 'V':
                        SdlHardware.DrawHiddenImage(key, posX, posY);
                        remainingItems++; break;
                }
            }
    }

    // Returns true if we can move to a certain position of the screen
    public bool CanMoveTo(int x, int y, int xmax, int ymax)
    {

        // Let's check if we hit any tile of the background
        for (int row = 0; row < mapHeight; row++)
            for (int column = 0; column < mapWidth; column++)
            {
                // Let's get the coordinates for each tile
                int posX = column * tileWidth + leftMargin;
                int posY = row * tileHeight + topMargin;
                // And see if it overlaps with the intended position
                if ((posX + tileWidth > x) && (posY + tileHeight > y)
                    && (xmax > posX) && (ymax > posY))
                    // And it it is not a blank, item or tree
                    if ((levelData[row][column] != ' ')
                        && (levelData[row][column] != 'V')
                        && (levelData[row][column] != 'P')
                        && (levelData[row][column] != 'A'))
                    {
                        return false;
                    }
            }

        return true;
    }

    // Returns the point we get if we move to a certain position:
    // 50 = door to next level
    // 10 = item we can pick
    // 0 = blank space
    // -1 = obstacle, we must loose a life
    public int GetPointsFromPos(int x, int y, int xmax, int ymax)
    {
        // Let's check if we hit any tile of the background
        for (int row = 0; row < mapHeight; row++)
            for (int column = 0; column < mapWidth; column++)
            {
                // Let's get the coordinates for each tile
                int posX = column * tileWidth + leftMargin;
                int posY = row * tileHeight + topMargin;

                // And see if it overlaps with the intended position
                if ((posX + tileWidth > x) && (posY + tileHeight > y)
                    && (xmax > posX) && (ymax > posY))
                {
                    // IF we hit an stalactite or a tree
                    if ((levelData[row][column] == 'T')
                             || (levelData[row][column] == 'A'))
                        return -1; // (score -1: lose life)

                    // If we hit an item, we get points
                    if (levelData[row][column] == 'V')
                    {
                        // datosLevel[row][column] = ' '; (Not valid in C#, so 2 steps)
                        levelData[row] = levelData[row].Remove(column, 1);
                        levelData[row] = levelData[row].Insert(column, " ");
                        return 10;
                    }

                    // If we hit the door, and there are no remaining items
                    // 50 points and advance to the next level
                    if ((levelData[row][column] == 'P')
                        && (remainingItems == 0))
                    {
                        return 50;
                    }

                } // End of checking the current tile
            } // End of "for" to check all tiles

        // If we get to this point, there are no points to return
        return 0;

    }

    public string GetName()
    {
        return name;
    }

    public int GetNumEnemies()
    {
        return numEnemies;
    }

    public Enemy GetEnemy(int i)
    {
        if (numEnemies > i)
            return enemyList[i];

        return null;
    }
}
