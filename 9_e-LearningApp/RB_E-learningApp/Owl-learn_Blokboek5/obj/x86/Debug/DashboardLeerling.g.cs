﻿#pragma checksum "D:\School\Gitblub\Visual Studios\2\RB_E-learningApp\Owl-learn_Blokboek5\DashboardLeerling.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "449D220C0703D224EC61CCAA8572205E"
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
                    #line 60 "..\..\..\DashboardLeerling.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cbVak).SelectionChanged += this.cbVak_SelectionChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.cbLesonderwerp = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 61 "..\..\..\DashboardLeerling.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cbLesonderwerp).SelectionChanged += this.cbLesonderwerp_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.cbLes = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 62 "..\..\..\DashboardLeerling.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cbLes).SelectionChanged += this.cbLes_SelectionChanged;
                    #line default
                }
                break;
            case 4:
                {
                    this.btStart = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 63 "..\..\..\DashboardLeerling.xaml"
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
                    #line 33 "..\..\..\DashboardLeerling.xaml"
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

