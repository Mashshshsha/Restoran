﻿#pragma checksum "..\..\..\Windows\WindowOrder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8475FDD488E465B3190584112D6F0E4A74E74DB058A7EC09ED448A304FCFDD98"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using System.Windows.Shell;
using _21._106_10_Restoran.Windows;


namespace _21._106_10_Restoran.Windows {
    
    
    /// <summary>
    /// WindowOrder
    /// </summary>
    public partial class WindowOrder : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Windows\WindowOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtg_orders;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Windows\WindowOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_add;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Windows\WindowOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_delete;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Windows\WindowOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_red;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Windows\WindowOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_delete_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/21.106-10-Restoran;component/windows/windoworder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\WindowOrder.xaml"
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
            this.dtg_orders = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.btn_add = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Windows\WindowOrder.xaml"
            this.btn_add.Click += new System.Windows.RoutedEventHandler(this.btn_add_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_delete = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Windows\WindowOrder.xaml"
            this.btn_delete.Click += new System.Windows.RoutedEventHandler(this.btn_delete_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_red = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Windows\WindowOrder.xaml"
            this.btn_red.Click += new System.Windows.RoutedEventHandler(this.btn_red_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_delete_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Windows\WindowOrder.xaml"
            this.btn_delete_Copy.Click += new System.Windows.RoutedEventHandler(this.btn_back);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

