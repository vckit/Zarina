﻿#pragma checksum "..\..\..\..\..\Views\Pages\DashboardPages\MenuPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "74173AA2D0293CC0299F6BD22E85B02F9CA04BDAED5C53E7A6C2C34F3B486A6C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Confectionery.Views.Pages.DashboardPages;
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


namespace Confectionery.Views.Pages.DashboardPages {
    
    
    /// <summary>
    /// MenuPage
    /// </summary>
    public partial class MenuPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\..\Views\Pages\DashboardPages\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBaking;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\Views\Pages\DashboardPages\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCheckout;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\Views\Pages\DashboardPages\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHistoryOrder;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\Views\Pages\DashboardPages\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogOut;
        
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
            System.Uri resourceLocater = new System.Uri("/Confectionery;component/views/pages/dashboardpages/menupage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Pages\DashboardPages\MenuPage.xaml"
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
            this.btnBaking = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\..\Views\Pages\DashboardPages\MenuPage.xaml"
            this.btnBaking.Click += new System.Windows.RoutedEventHandler(this.btnBaking_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnCheckout = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\..\Views\Pages\DashboardPages\MenuPage.xaml"
            this.btnCheckout.Click += new System.Windows.RoutedEventHandler(this.btnOrderCreate_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnHistoryOrder = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\..\Views\Pages\DashboardPages\MenuPage.xaml"
            this.btnHistoryOrder.Click += new System.Windows.RoutedEventHandler(this.btnOrderHistory_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnLogOut = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\..\Views\Pages\DashboardPages\MenuPage.xaml"
            this.btnLogOut.Click += new System.Windows.RoutedEventHandler(this.btnLogOut_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

