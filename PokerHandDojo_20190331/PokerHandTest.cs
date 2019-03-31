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
    }

    public class Game
    {
        public void SetFirstPlayerName(string name)
        {
        }

        public void SetSecondPlayerName(string name)
        {
        }

        public void SetFirstPlayerHand(string hand)
        {
        }

        public void SetSecondPlayerHand(string hand)
        {
        }

        public string Result()
        {
            return "James Win, Four of a kind.";
        }
    }
}