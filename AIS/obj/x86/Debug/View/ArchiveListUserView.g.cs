﻿#pragma checksum "..\..\..\..\View\ArchiveListUserView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "73B3814AF201578816E0BAD432ECA4E9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace AIS.View {
    
    
    /// <summary>
    /// ArchiveListUserView
    /// </summary>
    public partial class ArchiveListUserView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\..\View\ArchiveListUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\..\View\ArchiveListUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox applicantTB;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\..\View\ArchiveListUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button filterBtn;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\..\View\ArchiveListUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button resetBtn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\View\ArchiveListUserView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ArchiveDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/AIS;component/view/archivelistuserview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\ArchiveListUserView.xaml"
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
            
            #line 4 "..\..\..\..\View\ArchiveListUserView.xaml"
            ((AIS.View.ArchiveListUserView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.applicantTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.filterBtn = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\..\..\View\ArchiveListUserView.xaml"
            this.filterBtn.Click += new System.Windows.RoutedEventHandler(this.filterBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.resetBtn = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\..\View\ArchiveListUserView.xaml"
            this.resetBtn.Click += new System.Windows.RoutedEventHandler(this.resetBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 11 "..\..\..\..\View\ArchiveListUserView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Logout_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ArchiveDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

