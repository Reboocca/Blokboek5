﻿#pragma checksum "D:\School\Gitblub\Visual Studios\2\RB_E-learningApp\Owl-learn_Blokboek5\VerwijderAccount.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8165D9D2CB5E8F1DF81CAC8347B7A78A"
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
    partial class VerwijderAccount : 
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
                    this.btAccept = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 54 "..\..\..\VerwijderAccount.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btAccept).Click += this.btAccept_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.bbtAnnuleer = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 55 "..\..\..\VerwijderAccount.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.bbtAnnuleer).Click += this.bbtAnnuleer_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btLogout = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 33 "..\..\..\VerwijderAccount.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.btLogout).Tapped += this.btLogout_Tapped;
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

