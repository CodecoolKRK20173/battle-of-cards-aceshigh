using System;
using System.Collections.Generic;

namespace BattleOfCardsAcesHigh.Source
{

    public class CommentField
    {
        private int _CommentWidth = 40;
        private int _CommentHeight = 13;


        public override string ToString()
        {
            string commentField = "";
            string fieldTop = "========================================";
            string fieldrow = "|                                      |";

            return commentField += fieldTop + fieldrow + fieldrow + fieldrow + fieldrow + fieldrow + fieldrow + fieldrow + fieldrow + fieldrow + fieldrow + fieldrow + fieldTop;
        }

    }
}
