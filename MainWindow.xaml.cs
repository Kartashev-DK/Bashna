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

namespace HanoiTower
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Panel fromSterzhen = null;
        Brush noActive = new SolidColorBrush(Color.FromArgb(0, 128, 128, 128));
        Brush Active = new SolidColorBrush(Color.FromArgb(0, 255, 255, 255));
        public MainWindow()
        {
            InitializeComponent();
        }
        private void tossdiskkk_GotFocus(object sender, MouseEventArgs e)
        {
            if (!(sender is Panel))
                return;
            var Vsterzhen = (Panel)sender;
            if (fromSterzhen == null)
            {
                if (Vsterzhen.Children.Count > 0)
                {
                    fromSterzhen = (Panel)sender;
                    fromSterzhen.Background = Active;
                }
            }
            else if (Vsterzhen == fromSterzhen)
            {
                fromSterzhen.Background = noActive;
                fromSterzhen = null;
            }
            else
            {
                var diskkk = fromSterzhen.Children[fromSterzhen.Children.Count - 1];
                if (Vsterzhen.Children.Count == 0 || (diskkk as Shape).Width < (Vsterzhen.Children[Vsterzhen.Children.Count - 1] as Shape).Width)
                {
                    fromSterzhen.Children.Remove(diskkk);
                    Vsterzhen.Children.Add(diskkk);
                    fromSterzhen.Background = noActive;
                    fromSterzhen = null;
                }
                else
                {
                    MessageBox.Show("Неверный ход!");
                }
            }
        }
    }
}
