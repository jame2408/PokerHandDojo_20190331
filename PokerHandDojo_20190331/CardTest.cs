using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PokerHandDojo_20190331
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void can_parse_rank()
        {
            var card = new Card("S3");
            Assert.AreEqual(card.Rank, 3);
        }

        [TestMethod]
        public void can_parse_suit_spade()
        {
            var card = new Card("S3");
            Assert.AreEqual(card.Suit, SuitType.Spade);
        }

        [TestMethod]
        public void can_parse_suit_heart()
        {
            var card = new Card("H3");
            Assert.AreEqual(card.Suit, SuitType.Heart);
        }

        [TestMethod]
        public void can_parse_suit_Diamond()
        {
            var card = new Card("D3");
            Assert.AreEqual(card.Suit, SuitType.Diamond);
        }

        [TestMethod]
        public void can_parse_suit_Club()
        {
            var card = new Card("C3");
            Assert.AreEqual(card.Suit, SuitType.Club);
        }

        //[TestMethod]
        //public void can_parse_rank_J()
        //{
        //    var card = new Card("CJ");
        //    Assert.AreEqual(card.Rank, 11);
        //}
    }

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