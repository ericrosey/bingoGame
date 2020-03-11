using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingoGame
{
    public class SelectedNumbersListType
    {
        bool[] selectedNums;
        

        public SelectedNumbersListType()
        {
            selectedNums = new bool[75];
        }
        public void reset()
        {
            for(int i = 0; i < selectedNums.Length; i++)
            {
                selectedNums[i] = false;
            }
        }
        public bool isNumberUsed(int rn)
        {
            if(selectedNums[rn] == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void setUsedNumber(int rn)
        {
            selectedNums[rn] = true;
        }
    }
}
