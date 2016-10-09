using StanowiskoSprzedazowe.ViewModel;
using System.Windows;

namespace StanowiskoSprzedazowe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainViewModel y = new MainViewModel();
        public MainWindow()
        {
            
            InitializeComponent();
            this.DataContext = y;


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Integration.WindowsFormsHost host =
                    new System.Windows.Forms.Integration.WindowsFormsHost();
            AxPosnetLib.AxPosnetLib axPosnet = new AxPosnetLib.AxPosnetLib();
            host.Child = axPosnet;

            this.grid1.Children.Add(host);

            int connectionSuccess=axPosnet.ConnectCom("COM5", 9600, 1);
            if (connectionSuccess < 0)
            {
                MessageBoxResult result = MessageBox.Show("Nie udało się połączyć z drukarką fiskalną sprawdź połączenie i ustawienia.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                App.Current.Shutdown();
            }
            string libVersion=axPosnet.PosnetLibGetVersion();
           // int send=axPosnet.Send("0x02"+"sdev\t@1\t#8FE8" +"0x03");
          //  int sendCommand = axPosnet.Send("0x02" + "monthlyrep0x09 da2016-08-190x09#CRC16" + "0x03");
            string printerResponse = axPosnet.Receive();
            //int a=axPosnet.SendFrame( "dailyrep", "da2016-08-23");
            int a = axPosnet.SendFrame("trinit", null);
            for (int i = 0; i < 5; i++)
            {
                int b = axPosnet.SendFrame("trline", "naMleko\tvt2\tpr245");
            };
            int c = axPosnet.SendFrame("subtotal", null);
            int d = axPosnet.SendFrame("trpaymentcurr", "wc100\tra10000\tnaPolski złoty\tPLN");
            int eA = axPosnet.SendFrame("trftrendb ", null);
            int ee = axPosnet.SendFrame("trend", null);



            string printerResponseSF = axPosnet.Receive();
            //this.ltbWoj.ItemsSource = y.states;
        }

        private void Label_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }

        private void Label_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {

        }
    }
}

