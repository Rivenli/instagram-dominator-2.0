﻿#pragma checksum "..\..\..\..\Pages\PagePhoto\UserControlUnlikePhoto.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1F0F7A29269EEF91207A21A6BBF87674"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Converters;
using FirstFloor.ModernUI.Windows.Navigation;
using GramDominator.Classes;
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


namespace GramDominator.Pages.PagePhoto {
    
    
    /// <summary>
    /// UserControlUnlikePhoto
    /// </summary>
    public partial class UserControlUnlikePhoto : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Pages\PagePhoto\UserControlUnlikePhoto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GramDominator.Classes.Validation objform;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Pages\PagePhoto\UserControlUnlikePhoto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Select_To_UnlikePhoto;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Pages\PagePhoto\UserControlUnlikePhoto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMessage_UnLike_NoOfThreads;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Pages\PagePhoto\UserControlUnlikePhoto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMessage_UnLike_DelayMin;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Pages\PagePhoto\UserControlUnlikePhoto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMessage_UnLike_DelayMax;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\Pages\PagePhoto\UserControlUnlikePhoto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMessage_UnLike_Start;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Pages\PagePhoto\UserControlUnlikePhoto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMessage_UnLike_Stop;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\..\Pages\PagePhoto\UserControlUnlikePhoto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar followprogress;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\..\Pages\PagePhoto\UserControlUnlikePhoto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtGrdPhotoUnlike_AccountsReport;
        
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
            System.Uri resourceLocater = new System.Uri("/GramDominator;component/pages/pagephoto/usercontrolunlikephoto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\PagePhoto\UserControlUnlikePhoto.xaml"
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
            this.objform = ((GramDominator.Classes.Validation)(target));
            return;
            case 2:
            this.Select_To_UnlikePhoto = ((System.Windows.Controls.ComboBox)(target));
            
            #line 47 "..\..\..\..\Pages\PagePhoto\UserControlUnlikePhoto.xaml"
            this.Select_To_UnlikePhoto.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Select_To_UnlikePhoto_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtMessage_UnLike_NoOfThreads = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtMessage_UnLike_DelayMin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtMessage_UnLike_DelayMax = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnMessage_UnLike_Start = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\..\Pages\PagePhoto\UserControlUnlikePhoto.xaml"
            this.btnMessage_UnLike_Start.Click += new System.Windows.RoutedEventHandler(this.btnMessage_UnLike_Start_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnMessage_UnLike_Stop = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\..\Pages\PagePhoto\UserControlUnlikePhoto.xaml"
            this.btnMessage_UnLike_Stop.Click += new System.Windows.RoutedEventHandler(this.btnMessage_UnLike_Stop_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.followprogress = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 9:
            this.dtGrdPhotoUnlike_AccountsReport = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            
            #line 129 "..\..\..\..\Pages\PagePhoto\UserControlUnlikePhoto.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.RefreshAccountreport_PhotoUnLike_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 130 "..\..\..\..\Pages\PagePhoto\UserControlUnlikePhoto.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteAccountModule_PhotoUnLike_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 131 "..\..\..\..\Pages\PagePhoto\UserControlUnlikePhoto.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ExportPhotoUnLike_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

