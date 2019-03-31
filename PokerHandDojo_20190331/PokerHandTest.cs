using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PokerHandDojo_20190331
{
    [TestClass]
    public class GameTest
    {
        private const string FourOfAKindCase = "S2,H2,C2,D2,H3";
        private const string HighCardCase = "D4,S6,S7,S8,S9";
        private const string FullHouseCase = "H2,D2,C2,S3,D3";
        private Game _game = new Game();

        [TestMethod]
        public void fourOfAKind_is_bigger_than_highCard()
        {
            GivenPlayerNames("James", "Duncan");
            GivenPlayerHands(FourOfAKindCase, HighCardCase);

            ResultShouldBe("James Win, Four of a kind.");
        }

        [TestMethod]
        public void fullHouse_is_bigger_than_highCard()
        {
            GivenPlayerNames("James", "Duncan");
            GivenPlayerHands(FullHouseCase, HighCardCase);
            
            ResultShouldBe("James Win, Full House.");
        }

        private void ResultShouldBe(string expected)
        {
            Assert.AreEqual(expected, _game.Result());
        }

        private void GivenPlayerHands(string firstPlayerHand, string secondPlayerHand)
        {
            _game.SetFirstPlayerHand(firstPlayerHand);
            _game.SetSecondPlayerHand(secondPlayerHand);
        }

        private void GivenPlayerNames(string firstPlayerName, string secondPlayerName)
        {
            _game.SetFirstPlayerName(firstPlayerName);
            _game.SetSecondPlayerName(secondPlayerName);
        }

        [TestMethod]
        public void fourOfAKind_is_bigger_than_fullHouse()
        {
            GivenPlayerNames("James", "Duncan");
            GivenPlayerHands(FourOfAKindCase, FullHouseCase);
            ResultShouldBe("James Win, Four of a kind.");
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
    }
}