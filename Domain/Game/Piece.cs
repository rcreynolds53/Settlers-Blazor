using System.Collections.Generic;

namespace Domain.Game
{
    public class Piece : Enumeration
    {
        public static Piece City = new(1, nameof(City));
        public static Piece Settlement = new(2, nameof(Settlement));
        public static Piece Road = new(3, nameof(Road));
        public static Piece Robber = new(4, nameof(Robber)) ;


        public Piece(int id, string name) : base(id, name)
        {
        }

        public static IEnumerable<Piece> GamePieces => new[] { City, Settlement, Road, Robber };

        public static Dictionary<Piece, int> InitialCounts => new Dictionary<Piece, int> {
            {City, 4 },
            {Settlement,5 },
            {Road, 15 },
            {Robber, 0 }
        };

    }
}