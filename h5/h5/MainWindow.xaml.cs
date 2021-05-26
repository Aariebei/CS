using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace h5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            startBtn.Click += StartBtn_Click;
        }

        private void ShowName(string name)
        {
            MessageBox.Show($"Naam: {name}");
        }

        private void ShowNames(string firstName, string lastName)
        {
            MessageBox.Show($"Volledige naam: {firstName} {lastName}");
        }

        private void ShowSalary(int salaryPerYear, int years)
        {
            MessageBox.Show($"Eindsalaris: € {(salaryPerYear * years).ToString("0.00")}");
        }
        
        private void DrawCircle(Canvas drawArea, SolidColorBrush brush, double xCentre, double yCentre, double radius)
        {
            Ellipse theCircle = new Ellipse();
            theCircle.Stroke = brush;
            theCircle.Margin = new Thickness(xCentre, yCentre, 0, 0);
            theCircle.Width = radius;
            theCircle.Height = radius;
            drawArea.Children.Add(theCircle);
        }

        private void DrawTriangle2(Canvas drawingArea,
                                   SolidColorBrush brushToUse,
                                   double topX,
                                   double topY,
                                   double width,
                                   double height)
        {
            double rightCornerX, rightCornerY;
            rightCornerX = topX + width;
            rightCornerY = topY + height;

            Polygon Triangle = new Polygon();
            Triangle.Stroke = new SolidColorBrush(Colors.Black);
            Triangle.StrokeThickness = 1;
            Point Point1 = new Point(topX, topY);
            Point Point2 = new Point(rightCornerX, rightCornerY);
            Point Point3 = new Point(topX, rightCornerY);
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            Triangle.Points = myPointCollection;
            drawingArea.Children.Add(Triangle);
        }

        private void DrawRectangle(Canvas drawingArea,
                                   SolidColorBrush brushToUse,
                                   double topLeftX,
                                   double topLeftY,
                                   double width,
                                   double height)
        {
            Rectangle theRectangle = new Rectangle();
            theRectangle.Width = width;
            theRectangle.Height = height;
            theRectangle.Margin = new Thickness(topLeftX, topLeftY, 0, 0);
            theRectangle.Stroke = brushToUse;
            drawingArea.Children.Add(theRectangle);
        }

        private void DrawHouse(Canvas drawingArea,
                               SolidColorBrush brushToUse,
                               double topRoofX,
                               double topRoofY,
                               double width,
                               double height)
        {
            DrawTriangle2(drawingArea, brushToUse, topRoofX,
                         topRoofY, width, height);
            DrawRectangle(drawingArea, brushToUse, topRoofX,
                          topRoofY + height, width, height);
        }

        public void DrawStreet(Canvas drawingArea, SolidColorBrush brushToUse, int startStreetX, int startStreetY, int width, int height)
        {
            DrawHouse(drawingArea, brushToUse, startStreetX, startStreetY, width, height);
            DrawHouse(drawingArea, brushToUse, startStreetX + width + 20, startStreetY, width, height);
            DrawHouse(drawingArea, brushToUse, startStreetX + width + 20 + width + 20, startStreetY, width, height);
            DrawHouse(drawingArea, brushToUse, startStreetX + width + 20 + width + 20 + width + 20, startStreetY, width, height); ;
        }

        public void DrawStreetInPerspective(Canvas drawingArea, SolidColorBrush brushToUse, int startStreetX, int startStreetY, int width, int height)
        {
            DrawHouse(drawingArea, brushToUse, startStreetX, startStreetY, width, height);
            DrawHouse(drawingArea, brushToUse, startStreetX + width + 20, startStreetY, width * 0.8, height * 0.8);
            DrawHouse(drawingArea, brushToUse, startStreetX + width + 20 + width * 0.8 + 20, startStreetY, width * 0.8 * 0.8, height * 0.8 * 0.8);
            DrawHouse(drawingArea, brushToUse, startStreetX + width + 20 + width * 0.8 + 20 + width * 0.8 * 0.8 + 20, startStreetY, width * 0.8 * 0.8 * 0.8, height * 0.8 * 0.8 * 0.8);
        }

        public double CalculateEuroEquivalent(double dollars)
        {
            return dollars * 0.82;
        }

        public double CalculateCubeVolume(double lengthInCm)
        {
            return Math.Pow(lengthInCm, 3);
        }

        public double CalculateCircleArea(double radius)
        {
           return Math.PI * Math.Pow(radius, 2);
        }

        public double CalculateCilinderArea(double radius)
        {
            return CalculateCircleArea(radius) * 2 + (2 * Math.PI * radius);
        }

        public int GetTimeInSeconds(int hours, int minutes, int seconds)
        {
            return hours * 3600 + minutes * 60 + seconds;
        }

        public int Increment(int n)
        {
            return n + 1;
        }

        public string ConvertNumberToBinary(int n)
        {
            return Convert.ToString(n, 2);
        }

        public string ConvertSecondsToHoursMinutesSeconds(int seconds)
        {
            int hours = seconds / 3600;
            int minutes = seconds / 60 - (hours * 60);
            int seconds2 = seconds - (minutes * 60) - (hours * 3600);
            return $"{hours} : {minutes} : {seconds2}";
        }

        public string GetInput3(out int a, out int b, out int c)
        {
            a = 0;
            b = 0;
            c = 0;
            return $"{a} {b} {c}";
        }
        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
/*            ShowName(nameTxb.Text);
            ShowNames(firstNameTxb.Text, lastNameTxb.Text);
            ShowSalary(Convert.ToInt32(yearSalaryTxb.Text), Convert.ToInt32(yearsTxb.Text));*/

            SolidColorBrush brush = new SolidColorBrush(Colors.Black);
            DrawCircle(o4Cvs, brush, 45, 45, 30);

            DrawTriangle2(o5Cvs, brush, 0, 0, 50, 50);

            DrawStreet(o6Cvs, brush, 0, 0, 10, 10);

            DrawStreetInPerspective(o7Cvs, brush, 0, 0, 10, 10);

            double o8 = CalculateEuroEquivalent(37.50);

            double o9 = CalculateCubeVolume(1.2);

            double o10 = CalculateCircleArea(1.25);

            double o11 = GetTimeInSeconds(1, 1, 2);

            double o12 = CalculateCilinderArea(1.25);

            double o13 = Increment(3);

            string o14 = ConvertNumberToBinary(12);

            string o15 = ConvertSecondsToHoursMinutesSeconds(3662);

            int a = 0;
            int b = 0;
            int c = 0;

            GetInput3(out a, out b, out c);


        }
    }
}
