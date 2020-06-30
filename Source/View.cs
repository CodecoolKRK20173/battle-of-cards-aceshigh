using System;
using System.Collections.Generic;
using System.IO;

namespace BattleOfCardsAcesHigh
{
    public class View
    {
        public static void PrintTitle()
        {
            using (StreamReader stream = File.OpenText(@"\Files\title.txt"))
            {
                String gameTitle = "";

                while ((gameTitle = stream.ReadLine()) != null)
                {
                    Console.WriteLine(gameTitle);
                }
            }
        }

        public static void PrintCardFaceDown()
        {
            int cardWidth = 19;
            int cardHeight = 12;

        }

        public static void PrintCommentField()
        {

        }
    }
}