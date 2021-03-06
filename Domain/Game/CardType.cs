using System;
namespace Domain.Game
{
    public class CardType : Enumeration
    {
        public static CardType DevelopmentCard = new CardType(1, nameof(DevelopmentCard));
        public static CardType ResourceCard = new CardType(2, nameof(ResourceCard));

        public CardType(int id, string name) : base(id, name)
        {
        }
    }
}
