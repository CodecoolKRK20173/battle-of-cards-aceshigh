using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace BattleOfCardsAcesHigh.Source
{
    class CsvDao : IDao
    {
        private string _fileName = "statistics.csv";
        private IEnumerable<string> _fileContent;
        private string _name;
        private int _power;
        private int _speed;
        private int _intelligence;
        private string _description;

        public MainDeck CreateMainDeck(int numberOfPlayers)
        {
            var _filesFolderName = Directory.GetParent(System.Reflection.Assembly.GetEntryAssembly().Location).Parent.Parent.Parent + "/Source/Files/";
            _fileContent = File.ReadLines(_filesFolderName + _fileName);
            var cardList = new List<Card>();

            foreach(string line in _fileContent)
            {
                var splittedLine = line.Split(",");
                _name = splittedLine[0];
                _description = splittedLine[1];
                _power = Int32.Parse(splittedLine[2]);
                _speed = Int32.Parse(splittedLine[3]);
                _intelligence = Int32.Parse(splittedLine[4]);

                cardList.Add(new Card(_power, _speed, _intelligence, _name, _description));
            }


           return new MainDeck(cardList, numberOfPlayers);
        }
    }
}
