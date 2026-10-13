using PurchaseProgram.Models;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PurchaseProgram
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeInformation();
        }

        UserClass user = new UserClass("Kekus", 100.0f);
        CinemaClass cinemaBase = new CinemaClass(12.5f, ["Avatar", "Spider-Man"]);

        private void InitializeInformation()
        {
            Name.Content = user.GetName();
            Balance.Content = Convert.ToString(user.GetBalance());
        }

        private void Purchase_Click(object sender, RoutedEventArgs e)
        {
            int countTicket = Convert.ToInt32(Slider.Value);
            float finalPrice = CalculatePrice(countTicket, cinemaBase.GetPrice());
            if(user.GetBalance() > 0)
            {
                user.UpdateBalance(finalPrice);
                Balance.Content = Convert.ToString(user.GetBalance());
            }
            else
            {
                Balance.Foreground = Brushes.Red;
            }
        }

        private float CalculatePrice(float countTicket, float pricePerTicket)
        {
            return countTicket * pricePerTicket;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (CountTicket != null) CountTicket.Content = Convert.ToString(Slider.Value);
        }
    }
}