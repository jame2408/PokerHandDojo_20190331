using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PokerHandDojo_20190331
{
    [TestClass]
    public class PokerHandTest
    {
        [TestMethod]
        public void fourOfAKind_is_bigger_than_highCard()
        {
            var game = new Game();
            game.SetFirstPlayerName("James");
            game.SetSecondPlayerName("Duncan");

            game.SetFirstPlayerHand("S2,H2,C2,D2,H3");
            game.SetSecondPlayerHand("D4,S6,S7,S8,S9");

            var actual = game.Result();
            Assert.AreEqual("James Win, Four of a kind.", actual);
        }

        [TestMethod]
        public void fullHouse_is_bigger_than_highCard()
        {
            var game = new Game();
            game.SetFirstPlayerName("James");
            game.SetSecondPlayerName("Duncan");

            game.SetFirstPlayerHand("H2,D2,C2,S3,D3");
            game.SetSecondPlayerHand("D4,S6,S7,S8,S9");

            var actual = game.Result();
            Assert.AreEqual("James Win, Full House.", actual);
        }

        [TestMethod]
        public void furOfAKind_is_bigger_than_fullHouse()
        {
            var game = new Game();
            game.SetFirstPlayerName("James");
            game.SetSecondPlayerName("Duncan");

            game.SetFirstPlayerHand("S2,H2,D2,C2,S3");
            game.SetSecondPlayerHand("H2,D2,C2,S3,D3");

            var actual = game.Result();
            Assert.AreEqual("James Win, Four of a kind.", actual);
        }

        [Ignore]
        [TestMethod]
        public void fullHouse_is_bigger_than_threeOfAKind()
        {
            var game = new Game();
            game.SetFirstPlayerName("James");
            game.SetSecondPlayerName("Duncan");

            game.SetFirstPlayerHand("H2,D2,C2,S3,D3");
            game.SetSecondPlayerHand("H3,D3,C3,S4,D5");

            var actual = game.Result();
            Assert.AreEqual("James Win, Full House.", actual);
        }

        [TestMethod]
        public void can_parse_HandType_is_difference_return_fasle()

        {
            var game = new Game();
            var actul = game.IsSameHandType(HandType.FourOfAKind, HandType.FullHouse);

            Assert.IsFalse(actul);
        }
    }
}