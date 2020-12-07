using System;

namespace CardGame
{
    /// <summary>
    /// This class will acts as a starting point for game
    /// </summary>
    public class CardGame
    {
        private static CardDeck cardDeck;

        static void Main(string[] args)
        {
            Console.WriteLine("Card Game!");
            try
            {
                cardDeck = new CardDeck();
                cardDeck.Initialize();
                PlayGame();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        /// <summary>
        /// This will rerun till exit is clicked.
        /// </summary>
        private static void PlayGame()
        {
            Console.WriteLine("1. Play Card (Press 1)");
            Console.WriteLine("2. Shuffle Cards (Press 2)");
            Console.WriteLine("3. Exit (Press 3)");
            Console.WriteLine("4. Restart (Press 4)");

            var input = Console.ReadLine();

            if (Enum.TryParse(input, out GameOptionEnum option))
            {
                PeformAction(option);
            }
            else
            {
                Console.WriteLine("Please enter valid input");
            }
        }


        private static void PeformAction(GameOptionEnum option)
        {
            
            switch (option)
            {
                case GameOptionEnum.PlayCard:
                    PlayCard();
                    PlayGame();
                    break;
                case GameOptionEnum.Restart:
                    Restart();
                    PlayGame();
                    break;
                case GameOptionEnum.Shuffle:
                    Shuffle();
                    PlayGame();
                    break;
                case GameOptionEnum.Exit:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// This will shuffle the decks
        /// </summary>
        private static void Shuffle()
        {
            cardDeck.ShuffleDeck();
        }

        /// <summary>
        /// this will re initialize the deck
        /// </summary>
        private static void Restart()
        {
            cardDeck.Initialize();
        }


        /// <summary>
        /// this will play the card.
        /// </summary>
        private static void PlayCard()
        {
            var card = cardDeck.GetCard();
            Console.WriteLine($"Card {card.Suit} {card.Number}");
                
        }
    }
}
