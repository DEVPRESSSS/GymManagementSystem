﻿#pragma checksum "..\..\..\..\ViewModel\LoginPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28223773FA07339CEF68BB85EA4D42788F5D4FB2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GymManagementSystem.ViewModel;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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


namespace GymManagementSystem.ViewModel {
    
    
    /// <summary>
    /// LoginPage
    /// </summary>
    public partial class LoginPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 140 "..\..\..\..\ViewModel\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Usernametxt;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\..\ViewModel\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UsernameErrorMessage;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\..\ViewModel\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Passwordtxt;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\..\..\ViewModel\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PasswordErrorMessage;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\..\..\ViewModel\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordUnmask;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\..\..\ViewModel\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.IconPacks.PackIconMaterial Eye;
        
        #line default
        #line hidden
        
        
        #line 214 "..\..\..\..\ViewModel\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.IconPacks.PackIconMaterial Eye2;
        
        #line default
        #line hidden
        
        
        #line 222 "..\..\..\..\ViewModel\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label forgotpassword;
        
        #line default
        #line hidden
        
        
        #line 234 "..\..\..\..\ViewModel\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GymManagementSystem;component/viewmodel/loginpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ViewModel\LoginPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 16 "..\..\..\..\ViewModel\LoginPage.xaml"
            ((GymManagementSystem.ViewModel.LoginPage)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 107 "..\..\..\..\ViewModel\LoginPage.xaml"
            ((MahApps.Metro.IconPacks.PackIconMaterial)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PackIconMaterial_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Usernametxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 146 "..\..\..\..\ViewModel\LoginPage.xaml"
            this.Usernametxt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Usernametxt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UsernameErrorMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Passwordtxt = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 172 "..\..\..\..\ViewModel\LoginPage.xaml"
            this.Passwordtxt.PasswordChanged += new System.Windows.RoutedEventHandler(this.Passwordtxt_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PasswordErrorMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.PasswordUnmask = ((System.Windows.Controls.TextBox)(target));
            
            #line 195 "..\..\..\..\ViewModel\LoginPage.xaml"
            this.PasswordUnmask.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PasswordUnmask_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Eye = ((MahApps.Metro.IconPacks.PackIconMaterial)(target));
            
            #line 207 "..\..\..\..\ViewModel\LoginPage.xaml"
            this.Eye.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Eye_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Eye2 = ((MahApps.Metro.IconPacks.PackIconMaterial)(target));
            
            #line 218 "..\..\..\..\ViewModel\LoginPage.xaml"
            this.Eye2.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Eye2_MouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.forgotpassword = ((System.Windows.Controls.Label)(target));
            
            #line 228 "..\..\..\..\ViewModel\LoginPage.xaml"
            this.forgotpassword.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.forgotpassword_MouseDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.LoginBtn = ((System.Windows.Controls.Button)(target));
            
            #line 240 "..\..\..\..\ViewModel\LoginPage.xaml"
            this.LoginBtn.Click += new System.Windows.RoutedEventHandler(this.LoginBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

