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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UI_Train
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(PhotosPage));
        }


        private void ClockButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void RegisterListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ClockTextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(PhotosPage));
        }

        private void SmileyTextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(SmileyPage));
        }

        private void RecordsTextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(RecordsPage));
        }
    }
}
