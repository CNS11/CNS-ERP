using StanowiskoSprzedazowe.TreeMap;
using StanowiskoSprzedazowe.ViewModel;
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

namespace StanowiskoSprzedazowe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Integration.WindowsFormsHost host =
                    new System.Windows.Forms.Integration.WindowsFormsHost();
            //PosnetAxLib.PosnetAxControl axPosnet = new PosnetAxLib.PosnetAxControl();
            AxPosnetLib.AxPosnetLib axPosnet = new AxPosnetLib.AxPosnetLib();
            host.Child = axPosnet;
            // host.Child = axPosnet;

            this.grid1.Children.Add(host);

            int connectionSuccess=axPosnet.ConnectCom("COM4", 9600, 1);
            string libVersion=axPosnet.PosnetLibGetVersion();
           // int send=axPosnet.Send("0x02"+"sdev\t@1\t#8FE8" +"0x03");
            int sendCommand = axPosnet.Send("0x02" + "monthlyrep0x09 da2016-08-190x09#CRC16" + "0x03");
            string printerResponse = axPosnet.Receive();
            int a=axPosnet.SendFrame( "dailyrep", "da2016-08-23");
            string printerResponseSF = axPosnet.Receive();

        }
    }
}

