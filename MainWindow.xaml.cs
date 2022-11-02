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

namespace WPF_Rassokhin_PR_7_IRSPO
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int summ;
        private void M_g_Checked(object sender, RoutedEventArgs e)
        {
            Itog.Text = Itog.Text + "1. Геркулес 200 рублей";
            int cvn1;
            cvn1 = Convert.ToInt32(Itog_3.Text);
            summ = cvn1 + 200;
            Itog_3.Text = summ.ToString();
        }

        private void By(object sender, RoutedEventArgs e)
        {
            Itog.Text = Itog.Text + "2. Булочка с сгущенкой 20 рублей ";
            int cvn2;
            cvn2 = Convert.ToInt32(Itog_3.Text);
            summ = cvn2 + 20;
            Itog_3.Text = summ.ToString();
        }

        private void hai(object sender, RoutedEventArgs e)
        {
            Itog.Text = Itog.Text + "3. Чай 10 рублей ";
            int cvn3;
            cvn3 = Convert.ToInt32(Itog_3.Text);
            summ = cvn3 + 10;
            Itog_3.Text = summ.ToString();

        }
        private void MK(object sender, RoutedEventArgs e)
        {
            Itog.Text = Itog.Text + "4. Котлета свиная 50 рублей ";
            int cvn4;
            cvn4 = Convert.ToInt32(Itog_3.Text);
            summ = cvn4 + 50;
            Itog_3.Text = summ.ToString();

        }
        private void M_KM(object sender, RoutedEventArgs e)
        {
            Itog.Text = Itog.Text + "5. Картошка с мясом 250 рублей ";
            int cvn5;
            cvn5 = Convert.ToInt32(Itog_3.Text);
            summ = cvn5 + 250;
            Itog_3.Text = summ.ToString();

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
