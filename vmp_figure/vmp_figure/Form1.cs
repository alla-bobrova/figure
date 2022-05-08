using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace vmp_figure
{
    public partial class Form1 : Form
    {
        List<Shape> shapes = new List<Shape>();

        public Form1()
        {
            InitializeComponent();
        }

        private void shapeTypeComboBox_SelectedIndexChanged(object sender , EventArgs e)
        {
            string type = shapeTypeComboBox.Text;

            switch ( type )
            {
                case "Окружность":
                    radiusNumericUpDown.Enabled = true;
                    widthNumericUpDown.Enabled = false;
                    heightNumericUpDown.Enabled = false;
                    break;
                case "Прямоугольник":
                    radiusNumericUpDown.Enabled = false;
                    widthNumericUpDown.Enabled = true;
                    heightNumericUpDown.Enabled = true;
                    break;
                default:
                    radiusNumericUpDown.Enabled = false;
                    widthNumericUpDown.Enabled = false;
                    heightNumericUpDown.Enabled = false;
                    break;
            }
        }

        private void addShapeButton_Click(object sender , EventArgs e)
        {
            string type = shapeTypeComboBox.Text;

            switch ( type )
            {
                case "Окружность":
                    AddCircle();
                    break;
                case "Прямоугольник":
                    AddRectangle();
                    break;
            }
        }

        private void AddCircle()
        {
            int x = ( int ) xNumericUpDown.Value;
            int y = ( int ) yNumericUpDown.Value;
            int radius = ( int ) radiusNumericUpDown.Value;

            Circle circle = new Circle(x , y , radius);
            shapes.Add(circle);
        }

        private void AddRectangle()
        {
            int x = ( int ) xNumericUpDown.Value;
            int y = ( int ) yNumericUpDown.Value;
            int width = ( int ) widthNumericUpDown.Value;
            int height = ( int ) heightNumericUpDown.Value;

            Rectangle rectangle = new Rectangle(x , y , width , height);
            shapes.Add(rectangle);
        }

        private void drawCirclesButton_Click(object sender , EventArgs e)
        {
            List<Shape> circles = new List<Shape>();

            foreach ( var shape in shapes )
            {
                if ( shape is Circle )
                {
                    circles.Add(shape);
                }
            }

            DrawShapes drawShapes = new DrawShapes(circles);
            drawShapes.Show();
        }

        private void drawAllShapesButton_Click(object sender , EventArgs e)
        {
            DrawShapes drawShapes = new DrawShapes(shapes);
            drawShapes.Show();
        }
    }
}
