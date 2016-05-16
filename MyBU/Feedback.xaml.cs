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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MyBU
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Feedback : Page
    {
        public Feedback()
        {
            this.InitializeComponent();
        }
        private void PivotItem_Loaded(object sender, RoutedEventArgs e)
        {
            FeedbackFrame.Navigate(typeof(FeedbackFrame));
            FeedbackFrame.Visibility = Visibility.Visible;
            ProblemFrame.Visibility = Visibility.Collapsed;
            SuggestionFrame.Visibility = Visibility.Collapsed;

        }

        private void PivotItem_Loaded_1(object sender, RoutedEventArgs e)
        {
            FeedbackFrame.Navigate(typeof(ProblemFrame));
            ProblemFrame.Visibility = Visibility.Visible;
            FeedbackFrame.Visibility = Visibility.Collapsed;
            SuggestionFrame.Visibility = Visibility.Collapsed;
        }

        private void PivotItem_Loaded_2(object sender, RoutedEventArgs e)
        {
            FeedbackFrame.Navigate(typeof(SuggestionFrame));
            SuggestionFrame.Visibility = Visibility.Visible;
            FeedbackFrame.Visibility = Visibility.Collapsed;
            ProblemFrame.Visibility = Visibility.Collapsed;
        }
    }
}
