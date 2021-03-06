using System.Collections.Generic;
using System.Linq;

namespace Domain.Game
{
    public class Player
    {
        public string Username { get; set; }
        public Color Color { get; set; }
        public List<Piece> Pieces { get; set; }

        public void SetPieces()
        {
            foreach(var piece in Piece.GamePieces)
            {
                var piecesToAdd = Enumerable.Repeat(piece, Piece.InitialCounts[piece]);
                Pieces.AddRange(piecesToAdd);
            }
        }
    }
}