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

namespace WpfAppTabuadaPds
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

        private void btExecutar_Click(object sender, RoutedEventArgs e)
        {
            if(lbResposta != null)
            {
                int n = cbNumeros.SelectedIndex + 1;
                int t = 0;
                lbResposta.Items.Clear();
                for (int i = 0; i <= 10; i++)
                {
                    t = n * i;
                    ListBoxItem it = new ListBoxItem();
                    it.Content = n.ToString() + "X" + i.ToString() + "=" + t.ToString();
                    lbResposta.Items.Add(it);
                }
            }       
        }

        private void cbNumeros_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btExecutar_Click(sender, e);
        }
    }
}
