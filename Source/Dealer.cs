﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCardsAcesHigh.Source
{
    class Dealer
    {
        private Deck _mainDeck;
        private Deck _playerHand;

        public Dealer(int numberOfPlayers)
        {
            this._mainDeck = CreateMainDeck();
            this._mainDeck.Shuffle();
            this._mainDeck.SplitCards(numberOfPlayers);
        }

        private Deck CreateMainDeck()
        {
            return DeckDao.CreateMainDeck();
        }

        public void DealCards(List<Player> players)
        {
            foreach (Player player in players)
            {
                _playerHand = _mainDeck[0];
                _mainDeck.RemoveAt(0);
                player.AddCardsToHand(_playerHand);
            }

        }

    }
}