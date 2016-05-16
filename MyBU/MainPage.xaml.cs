using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyBU
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {  
        public MainPage()
        {
   
            this.InitializeComponent();
            MainFrame.Navigate(typeof(WebPage));
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            iBUTextBlock.Text = "MY BU";
            Home.IsSelected = true; 
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeHamburgerState();
        }

        public void Hamburger_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (Home.IsSelected)
            {
                Home.IsSelected = true;
                iBUTextBlock.Text = "MY BU";
                MainFrame.Navigate(typeof(WebPage));
                ChangeHamburgerState();
            }

            if (SelectProfile.IsSelected)
            {
               //WebpageContent.Source = ProfileUri;
                ChangeHamburgerState();
            }

            else if (PersonalDetails.IsSelected)
            {
                iBUTextBlock.Text = "PERSONAL DETAILS";
                MainFrame.Navigate(typeof(PersonalDetails));
                ChangeHamburgerState(); ;
            }

            else if (PersonalAlerts.IsSelected)
            {
                iBUTextBlock.Text = "PERSONAL ALERTS";
                MainFrame.Navigate(typeof(PersonalAlerts));
                ChangeHamburgerState();
            }

            else if (Feedback.IsSelected)
            {
                iBUTextBlock.Text = "FEEDBACK";
                MainFrame.Navigate(typeof(Feedback));
                ChangeHamburgerState();
            }

            else if (Share.IsSelected)
            {
                
                ChangeHamburgerState();
            }

            else if (About.IsSelected)
            {
                
                ChangeHamburgerState();
            }

            else if (Terms.IsSelected)
            {
                
                ChangeHamburgerState();
            }

            else if (LogOut.IsSelected)
            {

                ChangeHamburgerState();
                //Frame.Navigate(typeof(LogIn));
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            SearchBar.IsPaneOpen = !SearchBar.IsPaneOpen;
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            iBUTextBlock.Text="ABOUT ME";
            MainFrame.Navigate(typeof(About));
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            iBUTextBlock.Text = "CONTACT DEV";
            MainFrame.Navigate(typeof(Contact));
        }

        public void ChangeHamburgerState()
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;

            if (MySplitView.IsPaneOpen == false)
            {
                HamburgerClosed();
            }
            else if (MySplitView.IsPaneOpen == true)
            {
                HamburgerOpen();
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeHamburgerState();
        }

        public void HamburgerClosed()
        {
            BackButton.IsEnabled = false;
            BackButton.Visibility = Visibility.Collapsed;
            HamburgerButton.IsEnabled = true;
            HamburgerButton.Visibility = Visibility.Visible;
        }

        public void HamburgerOpen()
        {
            HamburgerButton.IsEnabled = false;
            HamburgerButton.Visibility = Visibility.Collapsed;
            BackButton.IsEnabled = true;
            BackButton.Visibility = Visibility.Visible;
        }
    }
}
