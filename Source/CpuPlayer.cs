using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCardsAcesHigh
{
    class CpuPlayer : Player
    {
        private AIEngine cpuLogic;
        public CpuPlayer(int ailvl, string name) : base(name)
        {
            this.cpuLogic = new AIEngine(ailvl);
        }
        public override string CallAttributeToFight(Card cardPlayed)
        {
            return cpuLogic.SelectAtttribute(cardPlayed);
        }

        public override string CallAttributeToFight(string attrName)
        {
            return attrName;
        }
    }
}
