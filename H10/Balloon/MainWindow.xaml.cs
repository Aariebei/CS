using System;
using System.Windows;

namespace BalloonWithProperties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Balloon balloon;

        public MainWindow()
        {
            InitializeComponent();

            balloon = new Balloon(200);
            balloon.DisplayOn(drawingCanvas);

            btnMoveRight.Click += btnMoveRight_Click;
            btnMoveDown.Click += BtnMoveDown_Click;
            btnMoveLeft.Click += BtnMoveLeft_Click;
            btnMoveUp.Click += BtnMoveUp_Click;
            btnGrow.Click += btnGrow_Click;
            btnDisplayX.Click += btnDisplayX_Click;
            btnChangeX.Click += btnChangeX_Click;
            btnDisplayDiameter.Click += btnDisplayDiameter_Click;
            btnSaveBalloon.Click += btnSaveBalloon_Click;
        }

        private void BtnMoveUp_Click(object sender, RoutedEventArgs e)
        {
            balloon.moveUp(20);
        }

        private void BtnMoveDown_Click(object sender, RoutedEventArgs e)
        {
            balloon.moveDown(20);
        }

        private void BtnMoveLeft_Click(object sender, RoutedEventArgs e)
        {
            balloon.MoveLeft(20);
        }

        private void btnMoveRight_Click(object sender, RoutedEventArgs e)
        {
            balloon.MoveRight(20);
            //balloon.x += 20;
        }
        private void btnGrow_Click(object sender, RoutedEventArgs e)
        {
            balloon.ChangeSize(20);
        }
        private void btnDisplayX_Click(object sender, RoutedEventArgs e)
        {
            txbXCoord.Text = balloon.x.ToString();
        }
        private void btnChangeX_Click(object sender, RoutedEventArgs e)
        {
            balloon.x = Convert.ToInt32(txbXCoord.Text);
        }
        private void btnDisplayDiameter_Click(object sender, RoutedEventArgs e)
        {
            txbDiameter.Text = balloon.diameter.ToString();
        }
        private void btnSaveBalloon_Click(object sender, RoutedEventArgs e)
        {
            balloon.Save(balloon);
        }
    }
}
