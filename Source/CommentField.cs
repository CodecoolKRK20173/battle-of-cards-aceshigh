using System;
using System.Collections.Generic;

namespace BattleOfCardsAcesHigh.Source
{

    public class CommentField
    {
        private int _CommentWidth = 40;
        private int _CommentHeight = 13;
        private List<string> _comments;

        public CommentField()
        {
            this._comments = new List<string>();
        }

        public void SetComment(string comment)
        {
            _comments.Add(comment);
        }

        public void ResetComments()
        {
            _comments = new List<string>();
        }
        public override string ToString()
        {
            string commentField = "";
            commentField += "========================================";
            commentField += "|                                      |";
            for (int i = 0; i < 10; i++)
            {
                if (_comments.Count <= i)
                {
                    commentField += "|                                      |";
                }
                else
                {
                    commentField += "| " + _comments[i].PadRight(36) + " |";
                }
            }

            commentField += "========================================";

            return commentField;
        }

    }
}
