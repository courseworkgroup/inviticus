﻿#pragma checksum "D:\PanoramaApp1\PanoramaApp1\AddWeight.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FF710F72251636D55D9B4DAAA95C87E6"
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
    
    
    public partial class AddWeight : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox dateOfMeasurement;
        
        internal System.Windows.Controls.TextBox weightMeasured;
        
        internal System.Windows.Controls.RadioButton obeseradiobutton;
        
        internal System.Windows.Controls.RadioButton goodradiobutton;
        
        internal System.Windows.Controls.RadioButton averageradiobutton;
        
        internal System.Windows.Controls.RadioButton badradiobutton;
        
        internal System.Windows.Controls.TextBox weightComment;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PanoramaApp1;component/AddWeight.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.dateOfMeasurement = ((System.Windows.Controls.TextBox)(this.FindName("dateOfMeasurement")));
            this.weightMeasured = ((System.Windows.Controls.TextBox)(this.FindName("weightMeasured")));
            this.obeseradiobutton = ((System.Windows.Controls.RadioButton)(this.FindName("obeseradiobutton")));
            this.goodradiobutton = ((System.Windows.Controls.RadioButton)(this.FindName("goodradiobutton")));
            this.averageradiobutton = ((System.Windows.Controls.RadioButton)(this.FindName("averageradiobutton")));
            this.badradiobutton = ((System.Windows.Controls.RadioButton)(this.FindName("badradiobutton")));
            this.weightComment = ((System.Windows.Controls.TextBox)(this.FindName("weightComment")));
        }
    }
}

