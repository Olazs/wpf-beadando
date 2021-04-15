using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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
       
        public void gomb(object sender, RoutedEventArgs e)
        {
            vizszintes_p.Value = 150;
            fuggoleges_p.Value = 150;
            vizszintes_n.Value = 250;
            fuggoleges_n.Value = 200;
            szog.Value = 360;
            vizszintes_fe.Value = 0;
            fuggoleges_fe.Value = 0;

            asd(1, new DragCompletedEventArgs(1, 1, true));



        }

        public void asd(object sender, DragCompletedEventArgs e)
        {

            kep.Margin = new Thickness(Math.Round(vizszintes_p.Value), Math.Round(fuggoleges_p.Value), 0, 0);


            kep.Width = Math.Round(vizszintes_n.Value);
            kep.Height = Math.Round(fuggoleges_n.Value);

            elforditas.Angle = szog.Value;
            transzform.AngleX = vizszintes_fe.Value;
            transzform.AngleY = fuggoleges_fe.Value;
        }

        
        
    }
}
