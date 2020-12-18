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

namespace TiliToli
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
        int[] allas = { 1, 2, 3, 4, 5, 6, 7, 8, 0 };
        int[] kesz = { 1, 2, 3, 4, 5, 6, 7, 8, 0 };
        int lepesszam2 = 0;
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button ezGomb = sender as Button;
            Button nullaGomb = (Button)FindName("Button0");

            var fTav = Math.Abs(ezGomb.Margin.Top - nullaGomb.Margin.Top);
            var vTav = Math.Abs(ezGomb.Margin.Left - nullaGomb.Margin.Left);

            int ezGombFelirat = int.Parse(ezGomb.Content.ToString());
            int ezGombIndex = Array.IndexOf(allas, ezGombFelirat);
            int nullaGombIndex = Array.IndexOf(allas, 0);

            if ((fTav == 100 && vTav == 0) || (vTav == 100 && fTav == 0))
            {
                var seged = ezGomb.Margin;
                ezGomb.Margin = nullaGomb.Margin;
                nullaGomb.Margin = seged;
                lepesszam2++;
                lepesszam.Content = "Lépésszám: " + lepesszam2;

                allas[nullaGombIndex] = allas[ezGombFelirat];
                allas[ezGombFelirat] = 0;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lepesszam2 = 0;
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                Button ezGomb = (Button)FindName("Button" + Convert.ToString(r.Next(1, 9)));
                Button nullaGomb = (Button)FindName("Button0");

                var fTav = Math.Abs(ezGomb.Margin.Top - nullaGomb.Margin.Top);
                var vTav = Math.Abs(ezGomb.Margin.Left - nullaGomb.Margin.Left);

                int ezGombFelirat = int.Parse(ezGomb.Content.ToString());
                int ezGombIndex = Array.IndexOf(allas, ezGombFelirat);
                int nullaGombIndex = Array.IndexOf(allas, 0);

                if ((fTav == 100 && vTav == 0) || (vTav == 100 && fTav == 0))
                {
                    var seged = ezGomb.Margin;
                    ezGomb.Margin = nullaGomb.Margin;
                    nullaGomb.Margin = seged;

                    var seged2 = ezGombFelirat;
                    allas[nullaGombIndex] = seged2;
                    allas[ezGombIndex] = 0;
                }
            }
        }
    }
}
