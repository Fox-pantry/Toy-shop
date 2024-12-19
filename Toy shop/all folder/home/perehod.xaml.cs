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
using System.Windows.Shapes;
using Toy_shop.all_folder.catalog.carToy;
using Toy_shop.all_folder.catalog.createToy;
using Toy_shop.all_folder.catalog.knitToy;
using Toy_shop.all_folder.catalog.logicToy;
using Toy_shop.all_folder.catalog.softToy;

namespace Toy_shop.all_folder.home
{
    /// <summary>
    /// Логика взаимодействия для perehod.xaml
    /// </summary>
    public partial class perehod : Window
    {
        public string[] reu { get; set; }
        public perehod()
        {
            InitializeComponent();
            reu = new string[] { "Машинки", "Конструктор", "Вязаные", "Головоломки","Мягкие" };
            DataContext = this;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Fex = sender as ComboBox;
            if (Fex != null && Fex.SelectedItem is string selectedItem)
            {
                switch (selectedItem)
                {
                    case "Машинки":
                        Window taf = new vibor_CAR();
                        taf.Show();
                        this.Close();
                        break;
                    case "Конструктор":
                        Window fas = new vibor_CREATE();
                        fas.Show();
                        this.Close();
                        break;
                    case "Вязаные":
                        Window has = new vibor_Knit();
                        has.Show();
                        this.Close();
                        break;
                    case "Головоломки":
                        Window golo = new vibor_LOGIC();
                        golo.Show();
                        this.Close();
                        break;
                    case "Мягкие":
                        Window tas = new vibor_SOFT();
                        tas.Show();
                        this.Close();
                        break;
                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
      }
    }
}
