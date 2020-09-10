using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammingCodes
{
    public class Ham4x4
    {
        private int[] baseData;
        private int[] parityBitIndicies = new int[] { 1, 2, 4, 8, 0 };
        private int[] linearGrid = new int[16];

        public Ham4x4(int[] data)
        {
            if (data.Count() != 11)
            {
                throw new ArgumentException("There should be exactly 11 data entries given to the hammer.");
            }
            baseData = data.ToArray();
        }

        public int[,] CreateGrid()
        {
            int[,] grid = new int[4,4];

            int baseDataIndex = 0;
            for (int linearGridIndex = baseDataIndex; linearGridIndex < 16; linearGridIndex++)
            {
                if (parityBitIndicies.Contains(linearGridIndex))
                {
                    continue;
                }
                else
                {
                    linearGrid[linearGridIndex] = baseData[baseDataIndex];
                    baseDataIndex++;
                }
            }

            foreach (int parityBitIndex in parityBitIndicies)
            {
                linearGrid[parityBitIndex] = GetParity(parityBitIndex);
            }

            //for (byte i = 0; i < 16; i++)
            //{
            //    if (parityBitIndicies.Contains(i))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        int row = i / 4;
            //        int col = i % 4;
            //        grid[row,col] = data.Dequeue();
            //    }
            //}

            for (int i = 0; i < linearGrid.Length; i++)
            {
                int row = i / 4;
                int col = i % 4;
               grid[row,col] = linearGrid[i];
            }

            return grid;
        }

        private int GetParity(int index)
        {
            int[] cells;
            if (index == 0)
            {
                cells = new int[]{ 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            }
            else if (index == 1)
            {
                cells = new int[] { 3,5,7,9,11,13,15};
            }
            else if (index == 2)
            {
                cells = new int[] { 3,6,7,10,11,14,15};
            }
            else if (index == 4)
            {
                cells = new int[] { 5,6,7,12,13,14,15};
            }
            else if (index == 8)
            {
                cells = new int[] { 9,10,11,12,13,14,15};
            }
            else
            {
                throw new ArgumentException("Invalid index passed to GetParity.");
            }

            return CountAllOnes(cells) % 2 == 0 ? 0 : 1;
        }

        private int CountAllOnes(int[] cellsToCount)
        {
            int onesCount = 0;
            foreach (int cell in cellsToCount)
            {
                if (linearGrid[cell] == 1) onesCount++;
            }
            return onesCount;
        }
    }
}
