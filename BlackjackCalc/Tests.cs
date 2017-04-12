using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BlackjackCalc
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TenAndFour_Fourteen()
        {
            var cards = new List<Card>
            {
                new Card { Value = "10", Suit = Suit.Hearts },
                new Card { Value = "4", Suit = Suit.Spades }
            };

            var result = CardCalculator.Calc(cards);

            Assert.AreEqual(result, 14);
        }

        [TestMethod]
        public void ThreeAndFaceCard_Thirteen()
        {
            var cards = new List<Card>
            {
                new Card { Value = "Q", Suit = Suit.Hearts },
                new Card { Value = "3", Suit = Suit.Hearts }
            };

            var result = CardCalculator.Calc(cards);

            Assert.AreEqual(result, 13);
        }



        [TestMethod]
        public void TenFourAndFive_Nineteen()
        {
            var cards = new List<Card>
            {
                new Card { Suit = Suit.Hearts, Value = "10" },
                new Card { Suit = Suit.Clubs, Value = "4" },
                new Card { Suit = Suit.Diamonds, Value = "5" }
            };

            var result = CardCalculator.Calc(cards);

            Assert.AreEqual(result, 19);
        }

        [TestMethod]
        public void AceAndJack_TwentyOne()
        {
            var cards = new List<Card>
            {
                new Card { Suit = Suit.Hearts, Value = "A" },
                new Card { Suit = Suit.Diamonds, Value = "J" },
            };

            var result = CardCalculator.Calc(cards);

            Assert.AreEqual(result, 21);
        }

        [TestMethod]
        public void AceJackAndSix_TwentyOne()
        {
            var cards = new List<Card>
            {
                new Card { Suit = Suit.Hearts, Value = "A" },
                new Card { Suit = Suit.Diamonds, Value = "J" },
                new Card { Suit = Suit.Clubs, Value = "6" }
            };

            var result = CardCalculator.Calc(cards);

            Assert.AreEqual(result, 17);
        }

        [TestMethod]
        public void TwoAcesAndATwo_Fourteen()
        {
            var cards = new List<Card>
            {
                new Card { Suit = Suit.Hearts, Value = "A" },
                new Card { Suit = Suit.Diamonds, Value = "A" },
                new Card { Suit = Suit.Clubs, Value = "2" }
            };

            var result = CardCalculator.Calc(cards);

            Assert.AreEqual(result, 14);
        }
    }
}
