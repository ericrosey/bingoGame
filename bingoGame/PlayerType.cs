using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingoGame
{
    class PlayerType
    {
        private string playerName;
        public PlayerType(string theName)
        {
            playerName = theName;
        }
        public string getName()
        {
            return this.playerName;
        }
    }
}
