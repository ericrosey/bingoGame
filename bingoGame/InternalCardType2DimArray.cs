using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingoGame
{
    public class InternalCardType2DimArray
    {
        int[] rowCount;
        int[] columnCount;
        int frwDiag;
        int brwDiag;
        public InternalCardType2DimArray(int BINGOCARDSIZE)
        {
            rowCount = new int[BINGOCARDSIZE];
            columnCount = new int[BINGOCARDSIZE];
            frwDiag = 1;
            brwDiag = 1;
            rowCount[2] = 1;
            columnCount[2] = 1;
        }
        public bool checkBingo(int r, int c)
        {
            rowCount[r]++;
            columnCount[c]++;

            if (r == c)
            {
                brwDiag++;
            }
            if (r + c == 4)
            {
                frwDiag++;
            }

            bool hasBingo = false;
            for (int i = 0; i < 5; i++)
            {
                if(rowCount[i] == 5 || columnCount[i] == 5)
                {
                    hasBingo = true;
                }
            }
            if(frwDiag == 5 || brwDiag == 5)
            {
                hasBingo = true;
            }
            return hasBingo;
        }

    }
}
