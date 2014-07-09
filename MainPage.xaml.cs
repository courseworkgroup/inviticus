using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PanoramaApp1.Resources;

namespace PanoramaApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;

            BuildLocalizedApplicationBar();
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        public void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();
            ApplicationBar.Mode= ApplicationBarMode.Minimized;
           // ApplicationBarIconButton add = new ApplicationBarIconButton();
           // add.IconUri = new Uri("/Assets/Icons/add.png", UriKind.RelativeOrAbsolute);
           // ApplicationBar.Buttons.Add(add);

           // add.Click += add_Click;

            ApplicationBarMenuItem settings = new ApplicationBarMenuItem();
            settings.Text = AppResources.AppBarSettings;
            ApplicationBar.MenuItems.Add(settings);

            settings.Click += settings_Click;

        }

       // void add_Click(object sender, EventArgs e)
       // {
       //     NavigationService.Navigate(new Uri("/Registration.xaml", UriKind.RelativeOrAbsolute));
       // }

        void settings_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Settings.xaml", UriKind.RelativeOrAbsolute));
        }

        private void TextBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Immunization.xaml", UriKind.RelativeOrAbsolute));
        }

        
    }
}