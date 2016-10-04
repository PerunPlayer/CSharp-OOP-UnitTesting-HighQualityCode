﻿namespace Poker
{
    using System;

    public class Card : ICard
    {
        char suit;
        string face;

        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            switch ((int)this.Face)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    face = ((int)this.Face).ToString();
                    break;
                case 11:
                    face = "J";
                    break;
                case 12:
                    face = "Q";
                    break;
                case 13:
                    face = "K";
                    break;
                case 14:
                    face = "A";
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Remember - you're playing poker, not Yu-Gi-Oh!");
            }

            switch ((int)this.Suit)
            {
                case 1:
                    suit = (char)9827;
                    break;
                case 2:
                    suit = (char)9830;
                    break;
                case 3:
                    suit = (char)9829;
                    break;
                case 4:
                    suit = (char)9824;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Remember - you're playing poker, not Yu-Gi-Oh!");
            }
            return face + suit;
        }
    }
}