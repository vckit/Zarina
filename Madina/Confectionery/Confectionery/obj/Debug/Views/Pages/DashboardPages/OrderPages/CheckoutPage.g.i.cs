﻿#pragma checksum "..\..\..\..\..\..\Views\Pages\DashboardPages\OrderPages\CheckoutPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F8657B08770A0B61520D1F806D00A5FBFD7D978E917F41DA99EC22A1D5F32AE3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Confectionery.Views.Pages.DashboardPages.OrderPages;
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


namespace Confectionery.Views.Pages.DashboardPages.OrderPages {
    
    
    /// <summary>
    /// CheckoutPage
    /// </summary>
    public partial class CheckoutPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\..\..\Views\Pages\DashboardPages\OrderPages\CheckoutPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox selectedClient;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\..\Views\Pages\DashboardPages\OrderPages\CheckoutPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox selectedProduct;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\..\Views\Pages\DashboardPages\OrderPages\CheckoutPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbCount;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\..\Views\Pages\DashboardPages\OrderPages\CheckoutPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbTotalPrice;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\..\Views\Pages\DashboardPages\OrderPages\CheckoutPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox typePayment;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\..\..\Views\Pages\DashboardPages\OrderPages\CheckoutPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid BasketList;
        
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
            System.Uri resourceLocater = new System.Uri("/Confectionery;component/views/pages/dashboardpages/orderpages/checkoutpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Views\Pages\DashboardPages\OrderPages\CheckoutPage.xaml"
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
            this.selectedClient = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\..\..\..\Views\Pages\DashboardPages\OrderPages\CheckoutPage.xaml"
            this.selectedClient.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.selectedClient_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.selectedProduct = ((System.Windows.Controls.ComboBox)(target));
            
            #line 31 "..\..\..\..\..\..\Views\Pages\DashboardPages\OrderPages\CheckoutPage.xaml"
            this.selectedProduct.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.selectedProduct_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 39 "..\..\..\..\..\..\Views\Pages\DashboardPages\OrderPages\CheckoutPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnUp_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txbCount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            
            #line 49 "..\..\..\..\..\..\Views\Pages\DashboardPages\OrderPages\CheckoutPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDown_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txbTotalPrice = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.typePayment = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            
            #line 61 "..\..\..\..\..\..\Views\Pages\DashboardPages\OrderPages\CheckoutPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnBasketAdd_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 66 "..\..\..\..\..\..\Views\Pages\DashboardPages\OrderPages\CheckoutPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnOrderDone_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BasketList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 11:
            
            #line 95 "..\..\..\..\..\..\Views\Pages\DashboardPages\OrderPages\CheckoutPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnRemove_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

