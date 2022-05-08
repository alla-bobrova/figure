using System.Drawing;

namespace vmp_figure
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract void Draw(Pen pen , Graphics graphics);
    }
}
