using System;
using System.Collections.Generic;
using System.IO;

namespace BattleOfCardsAcesHigh
{
    public class View
    {
        

        public static void PrintTitle(string fileName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            IEnumerable<string> fileContent;

            var filesFolderName = Directory.GetParent(System.Reflection.Assembly.GetEntryAssembly().Location).Parent.Parent.Parent + "/Source/Files/";
            fileContent = File.ReadLines(filesFolderName + fileName);
            string gameTitle = "";

            foreach (string line in fileContent)
            {
                Console.WriteLine(gameTitle + line);
            }
            Console.ResetColor();
        }



    }
}