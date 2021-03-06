using System;
namespace Domain.Game
{
    public class ResourceCard : Enumeration
    {
        private static readonly ResourceCard Wood = new (1, nameof(Wood));
        private static readonly ResourceCard Brick = new (1, nameof(Brick));
        private static readonly ResourceCard Sheep = new (1, nameof(Sheep));
        private static readonly ResourceCard Wheat = new (1, nameof(Wheat));
        private static readonly ResourceCard Ore = new (1, nameof(Ore));

        public ResourceCard(int id, string name) : base(id, name)
        {
        }
    }
}
