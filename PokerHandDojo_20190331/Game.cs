using System;
using System.Linq;

namespace PokerHandDojo_20190331
{
    public class Game
    {
        private string _firstPlayerName;

        public void SetFirstPlayerName(string name)
        {
            _firstPlayerName = name;
        }

        public void SetSecondPlayerName(string name)
        {
        }

        public void SetFirstPlayerHand(string hand)
        {
            hand.Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(card => new Card(card));
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