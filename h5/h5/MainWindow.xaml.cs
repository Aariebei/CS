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
            MessageBox.Show($"Opdracht 1 - Naam: {name}");
        }

        private void ShowNames(string firstName, string lastName)
        {
            MessageBox.Show($"Opdracht 2 - Volledige naam: {firstName} {lastName}");
        }

        private void ShowSalary(int salaryPerYear, int years)
        {
            MessageBox.Show($"Opdracht 3 - Eindsalaris: € {(salaryPerYear * years).ToString("0.00")}");
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

        public void Increment2(ref int n)
        {
            n++;
        }

        public int Increment3(int n)
        {
            return n++;
        }

        public int Increment4(string n)
        {
            return Convert.ToInt32(n) + 1;
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

        public int GetTimeInSecondsOnlyMinutes(int hours, int minutes, int seconds)
        {
            int secondsFromHoursMinutesSeconds = GetTimeInSeconds(hours, minutes, seconds);

            int minutesArg = secondsFromHoursMinutesSeconds / 60;
            int secondsArg = secondsFromHoursMinutesSeconds - minutesArg;

            return getTimeInSeconds(minutesArg, secondsArg);

            int getTimeInSeconds(int minutes, int seconds)
            {
                return minutes * 60 + seconds;
            }

        }

        public int getTImeInSecondsOnlyMinutes2(int hours, int minutes, int seconds)
        {
            int minutes2 = hours * 60 + minutes;
            return minutes2 * 60 + seconds;
        }

        public int CalculateTimeDifferenceInSeconds(int hours, int minutes, int seconds, int hours2, int minutes2, int seconds2)
        {
            return Math.Abs(GetTimeInSeconds(hours, minutes, seconds) - GetTimeInSeconds(hours2, minutes2, seconds2));
        }

        public string CalculateTimeDifferenceInHoursMinutesSeconds(int seconds, int seconds2, out int hoursOut, out int minutesOut, out int secondsOut)
        {
            var timeArray = ConvertSecondsToHoursMinutesSeconds(seconds).Split(" : ");
            var timeArray2 = ConvertSecondsToHoursMinutesSeconds(seconds2).Split(" : ");
            int differenceHours = Math.Abs(Convert.ToInt32(timeArray[0]) - Convert.ToInt32(timeArray2[0]));
            int differenceMinutes = Math.Abs(Convert.ToInt32(timeArray[1]) - Convert.ToInt32(timeArray2[1]));
            int differenceSeconds = Math.Abs(Convert.ToInt32(timeArray[2]) - Convert.ToInt32(timeArray2[2]));
            hoursOut = differenceHours;
            minutesOut = differenceMinutes;
            secondsOut = differenceSeconds;
            return $"{differenceHours}:{differenceMinutes}:{differenceSeconds}";
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowName(nameTxb.Text);
            ShowNames(firstNameTxb.Text, lastNameTxb.Text);
            ShowSalary(Convert.ToInt32(yearSalaryTxb.Text), Convert.ToInt32(yearsTxb.Text));

            SolidColorBrush brush = new SolidColorBrush(Colors.Black);
            DrawCircle(o4Cvs, brush, 45, 45, 30);

            DrawTriangle2(o5Cvs, brush, 0, 0, 50, 50);

            DrawStreet(o6Cvs, brush, 0, 0, 10, 10);

            DrawStreetInPerspective(o7Cvs, brush, 0, 0, 10, 10);

            double o8 = CalculateEuroEquivalent(37.50);

            MessageBox.Show($"Opdracht 8 - In Euro's: €{o8.ToString("0.00")}");

            double o9 = CalculateCubeVolume(1.2);

            MessageBox.Show($"Opdracht 9 - Inhoud van de kubus {o9.ToString("0.0")}");

            double o10 = CalculateCircleArea(1.25);

            MessageBox.Show($"Opdracht 10 - Oppervlakte van de cirkel {o10.ToString("0.0")}");

            double o11 = GetTimeInSeconds(1, 1, 2);

            MessageBox.Show($"Opdracht 11 - Tijd in seconden: {o11}");

            double o12 = CalculateCilinderArea(1.25);

            MessageBox.Show($"Opdracht 12 - Oppervlakte van een cilinder: {o12.ToString("0.0")}");

            double o13 = Increment(3);

            MessageBox.Show($"Opdracht 13 - Opgehoogd: {o13}");

            string o14 = ConvertNumberToBinary(12);

            MessageBox.Show($"Opdracht 14 - Binair: {o14}");

            string o15 = ConvertSecondsToHoursMinutesSeconds(3662);

            MessageBox.Show($"Opdracht 15 - {o15}");

            int o16A;
            int o16B;
            int o16C;

            GetInput3(out o16A, out o16B, out o16C);

            int o17 = CalculateTimeDifferenceInSeconds(2, 1, 1, 1, 1, 2);

            MessageBox.Show($"Opdracht 17 - {o17}");

            int o19 = 4;
            Increment2(ref o19);

            MessageBox.Show($"Opdracht 19 - {o19}");

            int o20 = GetTimeInSecondsOnlyMinutes(1, 1, 2);

            MessageBox.Show($"Opdracht 20 - {o20}");

            int o21 = getTImeInSecondsOnlyMinutes2(1, 1, 2);

            MessageBox.Show($"Opdracht 21 - {o21}");

            int o22A = Increment3(4);

            MessageBox.Show($"Opdracht 22a - {o22A}");

            int o22B = Increment4("4");

            MessageBox.Show($"Opdracht 22b - {o22B}");
        }
    }
}
