﻿#pragma checksum "..\..\..\ManufactureWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22E69CAA1DB2FD1C344E7781BC76D20F5A06F90B"
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
    /// ManufactureWindow
    /// </summary>
    public partial class ManufactureWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\ManufactureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbWelcome;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\ManufactureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnExit;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\ManufactureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridManufs;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\ManufactureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem CmAdd;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\ManufactureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem CmEnd;
        
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
            System.Uri resourceLocater = new System.Uri("/MicroElectronsManager;component/manufacturewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ManufactureWindow.xaml"
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
            
            #line 8 "..\..\..\ManufactureWindow.xaml"
            ((MicroElectronsManager.ManufactureWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\ManufactureWindow.xaml"
            ((MicroElectronsManager.ManufactureWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TbWelcome = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.BtnExit = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\ManufactureWindow.xaml"
            this.BtnExit.Click += new System.Windows.RoutedEventHandler(this.BtnExit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DataGridManufs = ((System.Windows.Controls.DataGrid)(target));
            
            #line 25 "..\..\..\ManufactureWindow.xaml"
            this.DataGridManufs.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGridManufs_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CmAdd = ((System.Windows.Controls.MenuItem)(target));
            
            #line 28 "..\..\..\ManufactureWindow.xaml"
            this.CmAdd.Click += new System.Windows.RoutedEventHandler(this.CmAdd_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CmEnd = ((System.Windows.Controls.MenuItem)(target));
            
            #line 29 "..\..\..\ManufactureWindow.xaml"
            this.CmEnd.Click += new System.Windows.RoutedEventHandler(this.CmEnd_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

