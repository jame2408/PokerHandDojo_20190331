using System.Collections.Generic;
using System.Linq;

namespace PokerHandDojo_20190331
{
    public class Hand
    {
        public Hand(IEnumerable<Card> cards)
        {
            
            var cardGroup = cards.GroupBy(x => x.Rank);


            if (cardGroup.Any(x => x.Count() == 4))
            {
                HandType = HandType.FourOfAKind;
            }
            else
            {
                HandType = HandType.FullHouse;
            }
            


        }

        public HandType HandType { get ; set; }
    }

    public enum HandType
    {
        FourOfAKind,
        FullHouse
    }
}