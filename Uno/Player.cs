using System;
namespace Uno
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }


        public Player()
        {
            Name = "";
            Hand = new List<Card>();
        }

        public bool HasPlayableCard(Card card)
        {
            foreach (Card c in Hand)
            {
                if (c == card)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public Card GetFirstPlayableCard(Card card)
        {
            
            return card;
        }

        public Color MostCommonColor()
        {
            int redCount = 0;
            int yellowCount = 0;
            int blueCount = 0;
            int greenCount = 0;
            int wildCount = 0;

            foreach (Card card in Hand)
            {
                if (card.Color == Color.Red)
                {
                    redCount += 1;
                }

                if (card.Color == Color.Blue)
                {
                    blueCount += 1;
                }

                if (card.Color == Color.Green)
                {
                    greenCount += 1;
                }

                if (card.Color == Color.Yellow)
                {
                    yellowCount += 1;
                }

                if (card.Color == Color.Wild)
                {
                    wildCount += 1;
                }
            }

            if (redCount >= yellowCount && redCount >= blueCount && redCount >= greenCount && redCount >= wildCount)
            {
                return Color.Red;
            }

            else if (yellowCount >= redCount && yellowCount >= blueCount && yellowCount >= greenCount && yellowCount >= wildCount)
            {
                return Color.Yellow;
            }

            else if (blueCount >= redCount && blueCount >= yellowCount && blueCount >= greenCount && blueCount >= wildCount)
            {
                return Color.Blue;
            }

            else if (greenCount >= redCount && greenCount >= yellowCount && greenCount >= blueCount && greenCount >= wildCount)
            {
                return Color.Green;
            }

            else if (wildCount >= redCount && wildCount >= yellowCount && wildCount >= blueCount && wildCount >= greenCount)
            {
                return Color.Wild;
            }

            else
            {
                return Color.Red;
            }
        }


    }
}
