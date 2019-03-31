using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PokerHandDojo_20190331
{
    [TestClass]
    public class HandTest
    {
        [TestMethod]
        public void can_parse_fourOfAKind()
        {
            var cards = new List<Card>
            {
                new Card("S3"),
                new Card("D3"),
                new Card("H3"),
                new Card("C3"),
                new Card("S2"),
            };
            var hand = new Hand(cards);
            Assert.AreEqual(HandType.FourOfAKind, hand.HandType);
        }

        [TestMethod]
        public void can_parse_fullHouse()
        {
            var cards = new List<Card>
            {
                new Card("S3"),
                new Card("D3"),
                new Card("H3"),
                new Card("C2"),
                new Card("S2"),
            };
            var hand = new Hand(cards);
            Assert.AreEqual(HandType.FullHouse, hand.HandType);
        }
    }
}