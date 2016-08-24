using GalaSoft.MvvmLight;
using PosnetLib;
using System.Runtime.InteropServices;

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
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// 

        const string _dllLocation = "C:\\Users\\£ukasz\\Desktop\\NCSERP\\CNS-ERP\\StanowiskoSprzedazowe\\fiscal_printer\\libposnet.dll";
        [DllImport(_dllLocation)]
        public static extern void POS_SetDebugFileName(int a, int b);
        public MainViewModel()
        {

            try
            {
              //  POS_SetDebugFileName(1, 2);
            }
            catch (System.Exception)
            {

            }
                  
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }
    }
}