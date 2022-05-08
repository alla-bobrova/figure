using System.Drawing;

namespace vmp_figure
{
    class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(int x, int y, int radius)
            : base(x, y)
        {
            Radius = radius;
        }

        public override void Draw(Pen pen , Graphics graphics)
        {
            graphics.DrawEllipse(pen , X , Y , Radius * 2 , Radius * 2);
        }
    }
}
