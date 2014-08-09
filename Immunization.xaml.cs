using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PanoramaApp1.Resources;
using PanoramaApp1.ViewModels;
using System.Windows.Media;

namespace PanoramaApp1
{
    public partial class Immunization : PhoneApplicationPage
    {
        SharedInformation info = SharedInformation.getInstance();
        //Constructor to initialise the values
        public Immunization()
        {
            InitializeComponent();

            DataContext = App.ViewModel;
        }

        protected void onNavigatedTo(NavigatingEventArgs e)
        {
            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = info.bitmapImage;
            LayoutRoot.Background = imageBrush;

            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void ImmunizationList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {   
            //check if one of the list items has been selected, if not do nothing
            if (ImmunizationList.SelectedItem == null)
                return;

            //navigate to the new page required, with an input of the selected input
            NavigationService.Navigate(new Uri("/ImmunizationDetails.xaml?selectedItem="+ (ImmunizationList.SelectedItem as ItemViewModel).ID, UriKind.RelativeOrAbsolute));

            //reset the selection 
            ImmunizationList.SelectedItem = null;
        }
    }
}