﻿#pragma checksum "D:\School\Gitblub\Visual Studios\2\RB_E-learningApp\Owl-learn_Blokboek5\BewerkAccount.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3A9B6503FD6B6FE9E2BBA291A8421DB2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Owl_learn_Blokboek5
{
    partial class BewerkAccount : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.btWijziglogin = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 82 "..\..\..\BewerkAccount.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btWijziglogin).Click += this.btWijziglogin_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.tbUsername = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 83 "..\..\..\BewerkAccount.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.tbUsername).TextChanged += this.tbUsername_TextChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.pbPassword = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                    #line 84 "..\..\..\BewerkAccount.xaml"
                    ((global::Windows.UI.Xaml.Controls.PasswordBox)this.pbPassword).PasswordChanged += this.pbPassword_PasswordChanged;
                    #line default
                }
                break;
            case 4:
                {
                    this.btWijzigGegevens = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 59 "..\..\..\BewerkAccount.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btWijzigGegevens).Click += this.btWijzigGegevens_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.tbVoornaam = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 60 "..\..\..\BewerkAccount.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.tbVoornaam).TextChanged += this.tbVoornaam_TextChanged;
                    #line default
                }
                break;
            case 6:
                {
                    this.tbAchternaam = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 61 "..\..\..\BewerkAccount.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.tbAchternaam).TextChanged += this.tbAchternaam_TextChanged;
                    #line default
                }
                break;
            case 7:
                {
                    this.btLogout = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 39 "..\..\..\BewerkAccount.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.btLogout).Tapped += this.btLogout_Tapped;
                    #line default
                }
                break;
            case 8:
                {
                    this.btTerug = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\BewerkAccount.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btTerug).Click += this.Button_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

