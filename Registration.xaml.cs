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
    public partial class Registration : PhoneApplicationPage
    {
        PhotoChooserTask photoChooserTask;
        public Registration()
        {
            InitializeComponent();
            photoChooserTask = new PhotoChooserTask();
            photoChooserTask.Completed += new EventHandler<PhotoResult>(photoChooserTask_Completed);
        }

        private void choosephoto_Click(object sender, RoutedEventArgs e)
        {
            photoChooserTask.Show();
        }

        public void photoChooserTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                MessageBox.Show(e.ChosenPhoto.Length.ToString());
                BitmapImage bp = new BitmapImage();
                bp.SetSource(e.ChosenPhoto);
                babyphoto.Source = bp;
            }
        }
    }
}