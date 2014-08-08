﻿using System;
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
using PanoramaApp1.Model;
using PanoramaApp1.Resources;
using System.Windows.Input;
using System.Windows.Data;
using System.Globalization;

namespace PanoramaApp1
{


    public partial class Settings : PhoneApplicationPage
    {
        SharedInformation info = SharedInformation.getInstance();
        PhotoChooserTask photoChooserTask;
        MainPage mainpageobject = new MainPage();
        public Settings()
        {
            InitializeComponent();

            DataContext = App.ViewModel;
            photoChooserTask = new PhotoChooserTask();
            photoChooserTask.Completed += new EventHandler<PhotoResult>(photoChooserTask_Completed);
            App.ViewModel.LoadBabiesData();
        }

        protected  void onNavigateTo(NavigationEventArgs e)
        {
            
            App.ViewModel.LoadData();
            //llsBabies.ItemsSource = App.ViewModel.Babies;
            
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

        private void llsBabies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (llsBabies.SelectedItem == null)
                return;

            info.babyID = (llsBabies.SelectedItem as Baby).Id;
            info.saveToIsolatedStorage();
            NavigationService.Navigate(new Uri("/MainPage.xaml?babyid=" + (llsBabies.SelectedItem as Baby).Id, UriKind.RelativeOrAbsolute));
            llsBabies.SelectedItem = null;
        }

        private void ApplicationBarAddButton_Click(object sender, EventArgs e)
        {
            
            NavigationService.Navigate(new Uri("/Registration.xaml", UriKind.RelativeOrAbsolute));
        }

        
        
    }
    
}