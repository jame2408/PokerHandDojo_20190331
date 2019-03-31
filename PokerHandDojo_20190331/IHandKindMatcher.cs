using System.Collections.Generic;

namespace PokerHandDojo_20190331
{
    public interface IHandKindMatcher
    {
        bool Match(IEnumerable<Card> cards);
        HandType HandType { get; }
    }
}