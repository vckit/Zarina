﻿#pragma checksum "..\..\..\..\..\Views\Pages\ProviderPage\ProviderViewPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7A0740085EBA8570328A36AFD159F2A154CBC5916402E79A058B3BB35B0DB03C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BookLove.Views.Pages.ProviderPage;
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


namespace BookLove.Views.Pages.ProviderPage {
    
    
    /// <summary>
    /// ProviderViewPage
    /// </summary>
    public partial class ProviderViewPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\..\Views\Pages\ProviderPage\ProviderViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbSearch;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\Views\Pages\ProviderPage\ProviderViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ProviderList;
        
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
            System.Uri resourceLocater = new System.Uri("/BookLove;component/views/pages/providerpage/providerviewpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Pages\ProviderPage\ProviderViewPage.xaml"
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
            
            #line 9 "..\..\..\..\..\Views\Pages\ProviderPage\ProviderViewPage.xaml"
            ((BookLove.Views.Pages.ProviderPage.ProviderViewPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\..\..\Views\Pages\ProviderPage\ProviderViewPage.xaml"
            this.txbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ProviderList = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            
            #line 51 "..\..\..\..\..\Views\Pages\ProviderPage\ProviderViewPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonAddProvider_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 61 "..\..\..\..\..\Views\Pages\ProviderPage\ProviderViewPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonEdit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 70 "..\..\..\..\..\Views\Pages\ProviderPage\ProviderViewPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveProvider_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
