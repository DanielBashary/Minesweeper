using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minesweeper;

namespace HelloGithubClassroom
{
    [TestClass]
    public class Program
    {
        [TestMethod]
        public void CheckPieceFlipping()
        {
            var rowCount = MinesweeperModel.pointTable.GetLength(0);
            var colCount = MinesweeperModel.pointTable.GetLength(1);
            for (int col = 0; col < colCount; col++)
            {
                for (int row = 0; row < rowCount; row++)
                    MinesweeperModel.tableCounter[row, col] = 0;
            }

            MinesweeperModel.PieceFlipper(3, 3);
            for (int col = 0; col < colCount; col++)
            {
                for (int row = 0; row < rowCount; row++)
                    Assert.AreEqual(MinesweeperModel.Point.Pressed, MinesweeperModel.pointTable[row, col]);
            }
        }

        [TestMethod]
        public void BombPieceFlipperTableCounterChecker()
        {
            HashSet<int> bombs = new HashSet<int>() {0, 1, 2, 3};
            MinesweeperModel.TablePointCreator(bombs);
            MinesweeperModel.NumberCreator();

            var rowCount = MinesweeperModel.pointTable.GetLength(0);
            var colCount = MinesweeperModel.pointTable.GetLength(1);

            MinesweeperModel.PieceFlipper(0,5);
            Assert.AreEqual(3, MinesweeperModel.tableCounter[1, 1]);
            Assert.AreEqual(2, MinesweeperModel.tableCounter[0, 1]);
            for (int col = 0; col < colCount; col++)
            {
                for (int row = 0; row < rowCount; row++)
                {
                    if (row == 0 && col == 0 || row == 1 && col == 0 || row == 2 && col == 0 || row == 3 && col == 0)
                    {
                        Assert.AreEqual(MinesweeperModel.pointTable[row, col], MinesweeperModel.Point.Bomb);
                    }
                    else
                    {
                        Assert.AreEqual(MinesweeperModel.pointTable[row, col], MinesweeperModel.Point.Pressed);
                    }
                }
            }
        }
    }
}