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

namespace WTFApp_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        public void UpdateText()
        {
            CPSText.Content = "CPS: " + y;
            Label1.Content = "Cash: " + x;
            ShopItem1.Content = "1 cash per click for $" + price1;
        }

        public int x;
        public int y = 1;
        private void Button1Click(object sender, RoutedEventArgs e)
        {
            x += y;
            UpdateText();
        }

        public int price1 = 50;
        private void ShopItem1Click(object sender, RoutedEventArgs e)
        {
            if (x >= price1)
            {

            x -= price1;
            price1 = (int)(price1 * 1.12);
            y++;
                UpdateText();
            }
            }

        private void EduardoClick(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"eduardo.wav");
            player.Play();
            _ = MessageBox.Show("well well well");
        }

        private void CashOutClick(object sender, RoutedEventArgs e)
        {
            if (x >= 1000)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"tada.wav");
                player.Play();
                _ = MessageBox.Show("you won... continue to play or close");

            }
            else
            {
                _ = MessageBox.Show($"you need ${1000-x} more... u only got ${x}");
            }
        }
    }
}

