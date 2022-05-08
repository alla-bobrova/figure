using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vmp_figure
{
    class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int width, int height)

            : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public override void Draw(Pen pen , Graphics graphics)
        {
            graphics.DrawRectangle(pen , X, Y, Width, Height);
        }
    }
}
