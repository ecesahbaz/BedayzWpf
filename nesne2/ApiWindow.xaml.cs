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
    /// ApiWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class ApiWindow : Window
    {
        public ApiWindow()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class Urun
    {
        public int Id;
        public string Name;

        public double Price;

        public string Image;


        public short QuantityInPackage;


        public int CategoryId;

        public override string ToString()
        {
            return Id.ToString() + " " + Name + " " + Price.ToString();
        }
    }

    public class UrunListesi : List<Urun>
    {
        public UrunListesi()
        {
            Add(new Urun() { Id = 1, Name = "Grafik Kartı", Price = 35,  });
            Add(new Urun() { Id = 2, Name = "Monitor", Price = 150, });
            Add(new Urun() { Id = 3, Name = "CPU X86", Price = 145,   });
            Add(new Urun() { Id = 4, Name = "USB Bellek", Price = 15,  });
            Add(new Urun() { Id = 5, Name = "HDD 250 Gb", Price = 250,  });
        }
    }
}
