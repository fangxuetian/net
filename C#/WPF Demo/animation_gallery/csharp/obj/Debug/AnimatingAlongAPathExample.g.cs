﻿#pragma checksum "..\..\AnimatingAlongAPathExample.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1CF25811EF6B18D25240756895650BA6"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行库版本:2.0.50727.3053
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
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


namespace Microsoft.Samples.Animation {
    
    
    /// <summary>
    /// AnimatingAlongAPathExample
    /// </summary>
    public partial class AnimatingAlongAPathExample : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\AnimatingAlongAPathExample.xaml"
        internal System.Windows.Controls.Viewport3D MyAnimatedObject;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AnimatingAlongAPathExample.xaml"
        internal System.Windows.Media.Media3D.PerspectiveCamera myPerspectiveCamera;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\AnimatingAlongAPathExample.xaml"
        internal System.Windows.Media.Media3D.AxisAngleRotation3D MyZRotation;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\AnimatingAlongAPathExample.xaml"
        internal System.Windows.Media.Media3D.AxisAngleRotation3D MyHorizontalRotation;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\AnimatingAlongAPathExample.xaml"
        internal System.Windows.Media.Media3D.AxisAngleRotation3D MyVerticalRotation;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\AnimatingAlongAPathExample.xaml"
        internal System.Windows.Media.TranslateTransform PictureCubeTranslateTransform;
        
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
            System.Uri resourceLocater = new System.Uri("/AnimationGallery;component/animatingalongapathexample.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AnimatingAlongAPathExample.xaml"
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
            this.MyAnimatedObject = ((System.Windows.Controls.Viewport3D)(target));
            return;
            case 2:
            this.myPerspectiveCamera = ((System.Windows.Media.Media3D.PerspectiveCamera)(target));
            return;
            case 3:
            this.MyZRotation = ((System.Windows.Media.Media3D.AxisAngleRotation3D)(target));
            return;
            case 4:
            this.MyHorizontalRotation = ((System.Windows.Media.Media3D.AxisAngleRotation3D)(target));
            return;
            case 5:
            this.MyVerticalRotation = ((System.Windows.Media.Media3D.AxisAngleRotation3D)(target));
            return;
            case 6:
            this.PictureCubeTranslateTransform = ((System.Windows.Media.TranslateTransform)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}