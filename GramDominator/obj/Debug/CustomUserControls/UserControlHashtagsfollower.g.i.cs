﻿#pragma checksum "..\..\..\CustomUserControls\UserControlHashtagsfollower.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3D9914FACE5398178E4582500D908A1E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// UserControlHashtagsfollower
    /// </summary>
    public partial class UserControlHashtagsfollower : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\CustomUserControls\UserControlHashtagsfollower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GramDominator.Classes.Validation objform;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\CustomUserControls\UserControlHashtagsfollower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdoBtn_HashTags_follower_SingleUser;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\CustomUserControls\UserControlHashtagsfollower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdoBtn_HashTags_follower_MultipleUser;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\CustomUserControls\UserControlHashtagsfollower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Username;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\CustomUserControls\UserControlHashtagsfollower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_HashTags_follower_LoadUsersPath;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\CustomUserControls\UserControlHashtagsfollower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_HashTags_follower_BrowseUsers;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\CustomUserControls\UserControlHashtagsfollower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMessage_hashtagfollower_NoOfuser;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\CustomUserControls\UserControlHashtagsfollower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_HashTagefollower_Clear;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\CustomUserControls\UserControlHashtagsfollower.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkNotSendRequest;
        
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
            System.Uri resourceLocater = new System.Uri("/GramDominator;component/customusercontrols/usercontrolhashtagsfollower.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CustomUserControls\UserControlHashtagsfollower.xaml"
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
            this.rdoBtn_HashTags_follower_SingleUser = ((System.Windows.Controls.RadioButton)(target));
            
            #line 41 "..\..\..\CustomUserControls\UserControlHashtagsfollower.xaml"
            this.rdoBtn_HashTags_follower_SingleUser.Checked += new System.Windows.RoutedEventHandler(this.rdoBtn_HashTagsfollower_SingleUser_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rdoBtn_HashTags_follower_MultipleUser = ((System.Windows.Controls.RadioButton)(target));
            
            #line 42 "..\..\..\CustomUserControls\UserControlHashtagsfollower.xaml"
            this.rdoBtn_HashTags_follower_MultipleUser.Checked += new System.Windows.RoutedEventHandler(this.rdoBtn_HashTagsfollower_MultipleUser);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Username = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txt_HashTags_follower_LoadUsersPath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btn_HashTags_follower_BrowseUsers = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\CustomUserControls\UserControlHashtagsfollower.xaml"
            this.btn_HashTags_follower_BrowseUsers.Click += new System.Windows.RoutedEventHandler(this.btn_HashTagsfollower_BrowseUsers_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtMessage_hashtagfollower_NoOfuser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btn_HashTagefollower_Clear = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\CustomUserControls\UserControlHashtagsfollower.xaml"
            this.btn_HashTagefollower_Clear.Click += new System.Windows.RoutedEventHandler(this.btn_HashTagsfollower_Clear_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.chkNotSendRequest = ((System.Windows.Controls.CheckBox)(target));
            
            #line 67 "..\..\..\CustomUserControls\UserControlHashtagsfollower.xaml"
            this.chkNotSendRequest.Checked += new System.Windows.RoutedEventHandler(this.chkNotSendRequest_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

