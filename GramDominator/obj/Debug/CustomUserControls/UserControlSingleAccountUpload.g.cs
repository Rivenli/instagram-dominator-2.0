﻿#pragma checksum "..\..\..\CustomUserControls\UserControlSingleAccountUpload.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2E3FC2753A17CE015E8B0668490E5217"
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


namespace GramDominator.CustomUserControls {
    
    
    /// <summary>
    /// UserControlMobilePhones
    /// </summary>
    public partial class UserControlMobilePhones : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\CustomUserControls\UserControlSingleAccountUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GramDominator.Classes.Validation objform;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\CustomUserControls\UserControlSingleAccountUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUserControlSubmit;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\CustomUserControls\UserControlSingleAccountUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUserControlClear;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\CustomUserControls\UserControlSingleAccountUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_AddSingleAccount_Account;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\CustomUserControls\UserControlSingleAccountUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_AddSingleAccount_ProxyAddress;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\CustomUserControls\UserControlSingleAccountUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_AddSingleAccount_ProxyPort;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\CustomUserControls\UserControlSingleAccountUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_AddSingleAccount_ProxyUsername;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\CustomUserControls\UserControlSingleAccountUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txt_AddSingleAccount_ProxyPassword;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\CustomUserControls\UserControlSingleAccountUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txt_AddSingleAccount_Password;
        
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
            System.Uri resourceLocater = new System.Uri("/GramDominator;component/customusercontrols/usercontrolsingleaccountupload.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CustomUserControls\UserControlSingleAccountUpload.xaml"
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
            this.btnUserControlSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\CustomUserControls\UserControlSingleAccountUpload.xaml"
            this.btnUserControlSubmit.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnUserControlClear = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\CustomUserControls\UserControlSingleAccountUpload.xaml"
            this.btnUserControlClear.Click += new System.Windows.RoutedEventHandler(this.btnUserControlClear_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txt_AddSingleAccount_Account = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_AddSingleAccount_ProxyAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txt_AddSingleAccount_ProxyPort = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txt_AddSingleAccount_ProxyUsername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txt_AddSingleAccount_ProxyPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            this.txt_AddSingleAccount_Password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

