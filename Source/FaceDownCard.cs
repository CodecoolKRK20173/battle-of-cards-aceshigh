using System;
using System.Collections.Generic;
namespace BattleOfCardsAcesHigh

{
    public struct FaceDownCard

    {
        public string PrintDeck(Player player, List<Player> allPlayers)
        {
            string cardFaceDown = "";
            string symbol = "";
            int playerIndex = allPlayers.IndexOf(player);

            if (playerIndex == 0)
            {
                symbol += "------>";
            }
            else if (playerIndex == 1)
            {
                symbol += "<------";
            }
            else if (playerIndex == 2)
            {
                symbol += "∧______";
            }
            else if (playerIndex == 3)
            {
                symbol += "‾‾‾‾‾‾∨";
            }

            string cardTopBottom = "+--------------------+";
            string cardRow = "|▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒|";
            string cardSymbol = "|▒▒" + symbol.PadRight(symbol.Length) + "▒▒▒▒▒▒▒▒▒▒▒|";
            string name = "|▒▒Player:▒▒▒▒▒▒▒▒▒▒▒|";
            string cardsLeft = "|▒▒Cards left: ▒▒▒▒▒▒|";
            string playerName = "|▒▒" + player.GetPlayerName().PadRight(22 - player.GetPlayerName().Length) + "▒|";
            string cardsCount = "|▒▒" + player.GetPlayerHand().Count().ToString().PadRight(2) + "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒|";

            return cardFaceDown += cardTopBottom + cardRow + cardRow + cardSymbol + cardRow + name + playerName + cardRow + cardsLeft + cardsCount + cardRow + cardRow + cardTopBottom;
        }
    }
}


