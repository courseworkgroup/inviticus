using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;

namespace PanoramaApp1
{
    public partial class Settings : PhoneApplicationPage
    {
        PhotoChooserTask photoChooserTask;
        MainPage mainpageobject = new MainPage();
        public Settings()
        {
            InitializeComponent();

            DataContext = App.ViewModel;
            photoChooserTask = new PhotoChooserTask();
            photoChooserTask.Completed += new EventHandler<PhotoResult>(photoChooserTask_Completed);
        }

        protected  void onNavigateTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Registration.xaml", UriKind.RelativeOrAbsolute));
        }

        private void TextBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Registration.xaml", UriKind.RelativeOrAbsolute));
        }


        private void changeAppBackground_Click(object sender, RoutedEventArgs e)
        {
            photoChooserTask.Show();
        }

        public void photoChooserTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                MessageBox.Show(e.ChosenPhoto.Length.ToString());
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.SetSource(e.ChosenPhoto);
                mainpageobject.background(bitmapImage);
            }
        }
        
    }
}