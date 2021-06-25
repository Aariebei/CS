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

namespace Banking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BankAccount bankaccount = new BankAccount();
        public MainWindow()
        {
            InitializeComponent();
            btnDesposit.Click += BtnDesposit_Click;
            btnWithdraw.Click += BtnWithdraw_Click;
        }

        private void BtnWithdraw_Click(object sender, RoutedEventArgs e)
        {
            double amount = Convert.ToInt32(txbAmount.Text);
            bankaccount.WithDraw(amount);
            lblBalance.Content = bankaccount.CurrentValue;
        }

        private void BtnDesposit_Click(object sender, RoutedEventArgs e)
        {
            double amount = Convert.ToInt32(txbAmount.Text);
            bankaccount.Deposit(amount);
            lblBalance.Content = bankaccount.CurrentValue;
        }
    }
}
