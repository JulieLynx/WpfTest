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

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
       
        public UserControl1()
        {
            InitializeComponent();
        }
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            AddWindow win = new AddWindow();
            win.Show();
            //this.Close();
        }
        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка нажата");
        }
    }
    class RowAdd
    {
        public string First { get; set; }

        public string Second { get; set; }
    }
}
