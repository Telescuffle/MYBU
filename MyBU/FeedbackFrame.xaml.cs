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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MyBU
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FeedbackFrame : Page
    {
        
            BitmapImage One = new BitmapImage(new Uri("ms-appx:/Assets/One.png", UriKind.Relative));
            BitmapImage Two = new BitmapImage(new Uri("ms-appx:/Assets/Two.png", UriKind.Relative));
            BitmapImage Three = new BitmapImage(new Uri("ms-appx:/Assets/Three.png", UriKind.Relative));
            BitmapImage Four = new BitmapImage(new Uri("ms-appx:/Assets/Four.png", UriKind.Relative));
            BitmapImage Five = new BitmapImage(new Uri("ms-appx:/Assets/Five.png", UriKind.Relative));
            

        public FeedbackFrame()
        {
            InitializeComponent();
        }

        private void slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            

            if (slider.Value == 1)
            {
                image.Source = One;
            }
            else if (slider.Value == 2)
            {
                image.Source = Two;
            }
            else if (slider.Value == 3)
            {
                image.Source = Three;
            }
            else if (slider.Value == 4)
            {
                image.Source = Four;
            }
            else if (slider.Value == 5)
            {
                image.Source = Five;
            }
        }
        
    }
}
