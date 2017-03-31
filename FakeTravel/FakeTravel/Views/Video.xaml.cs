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
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.Storage;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FakeTravel.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Video : Page
    {
        public Video()
        {
            this.InitializeComponent();
        }

        private async void openFile_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker fop = new FileOpenPicker();
            fop.SuggestedStartLocation = PickerLocationId.Desktop;
            fop.ViewMode = PickerViewMode.Thumbnail;
            fop.FileTypeFilter.Add(".mp4");

            StorageFile file = await fop.PickSingleFileAsync();

            MediaInstruction.Visibility = Visibility.Collapsed;
            Link1.Visibility = Visibility.Collapsed;
            Link2.Visibility = Visibility.Collapsed;

            if(file != null)
            {
                IRandomAccessStream stream = await file.OpenAsync(FileAccessMode.Read);
                media.SetSource(stream, file.ContentType);
                media.Play();
            }
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            if(media.DefaultPlaybackRate != 1)
            {
                media.DefaultPlaybackRate = 1.0;
            }
            media.Play();
        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {
            media.Pause();
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            media.Stop();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            media.DefaultPlaybackRate = -2.0;
            media.Play();
        }

        private void forward_Click(object sender, RoutedEventArgs e)
        {
            media.DefaultPlaybackRate = 2.0;
            media.Play();
        }

        private void mute_Click(object sender, RoutedEventArgs e)
        {
            media.IsMuted = !media.IsMuted;
        }

        private void volumePlus_Click(object sender, RoutedEventArgs e)
        {
            if (media.IsMuted)
            {
                media.IsMuted = false;
            }

            if(media.Volume >= 0)
            {
                media.Volume += .1;
            }
        }

        private void volumeMinus_Click(object sender, RoutedEventArgs e)
        {
            if (media.IsMuted)
            {
                media.IsMuted = false;
            }

            if (media.Volume < 0)
            {
                media.Volume -= .1;
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Inspire));
        }

        private void PurchaseButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OrderPage));
        }

        private void CanvasButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Canvas));
        }
    }
}
