﻿#pragma checksum "D:\School\Gitblub\Visual Studios\2\RB_E-learningApp\Owl-learn_Blokboek5\BewerkVak.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "082BD32B0A058DA95900A3AB3AD04037"
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
    partial class BewerkVak : 
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
                    this.btNieuwLO = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 62 "..\..\..\BewerkVak.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btNieuwLO).Click += this.btNieuwLO_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.lbLessen = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 3:
                {
                    this.btVerwijderLO = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 64 "..\..\..\BewerkVak.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btVerwijderLO).Click += this.btVerwijderLO_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.btNieuwLes = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 65 "..\..\..\BewerkVak.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btNieuwLes).Click += this.btNieuwLes_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.btBewerkLes = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 66 "..\..\..\BewerkVak.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btBewerkLes).Click += this.btBewerkLes_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.btVerwijderLes = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 67 "..\..\..\BewerkVak.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btVerwijderLes).Click += this.btVerwijderLes_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.cbLO = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 70 "..\..\..\BewerkVak.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cbLO).SelectionChanged += this.cbLO_SelectionChanged;
                    #line default
                }
                break;
            case 8:
                {
                    this.btLogout = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 39 "..\..\..\BewerkVak.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.btLogout).Tapped += this.btLogout_Tapped;
                    #line default
                }
                break;
            case 9:
                {
                    this.btTerug = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\BewerkVak.xaml"
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

