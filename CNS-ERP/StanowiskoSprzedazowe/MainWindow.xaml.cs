using StanowiskoSprzedazowe.ViewModel;
using System.Windows;

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

            int connectionSuccess=axPosnet.ConnectCom("COM5", 9600, 1);
            string libVersion=axPosnet.PosnetLibGetVersion();
           // int send=axPosnet.Send("0x02"+"sdev\t@1\t#8FE8" +"0x03");
          //  int sendCommand = axPosnet.Send("0x02" + "monthlyrep0x09 da2016-08-190x09#CRC16" + "0x03");
            string printerResponse = axPosnet.Receive();
            //int a=axPosnet.SendFrame( "dailyrep", "da2016-08-23");
            //int a = axPosnet.SendFrame("trinit", null);
            //int b = axPosnet.SendFrame("trline", "naMleko\tvt2\tpr245");
            int c= axPosnet.SendFrame("prncancel", null);



            string printerResponseSF = axPosnet.Receive();

        }
    }
}

