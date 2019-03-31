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
Assert.AreEqual(card.Rank,3);
        }
    }
}