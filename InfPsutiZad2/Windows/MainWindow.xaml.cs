using InfPsutiZad2.ModelVIew;
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

namespace InfPsutiZad2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MWViewModel();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        ////{
        ////    list_box.Items.Add($"Вы {tb_family.Text}");

        ////    list_box.Items.Add($"Вы прожили { (date_selected.SelectedDate.Value - date_birthday.SelectedDate.Value).TotalDays}");

        ////    list_box.Items.Add($"Вы хотите учится {tb_days.Text}");

        ////    list_box.Items.Add($"Вы станете умным {date_selected.SelectedDate.Value.AddDays(Convert.ToInt32(tb_days.Text))}");

        ////    list_box.Items.Add($"Это будет {date_selected.SelectedDate.Value.AddDays(Convert.ToInt32(tb_days.Text)).DayOfWeek}");

        //}
    }
}
