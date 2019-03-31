using System;
using System.Linq;

namespace PokerHandDojo_20190331
{
    public class Game
    {
        private string _firstPlayerName;
        private Hand _firstPlayerHand;

        public void SetFirstPlayerName(string name)
        {
            _firstPlayerName = name;
        }

        public void SetSecondPlayerName(string name)
        {
        }

        public void SetFirstPlayerHand(string hand)
        {
            var cards = hand.Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(card => new Card(card));
            _firstPlayerHand = new Hand(cards);
        }

        public void SetSecondPlayerHand(string hand)
        {
        }

        public string Result()
        {
            return $"{_firstPlayerName} Win, Four of a kind.";
        }
    }
}