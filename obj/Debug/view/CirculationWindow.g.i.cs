﻿#pragma checksum "..\..\..\view\CirculationWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E12D06B7D0422D04D4F30F53E206104AD5BB004AE4A542553DB20E248BE5581C"
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
using varchar_128_.view;


namespace varchar_128_.view {
    
    
    /// <summary>
    /// CirculationWindow
    /// </summary>
    public partial class CirculationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\view\CirculationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idCustoner;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\view\CirculationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spInfo;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\view\CirculationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbCity;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\view\CirculationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btEdit;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\view\CirculationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox bookSearch;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\view\CirculationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbTitle;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\view\CirculationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgCurrent;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\view\CirculationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgHistory;
        
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
            System.Uri resourceLocater = new System.Uri("/varchar(128);component/view/circulationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\view\CirculationWindow.xaml"
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
            this.idCustoner = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            
            #line 27 "..\..\..\view\CirculationWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btInfoCustomer);
            
            #line default
            #line hidden
            return;
            case 3:
            this.spInfo = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.tbCity = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.btEdit = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\view\CirculationWindow.xaml"
            this.btEdit.Click += new System.Windows.RoutedEventHandler(this.btEditInfo);
            
            #line default
            #line hidden
            return;
            case 6:
            this.bookSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\..\view\CirculationWindow.xaml"
            this.bookSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbBookSearch);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tbTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.dgCurrent = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.dgHistory = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

