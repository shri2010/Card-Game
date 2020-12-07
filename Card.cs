namespace CardGame
{
    public class Card
    {
        public int ID { get; set; }

        public SuitEnum Suit { get; set; }

        public CardNumberEnum Number { get; set; }

        public Card(SuitEnum suit, CardNumberEnum number, int id)
        {
            this.Suit = suit;
            this.Number = number;
            this.ID = id;
        }
    }
}
