using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PokerHandDojo_20190331
{
    [TestClass]
    public class HandTypeComparerTest
    {
        [TestMethod]
        public void four_of_a_kind_is_bigger_than_fullhouse()
        {
            var result = new HandTypeComparer().Compare(HandType.FullHouse, HandType.FourOfAKind);
            Assert.IsTrue(result < 0);
        }
    }
}