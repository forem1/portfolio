﻿#pragma checksum "..\..\..\AddSupplyWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F25837E195CA6F2F234167C5B9878E538D27DDEA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MicroElectronsManager;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace MicroElectronsManager {
    
    
    /// <summary>
    /// AddSupplyWindow
    /// </summary>
    public partial class AddSupplyWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\AddSupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RbIsSell;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\AddSupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RbIsBuy;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\AddSupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbCounterparty;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\AddSupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddCounterparty;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\AddSupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbProducts;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\AddSupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddProduct;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\AddSupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbQuantity;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\AddSupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbPrice;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\AddSupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddProductInSupply;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\AddSupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnConfirm;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\AddSupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancel;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\AddSupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridProducts;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MicroElectronsManager;V1.0.0.0;component/addsupplywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddSupplyWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\AddSupplyWindow.xaml"
            ((MicroElectronsManager.AddSupplyWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\AddSupplyWindow.xaml"
            ((MicroElectronsManager.AddSupplyWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RbIsSell = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.RbIsBuy = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.CbCounterparty = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.BtnAddCounterparty = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\AddSupplyWindow.xaml"
            this.BtnAddCounterparty.Click += new System.Windows.RoutedEventHandler(this.BtnAddCounterparty_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CbProducts = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.BtnAddProduct = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\AddSupplyWindow.xaml"
            this.BtnAddProduct.Click += new System.Windows.RoutedEventHandler(this.BtnAddProduct_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TbQuantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.TbPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.BtnAddProductInSupply = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\AddSupplyWindow.xaml"
            this.BtnAddProductInSupply.Click += new System.Windows.RoutedEventHandler(this.BtnAddProductInSupply_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.BtnConfirm = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\AddSupplyWindow.xaml"
            this.BtnConfirm.Click += new System.Windows.RoutedEventHandler(this.BtnConfirm_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\AddSupplyWindow.xaml"
            this.BtnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.DataGridProducts = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

