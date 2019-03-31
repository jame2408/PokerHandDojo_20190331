using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PokerHandDojo_20190331
{
    [TestClass]
    public class HandTypeComparerTest
    {
        [TestMethod]
        public void fourOfAKind_of_a_kind_is_bigger_than_fullHouse()
        {
            var result = new HandTypeComparer().Compare(HandType.FullHouse, HandType.FourOfAKind);
            Assert.IsTrue(result < 0);
        }

        [TestMethod]
        public void handType_is_compared_equally_with_self()
        {
            var handTypeComparer = new HandTypeComparer();
            var result = handTypeComparer.Compare(HandType.FullHouse, HandType.FullHouse);
            Assert.IsTrue(result == 0);
        }
    }
}