﻿#pragma checksum "..\..\..\CustomUserControls\UserControlScrapeUserScrapePhotoURL.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3A6D2917DC95BB27EB205207DC13E5B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
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


namespace GramDominator.CustomUserControls {
    
    
    /// <summary>
    /// UserControlScrapeUserScrapePhotoURL
    /// </summary>
    public partial class UserControlScrapeUserScrapePhotoURL : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\CustomUserControls\UserControlScrapeUserScrapePhotoURL.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txt_UsernameToScrape;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\CustomUserControls\UserControlScrapeUserScrapePhotoURL.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_Select_To_Account;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\CustomUserControls\UserControlScrapeUserScrapePhotoURL.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txt_ScrapeUser_ScrapePhotoURL_NoOfUserToScrape;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\CustomUserControls\UserControlScrapeUserScrapePhotoURL.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txt_ScrapeUser_ScrapeUser_NoOfPhotoToScrape;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\CustomUserControls\UserControlScrapeUserScrapePhotoURL.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave_ScrapeUsers_ScrapePhotoURL;
        
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
            System.Uri resourceLocater = new System.Uri("/GramDominator;component/customusercontrols/usercontrolscrapeuserscrapephotourl.x" +
                    "aml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CustomUserControls\UserControlScrapeUserScrapePhotoURL.xaml"
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
            this.Txt_UsernameToScrape = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.cmb_Select_To_Account = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Txt_ScrapeUser_ScrapePhotoURL_NoOfUserToScrape = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Txt_ScrapeUser_ScrapeUser_NoOfPhotoToScrape = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnSave_ScrapeUsers_ScrapePhotoURL = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\CustomUserControls\UserControlScrapeUserScrapePhotoURL.xaml"
            this.btnSave_ScrapeUsers_ScrapePhotoURL.Click += new System.Windows.RoutedEventHandler(this.btnSave_ScrapeUsers_ScrapePhotoURL_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

