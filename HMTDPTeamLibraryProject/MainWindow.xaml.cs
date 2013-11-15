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

namespace HMTDPTeamLibraryProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string mainFilePath = "..\\..\\articles.xml";

        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new StartPage());
        }

        void OnHomeButtonClick(object sender, RoutedEventArgs args)
        {
            mainFrame.Navigate(new StartPage());
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            //base.OnClosing(e);
            e.Cancel = true;
            //Environment.Exit(0);
           // MessageBoxResult askResult = MessageBox.ShowQuestion("Do you want to Exit?", "The scheduler cannot remind you during offline mode!\nYes: Exit (offline mode)\nNo: Minimize to tray (working reminder)\nCancel: Cancel command", true);
            if (true) //(askResult == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
            //if (askResult == MessageBoxResult.No)
            //{
            //    WindowState = WindowState.Minimized;
            //}
            ////this.Hide();
            ////
        }

        private void OnExitButtonClick(object sender, RoutedEventArgs e)
        {
            //MessageBoxResult askResult = MessageBox.ShowQuestion("Do you want to Exit?", "The scheduler cannot remind you during offline mode!\nYes: Exit (offline mode)\nNo: Minimize to tray (working reminder)\nCancel: Cancel command", true);
            if (true) // (askResult == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
            //if (askResult == MessageBoxResult.No)
            //{
            //    WindowState = WindowState.Minimized;
            //}
        }

        private void OnMinimizeButtonClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void OnInfoButtonClick(object sender, RoutedEventArgs e)
        {
           
        }

        private void OnCheckButtonClick(object sender, RoutedEventArgs e)
        {
          
        }    
    }
}
