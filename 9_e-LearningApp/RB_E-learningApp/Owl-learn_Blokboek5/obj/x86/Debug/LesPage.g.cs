﻿#pragma checksum "D:\School\Gitblub\Visual Studios\2\RB_E-learningApp\Owl-learn_Blokboek5\LesPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1A6B0F9577B62961013811F71761BC40"
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
    partial class LesPage : 
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
                    this.tbNoLes = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.tbLesnaam = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.rbA = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 4:
                {
                    this.rbB = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 5:
                {
                    this.rbC = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 6:
                {
                    this.rbD = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 7:
                {
                    this.tbVraag = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.btVerder = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 71 "..\..\..\LesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btVerder).Click += this.btVerder_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.btLogout = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 40 "..\..\..\LesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.btLogout).Tapped += this.btLogout_Tapped;
                    #line default
                }
                break;
            case 10:
                {
                    this.tbUitleg = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.btTerug = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 30 "..\..\..\LesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btTerug).Click += this.Button_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.lbUitleg = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

