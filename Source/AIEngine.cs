using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BattleOfCardsAcesHigh
{
    class AIEngine
    {
        private int aiLevel;
        public AIEngine(int level)
        {
            this.aiLevel = level;
        }
        // This code checks played Card's stats and chooses the best attribute
        public string SelectAtttribute(Card playedCard)
        {
            throw new NotImplementedException();
        }
    }
}
