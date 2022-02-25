using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using ConvertExpressionLib;

namespace ConvertExpression
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Trace.WriteLine("------------------------------");
            decimal resultOfString = FirstClass.MainFun("ceil(dIv(muLt(Sum(x, PlasT), 15), 5), sub(55, 5))");
            Trace.WriteLine(resultOfString.ToString());
            OutPutTB.Text = resultOfString.ToString();
            Trace.WriteLine("------------------------------");

            //OutPutTB.Text = Convert.ToString(Convert.ToInt32(FirstClass.MainFun("ceil(dIv(muLt(Sum(x, PlasT), 15), 5), sub(55, 5))")));
        }
    }
}
