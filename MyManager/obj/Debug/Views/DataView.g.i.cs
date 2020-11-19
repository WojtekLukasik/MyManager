﻿#pragma checksum "..\..\..\Views\DataView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "70E4C918E80ABEFDF294ED916495B3B845A41CD2A6B801997762CD73C9C6B7C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MyManager.Views;
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
using System.Windows.Shell;


namespace MyManager.Views {
    
    
    /// <summary>
    /// DataView
    /// </summary>
    public partial class DataView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Views\DataView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label dataName;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\DataView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dataOpenButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Views\DataView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label dataCreationDate;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\DataView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dataCopy;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\DataView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dataDelete;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\DataView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label dataType;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MyManager;component/views/dataview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\DataView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dataName = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.dataOpenButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Views\DataView.xaml"
            this.dataOpenButton.Click += new System.Windows.RoutedEventHandler(this.DataOpenButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dataCreationDate = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.dataCopy = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Views\DataView.xaml"
            this.dataCopy.Click += new System.Windows.RoutedEventHandler(this.DataCopy_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dataDelete = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Views\DataView.xaml"
            this.dataDelete.Click += new System.Windows.RoutedEventHandler(this.DeleteObject);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dataType = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
