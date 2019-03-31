using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}