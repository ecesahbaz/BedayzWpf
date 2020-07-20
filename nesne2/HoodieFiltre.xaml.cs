using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace nesne2
{
    /// <summary>
    /// HoodieFiltre.xaml etkileşim mantığı
    /// </summary>
    public partial class HoodieFiltre : Window
    {
        public HoodieFiltre()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow sayfa = new MainWindow();
            sayfa.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hikayemiz sayfa = new Hikayemiz();
            sayfa.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Hikayemiz sayfa = new Hikayemiz();
            sayfa.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            UyeGirisiWindow sayfa = new UyeGirisiWindow();
            sayfa.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            UyeOlWindow sayfa = new UyeOlWindow();
            sayfa.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AnasayfaWindow sayfa = new AnasayfaWindow();
            sayfa.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MainWindow sayfa = new MainWindow();
            sayfa.Show();
            this.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            AnasayfaWindow sayfa = new AnasayfaWindow();
            sayfa.Show();
            this.Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MainWindow sayfa = new MainWindow();
            sayfa.Show();
            this.Close();
        }
    }
}
