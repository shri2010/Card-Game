using System;
using System.Linq;

namespace CardGame
{
    /// <summary>
    /// 
    /// </summary>
    public class CardDeck : ElementsCollection<Card>
    {
        public CardDeck()
        {

        }

        /// <summary>
        /// Adding All cards to the deck
        /// </summary>
        public void Initialize()
        {
            if (elements.Any())
            {
                elements.Clear();
            }
            foreach (SuitEnum suit in Enum.GetValues(typeof (SuitEnum)))
            {
                foreach (CardNumberEnum cardNumber in Enum.GetValues(typeof(CardNumberEnum)))
                {
                    AddElement(new Card(suit, cardNumber, new Random().Next()));
                }
            }
        }

        /// <summary>
        /// Get card from card deck
        /// </summary>
        /// <returns></returns>
        public Card GetCard()
        {
            if (elements.Any())
            {
                var element = elements.First();
                RemoveElement(element);
                return element;
            }
            else
            {
                throw new InvalidOperationException("Empty Card Deck");
            }
        }

        /// <summary>
        /// Shuffle the deck based on random id of each card
        /// </summary>
        public void ShuffleDeck()
        {

          var shuffledCards = elements.OrderBy(x => x.ID).ToList();

          elements = shuffledCards;

        }

        
    }
}
