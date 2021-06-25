using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BalloonWithProperties
{
    public class Balloon
    {
        private int _x = 50;
        private int _y = 50;
        private int _diameter = 20;
        private string _name = "";
        private Brush _colour = new SolidColorBrush(Colors.Black);
        private Ellipse _ellipse;

        public int x
        {
            get { return _x; }
            set { _x = value;
                  UpdateEllipse(); }
        }
        public int y
        {
            get { return _y; }
            set { _y = value;
                  UpdateEllipse(); }
        }
        public int diameter
        {
            get { return _diameter; }
        }

        public string name
        {
            get { return _name;  }
            set { _name = value;  }
        }

        public Brush colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        public Balloon()
        {
            CreateEllipse();
            UpdateEllipse();
        }
        public Balloon(int XCoord, int YCoord)
        {
            CreateEllipse();
            x = XCoord;
            y = YCoord;
            UpdateEllipse();
        }

        public Balloon(int XCoord)
        {
            CreateEllipse();
            x = XCoord;

            UpdateEllipse();
        }
        public void MoveRight(int xStep)
        {
            _x = _x + xStep;
            UpdateEllipse();
        }
        public void moveDown(int yStep)
        {
            _y = _y + yStep;
            UpdateEllipse();
        }
        public void MoveLeft(int xStep)
        {
            _x = _x - xStep;
            UpdateEllipse();
        }
        public void ChangeSize(int change)
        {
            _diameter = _diameter + change;
            UpdateEllipse();
        }
        public void moveUp(int yStep)
        {
            _y = _y - yStep;
            UpdateEllipse();
        }
        public void DisplayOn(Canvas drawingCanvas)
        {
            drawingCanvas.Children.Add(_ellipse);
        }
        private void CreateEllipse()
        {
            _ellipse = new Ellipse()
            {
                Stroke = _colour,
                StrokeThickness = 2
            };
        }
        private void UpdateEllipse()
        {
            _ellipse.Margin = new Thickness(_x, _y, 0, 0);
            _ellipse.Width = _diameter;
            _ellipse.Height = _diameter;
        }

        public void Save(Balloon balloon)
        {
            MessageBox.Show("De x=" + balloon.x.ToString() + ", y=" + balloon.y.ToString() + ", en de diameter=" + balloon.diameter.ToString() + " van de ballon zijn opgeslagen");
        }
    }
}
