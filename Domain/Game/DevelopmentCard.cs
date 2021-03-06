using System;
using System.Collections.Generic;

namespace Domain.Game
{
    public class DevelopmentCard : Enumeration
    {
        private static DevelopmentCard VictoryPoint = new DevelopmentCard(1, nameof(VictoryPoint));
        private static DevelopmentCard RoadingBuilding = new DevelopmentCard(2, nameof(RoadingBuilding));
        private static DevelopmentCard Monopoly = new DevelopmentCard(3, nameof(Monopoly));
        private static DevelopmentCard YearOfPlenty = new DevelopmentCard(4, nameof(YearOfPlenty));
        private static DevelopmentCard Knight = new DevelopmentCard(5, nameof(Knight));

        public DevelopmentCard(int id, string name) : base(id, name)
        {
        }
        // basic game has 25 development cards
        public static Dictionary<DevelopmentCard, int> BasicGameDevelopmentCardCount => new Dictionary<DevelopmentCard, int> {
            { VictoryPoint, 5},
            {RoadingBuilding, 2 },
            {Monopoly, 2 },
            {YearOfPlenty, 2 },
            {Knight, 14 },
        };
    }
}
