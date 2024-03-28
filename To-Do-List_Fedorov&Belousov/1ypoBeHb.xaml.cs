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
    /// Логика взаимодействия для _1ypoBeHb.xaml
    /// </summary>
    public partial class _1ypoBeHb : Window
    {
        public _1ypoBeHb()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ycTalL ycTalL = new ycTalL();
            ycTalL.Show();
            this.Close();
        }
    }
}
