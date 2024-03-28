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
    /// Логика взаимодействия для BTopoeOKHo.xaml
    /// </summary>
    public partial class BTopoeOKHo : Window
    {
        public BTopoeOKHo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TpeTbeOKHo admin = new TpeTbeOKHo();
            admin.Show();
            this.Close();
        }
    }
}
