using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace Minesweeper
{
    public class MinesweeperModel
    {
        public enum Point
        {
            Pressed,
            Clear,
            Bomb
        }

        public static int bombCount = 10;
        public static int[,] tableCounter = new int[8, 10];
        public static Point[,] pointTable = new Point[8, 10];
        public static List<int> newXYList = new List<int>();
        public static bool gameStart = true;
        public static Random random = new Random();


        public static HashSet<int> BombSpots(int skip)
        {
            HashSet<int> bombs = new HashSet<int>();
            while (bombs.Count != bombCount)
            {
                int bombLocation = random.Next(79);
                if (bombLocation != skip)
                {
                    bombs.Add(bombLocation);
                }
            }
            return bombs;
        }

        public static void TablePointCreator(HashSet<int> bombs)
        {
            int tableSpot = 0;
            var rowCount = pointTable.GetLength(0);
            var colCount = pointTable.GetLength(1);
            for (int col = 0; col < colCount; col++)
            {
                for (int row = 0; row < rowCount; row++)
                {
                    if (bombs.Contains(tableSpot))
                    {
                        pointTable[row, col] = Point.Bomb;
                    }
                    else
                    {
                        pointTable[row, col] = Point.Clear;
                    }

                    tableSpot++;
                }
            }
        }

        public static void NumberCreator()
        {
            var rowCount = pointTable.GetLength(0);
            var colCount = pointTable.GetLength(1);

            for (int col = 0; col < colCount; col++)
            {
                for (int row = 0; row < rowCount; row++)
                {
                    if (pointTable[row, col] != Point.Bomb)
                    {
                        int bombNearCount = 0;
                        for (int k = -1; k < 2; k++)
                        {
                            for (int l = -1; l < 2; l++)
                            {
                                if (k != 0 || l != 0)
                                {
                                    try {
                                        if (pointTable[row + k, col + l].Equals(Point.Bomb))
                                        {
                                            bombNearCount++;
                                        }
                                    }catch{}
                                }
                            }
                        }

                        tableCounter[row, col] = bombNearCount;
                    }
                }
            }
        }

        public static void PlayerStart(int x, int y)
        {
            int skip = 8*y + x;
            TablePointCreator(BombSpots(skip));
            NumberCreator();
            PlayerMoveChecker(x, y);
        }

        public static bool PlayerMoveChecker(int x, int y)
        {
            if (pointTable[x, y] == Point.Bomb) { return false; }
            pointTable[x, y] = Point.Pressed;
            if (gameStart) {
                gameStart = false;
                PieceFlipper(x, y);
            }
            else { PieceFlipper1(x,y); }
            return true;
        }

        public static void PieceFlipper(int x, int y)
        {
            int checker = 8 * y + x;
            if (!newXYList.Contains(checker)){
                newXYList.Add(checker);
                for (int k = -1; k < 2; k++)
                {
                    for (int l = -1; l < 2; l++) {
                        if (k != 0 || l != 0) {
                            int newX = x + k;
                            int newY = y + l;
                            try {
                                if (pointTable[newX, newY] != Point.Bomb)
                                {
                                    if (tableCounter[newX, newY] == 0)
                                    {
                                        pointTable[newX, newY] = Point.Pressed;
                                        PieceFlipper(newX, newY);
                                    }
                                    else
                                    {
                                        pointTable[newX, newY] = Point.Pressed;
                                    }
                                }
                            }catch {}
                        }
                    }
                }
            }
        }

        public static void PieceFlipper1(int x, int y)
        {
            int checker = 8 * y + x;
            if (!newXYList.Contains(checker))
            {
                pointTable[x, y] = Point.Pressed;
                if (tableCounter[x, y] == 0 && pointTable[x, y] != Point.Bomb)
                {
                    PieceFlipper(x,y);
                }
            }
        }
    }
}