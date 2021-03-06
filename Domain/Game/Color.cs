namespace Domain.Game
{
    public class ColorType : Enumeration
    {
        public static ColorType Red = new ColorType(1, nameof(Red));
        public static ColorType Blue = new ColorType(2, nameof(Blue));
        public static ColorType Orange = new ColorType(3, nameof(Orange));
        public static ColorType Brown = new ColorType(4, nameof(Brown));
        public static ColorType Green = new ColorType(5, nameof(Green));
        public static ColorType White = new ColorType(6, nameof(White));

        public ColorType(int id, string name)
          : base(id, name)
        {
        }

    }
}