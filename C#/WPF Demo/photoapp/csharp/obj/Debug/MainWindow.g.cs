﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0827B61ACB1BCE3C1941AFD960708F71"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行库版本:2.0.50727.3053
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using SDKSamples.ImageSample;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace SDKSamples.ImageSample {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 160 "..\..\MainWindow.xaml"
        internal System.Windows.Controls.TextBox ImagesDir;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\MainWindow.xaml"
        internal System.Windows.Controls.ListBox PhotosListBox;
        
        #line default
        #line hidden
        
        
        #line 193 "..\..\MainWindow.xaml"
        internal System.Windows.Controls.Slider ZoomSlider;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/SDKSample;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 5 "..\..\MainWindow.xaml"
            ((SDKSamples.ImageSample.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 158 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnImagesDirChangeClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ImagesDir = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.PhotosListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 173 "..\..\MainWindow.xaml"
            this.PhotosListBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.OnPhotoClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 176 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.editPhoto);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ZoomSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 202 "..\..\MainWindow.xaml"
            this.ZoomSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ZoomSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}