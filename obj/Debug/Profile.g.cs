﻿#pragma checksum "D:\PanoramaApp1\PanoramaApp1\Profile.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C31B34AC479FFC76D5AF6AD0BB4C63FE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PanoramaApp1 {
    
    
    public partial class Profile : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock babyName;
        
        internal System.Windows.Controls.TextBlock birthDate;
        
        internal System.Windows.Controls.TextBlock Gender;
        
        internal System.Windows.Controls.TextBlock fatherName;
        
        internal System.Windows.Controls.TextBlock motherName;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PanoramaApp1;component/Profile.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.babyName = ((System.Windows.Controls.TextBlock)(this.FindName("babyName")));
            this.birthDate = ((System.Windows.Controls.TextBlock)(this.FindName("birthDate")));
            this.Gender = ((System.Windows.Controls.TextBlock)(this.FindName("Gender")));
            this.fatherName = ((System.Windows.Controls.TextBlock)(this.FindName("fatherName")));
            this.motherName = ((System.Windows.Controls.TextBlock)(this.FindName("motherName")));
        }
    }
}

