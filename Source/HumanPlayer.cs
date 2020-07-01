using Microsoft.VisualBasic;
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
            return attrName;
        }

        public override string CallAttributeToFight(Card playedCard)
        {
            return null;
        }
    }
}
