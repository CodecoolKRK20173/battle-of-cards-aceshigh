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

    }
}