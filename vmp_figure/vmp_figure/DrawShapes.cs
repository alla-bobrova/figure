using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace vmp_figure
{
    public partial class DrawShapes : Form
    {
        Random random = new Random();
        List<Shape> shapes;
        public DrawShapes(List<Shape> shps)
        {
            InitializeComponent();
            shapes = shps;
        }

        private void DrawShapes_Paint(object sender , PaintEventArgs e)
        {
            foreach ( var shape in shapes )
            {
                Pen pen = RandomPen();

                shape.Draw(pen , e.Graphics);
            }
        }

        private Pen RandomPen()
        {
            Pen[] pens = new Pen[]
            {
                Pens.Black,
                Pens.Red,
                Pens.Green,
                Pens.Blue,
                Pens.Yellow,
                Pens.Gray,
                Pens.Aquamarine,
                Pens.Chocolate
            };
            int index = random.Next(pens.Length);

            return pens[index];
        }
    }
}
