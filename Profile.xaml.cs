using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PanoramaApp1.ViewModels;

namespace PanoramaApp1
{
    public partial class Profile : PhoneApplicationPage
    {

        private BabyViewModel _babyViewModel;
        SharedInformation info = SharedInformation.getInstance();
        
        public Profile()
        {
            InitializeComponent();
           
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            int babyid = -1;
            babyid = info.babyID;
            _babyViewModel = new BabyViewModel(babyid);

            DataContext = _babyViewModel;
            babyPhoto.Source = info.getBabyPhoto(_babyViewModel.Baby.PhotoURI);

        }

        void settings_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Settings.xaml", UriKind.RelativeOrAbsolute));
        }
                
    }
}