﻿#pragma checksum "D:\School\Gitblub\Visual Studios\2\RB_E-learningApp\Owl-learn_Blokboek5\DashboardLeerling.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CDA6CBC3FB6991118A57D25759E53C72"
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
    partial class DashboardLeerling : 
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
                    this.cbVak = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 70 "..\..\..\DashboardLeerling.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cbVak).SelectionChanged += this.cbVak_SelectionChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.cbLesonderwerp = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 71 "..\..\..\DashboardLeerling.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cbLesonderwerp).SelectionChanged += this.cbLesonderwerp_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.cbLes = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 72 "..\..\..\DashboardLeerling.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cbLes).SelectionChanged += this.cbLes_SelectionChanged;
                    #line default
                }
                break;
            case 4:
                {
                    this.btStart = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 73 "..\..\..\DashboardLeerling.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btStart).Click += this.btStart_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.tbNoLes = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.btLogout = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 43 "..\..\..\DashboardLeerling.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.btLogout).Tapped += this.btLogout_Tapped;
                    #line default
                }
                break;
            case 7:
                {
                    this.btToets = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\DashboardLeerling.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btToets).Click += this.btToets_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.btDag = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 32 "..\..\..\DashboardLeerling.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btDag).Click += this.btDag_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.btRapport = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 33 "..\..\..\DashboardLeerling.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btRapport).Click += this.btRapport_Click;
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

