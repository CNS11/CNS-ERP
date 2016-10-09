using GalaSoft.MvvmLight;
using PosnetLib;
using StanowiskoSprzedazowe.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceModel;

namespace StanowiskoSprzedazowe.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        const string _dllLocation = "C:\\Users\\£ukasz\\Desktop\\NCSERP\\CNS-ERP\\StanowiskoSprzedazowe\\fiscal_printer\\libposnet.dll";
        [DllImport(_dllLocation)]
        public static extern void POS_SetDebugFileName(int a, int b);
        JednostkaTerytorialna selectedState;
        TerytWs1Client client = new TerytWs1Client();
        private List<JednostkaTerytorialna> states = new List<JednostkaTerytorialna>();
        private ObservableCollection<JednostkaTerytorialna> districts = new ObservableCollection<JednostkaTerytorialna>();


        public List<JednostkaTerytorialna> States
        {
            get
            {
                return states;
            }

            set
            {
                states = value;
            }
        }
        DateTime now = new DateTime(2016, 09, 21);
        public JednostkaTerytorialna SelectedState
        {
            get
            {
                return selectedState;
            }

            set
            {
                selectedState = (from i in States where i.NAZWA==value.NAZWA select i).FirstOrDefault();
                JednostkaTerytorialna [] powiaty=client.PobierzListePowiatow(selectedState.WOJ, now);
                Districts = new ObservableCollection<JednostkaTerytorialna>(powiaty);
            }
        }

        public ObservableCollection<JednostkaTerytorialna> Districts
        {
            get
            {
                return districts;
            }

            set
            {
                districts = value;
                RaisePropertyChanged("Districts");
            }
        }

        public MainViewModel()
        {
             

            
            client.ClientCredentials.UserName.UserName = "TestPubliczny";
            client.ClientCredentials.UserName.Password = "1234abcd";
            client.CzyZalogowany();
                JednostkaTerytorialna[] wojewodztwa=client.PobierzListeWojewodztw(DataStanu:new DateTime(2016,09,21));
             States = new List<JednostkaTerytorialna>(wojewodztwa);
            SelectedState = (from i in States select i).FirstOrDefault();
      //      RaisePropertyChanged("states");
               // client.Close();


        }
    }
}