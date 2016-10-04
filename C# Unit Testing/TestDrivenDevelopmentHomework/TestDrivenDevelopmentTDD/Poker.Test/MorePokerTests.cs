namespace Poker.Test
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    using Telerik.JustMock;

    using Poker;

    [TestFixture]
    public class MorePokerTests
    {
        [Test]
        public void IsValidHand_ShouldReturnFalse_IfHandCollectionIsEmpty()
        {
            var collection = new List<ICard>();

            var hand = Mock.Create<IHand>();
            Mock.Arrange(() => hand.Cards).Returns(collection);

            var checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(6)]
        [TestCase(18)]
        public void IsValidHand_IfHandDoesntContainsExactly5Cards_ShouldReturnFalse(int numberOfCards)
        {
            var collection = new List<ICard>();

            for (int i = 0; i < numberOfCards; i++)
            {
                collection.Add(Mock.Create<ICard>());
            }

            var hand = Mock.Create<IHand>();
            Mock.Arrange(() => hand.Cards).Returns(collection);

            var checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsValidHand(hand));

        }

        [Test]
        public void IsValidHand_IfContainEqualsCards_ShouldReturnFalse()
        {
            var collection = new List<ICard>();

            var mockedCard = Mock.Create<ICard>();
            Mock.Arrange(() => mockedCard.Face).Returns(CardFace.King);
            Mock.Arrange(() => mockedCard.Suit).Returns(CardSuit.Diamonds);

            for (int i = 0; i < 5; i++)
            {
                collection.Add(mockedCard);
            }

            var hand = Mock.Create<IHand>();
            Mock.Arrange(() => hand.Cards).Returns(collection);

            var checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [Test]
        public void IsValidHand_IfContainsExactly5DiferentCards_ShouldReturnTrue()
        {
            var rng = new Random();
            var faces = Enum.GetValues(typeof(CardFace));
            var suits = Enum.GetValues(typeof(CardSuit));

            var collection = new List<ICard>();

            while (collection.Count < 5)
            {
                var mockedCard = Mock.Create<ICard>();
                Mock.Arrange(() => mockedCard.Face).Returns((CardFace)faces.GetValue(rng.Next(faces.Length)));
                Mock.Arrange(() => mockedCard.Suit).Returns((CardSuit)suits.GetValue(rng.Next(suits.Length)));

                bool IsSameCard = false;

                foreach (var c in collection)
                {
                    if (c.Face == mockedCard.Face && c.Suit == mockedCard.Suit)
                    {
                        IsSameCard = true;
                    }
                }

                if (!IsSameCard)
                {
                    collection.Add(mockedCard);
                }
            }

            var hand = Mock.Create<IHand>();
            Mock.Arrange(() => hand.Cards).Returns(collection);

            var checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsValidHand(hand));
        }

        [Test]
        [TestCase(3, 2, 3, 4, 2)]
        [TestCase(1, 4, 4, 1, 1)]
        public void IsFlush_IfHandContainDiferentSuits_ShouldReturnFalse(int suit1, int suit2, int suit3, int suit4, int suit5)
        {
            var collection = new List<ICard>();
            var suits = new List<int> { suit1, suit2, suit3, suit4, suit5 };

            foreach (var suit in suits)
            {
                var card = Mock.Create<ICard>();
                Mock.Arrange(() => card.Suit).Returns((CardSuit)suit);

                collection.Add(card);
            }

            var hand = Mock.Create<IHand>();
            Mock.Arrange(() => hand.Cards).Returns(collection);

            var checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFlush(hand));

        }

        [Test]
        [TestCase(1)]
        [TestCase(3)]
        [TestCase(2)]
        public void IsFlush_IfHandContains5CardsWithSameSuids_ShouldReturnTrue(int suit)
        {
            var collection = new List<ICard>();

            for (int i = 0; i < 5; i++)
            {
                var card = Mock.Create<ICard>();
                Mock.Arrange(() => card.Suit).Returns((CardSuit)suit);
                collection.Add(card);
            }

            var hand = Mock.Create<IHand>();
            Mock.Arrange(() => hand.Cards).Returns(collection);

            var checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsFlush(hand));
        }

        [Test]
        [TestCase(2, 2, 4, 7, 2)]
        [TestCase(2, 3, 4, 10, 2)]
        [TestCase(2, 10, 4, 2, 12)]
        public void IsFourOfKind_IfHandDoNotContain4SameFaces_ShouldReturnFalse(int face1, int face2, int face3, int face4, int face5)
        {
            var faces = new List<int> { face1, face2, face3, face4, face5 };
            var collection = new List<ICard>();

            foreach (var face in faces)
            {
                var card = Mock.Create<ICard>();
                Mock.Arrange(() => card.Face).Returns((CardFace)face);
                collection.Add(card);
            }

            var hand = Mock.Create<IHand>();
            Mock.Arrange(() => hand.Cards).Returns(collection);

            var checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }

        [Test]
        [TestCase(7, 5)]
        [TestCase(12, 11)]
        [TestCase(4, 6)]
        public void IsFourOfKind_IfHandContain4OfSameFaces_ShouldReturnTrue(int face, int otherFace)
        {
            var collection = new List<ICard>();

            for (int i = 0; i < 4; i++)
            {
                var card = Mock.Create<ICard>();
                Mock.Arrange(() => card.Face).Returns((CardFace)face);
                collection.Add(card);
            }

            var fifthCard = Mock.Create<ICard>();
            Mock.Arrange(() => fifthCard.Face).Returns((CardFace)otherFace);
            collection.Add(fifthCard);

            var hand = Mock.Create<IHand>();
            Mock.Arrange(() => hand.Cards).Returns(collection);

            var checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }
    }
}
