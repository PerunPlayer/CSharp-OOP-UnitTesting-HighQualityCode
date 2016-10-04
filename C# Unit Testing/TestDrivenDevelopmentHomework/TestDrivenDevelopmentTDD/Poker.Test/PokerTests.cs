namespace Poker.Test
{
    using NUnit.Framework;
    using Poker;
    using System;
    using System.Collections.Generic;
    [TestFixture]
    public class PokerTests
    {
        [Test]
        [TestCase(CardSuit.Spades, CardFace.Ace, "A♠")]
        [TestCase(CardSuit.Hearts, CardFace.King, "K♥")]
        [TestCase(CardSuit.Diamonds, CardFace.Queen, "Q♦")]
        [TestCase(CardSuit.Clubs, CardFace.Nine, "9♣")]

        public void CardToString_ShouldWorkProperly(CardSuit suit, CardFace face, string expected)
        {
            var card = new Card(face, suit);

            Assert.AreEqual(expected, card.ToString());
        }

        [Test]
        public void HandToString_EmptyCollection_ShouldReturnStringEmpty()
        {
            var collection = new List<ICard>();

            var hand = new Hand(collection);

            Assert.AreEqual(string.Empty, hand.ToString());
        }

        [Test]
        [TestCase(8)]
        [TestCase(15)]
        [TestCase(11)]
        public void HandToString_ShouldReturnProperlySingleCardCollection(int numberOfCardsCheck)
        {
            var rng = new Random();
            var faces = Enum.GetValues(typeof(CardFace));
            var suits = Enum.GetValues(typeof(CardSuit));

            for (int i = 0; i < numberOfCardsCheck; i++)
            {
                var card = new Card((CardFace)faces.GetValue(rng.Next(faces.Length)),
                                        (CardSuit)suits.GetValue(rng.Next(suits.Length)));

                var collectiomn = new List<ICard> { card };
                var hand = new Hand(collectiomn);

                if (!card.ToString().Equals(hand.ToString()))
                {
                    Assert.Fail("Card hand don't display collection of single card!");
                }
            }
        }

        [Test]
        [TestCase(4)]
        [TestCase(10)]
        public void HandToString_ShouldReturnProperlyMoreThenOneCardCollection(int numberOfCards)
        {
            var rng = new Random();
            var faces = Enum.GetValues(typeof(CardFace));
            var suits = Enum.GetValues(typeof(CardSuit));

            string expectedResult = string.Empty;
            var collection = new List<ICard>();

            for (int i = 0; i < numberOfCards; i++)
            {
                var card = new Card((CardFace)faces.GetValue(rng.Next(faces.Length)),
                                        (CardSuit)suits.GetValue(rng.Next(suits.Length)));
                collection.Add(card);
                expectedResult += card.ToString() + ' ';
            }

            var hand = new Hand(collection);

            Assert.AreEqual(expectedResult.Trim(), hand.ToString());
        }
    }
}
