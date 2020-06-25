using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCardsAcesHigh
{
    class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
        }
        public override string CallAttributeToFight(string attrName)
        {
            throw new NotImplementedException();
        }
    }
}
