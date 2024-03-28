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

namespace To_Do_List_Fedorov_Belousov
{
    /// <summary>
    /// Логика взаимодействия для TpeTbeOKHo.xaml
    /// </summary>
    public partial class TpeTbeOKHo : Window
    {
        public TpeTbeOKHo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheTBepToeOKHo dui = new CheTBepToeOKHo();
            dui.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CheTBepToeOKHo dui = new CheTBepToeOKHo();
            dui.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OKH_o_O oKH_O_O = new OKH_o_O();
            oKH_O_O.Show();
            this.Close();
        }
    }
}
