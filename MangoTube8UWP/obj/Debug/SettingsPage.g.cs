﻿

#pragma checksum "C:\Users\Nicholas Bryan Brook\documents\visual studio 2015\Projects\MangoTube8UWP\MangoTube8UWP\SettingsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "313E0DC2ADED8A11063D80F53E29FBB4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MangoTube8UWP
{
    partial class SettingsPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 45 "..\..\SettingsPage.xaml"
                ((global::Windows.UI.Xaml.Media.Animation.Timeline)(target)).Completed += this.HideSearchBox_Completed;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 149 "..\..\SettingsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.cmbCurrFrom_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 82 "..\..\SettingsPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.YouTubeLogo_Tapped;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 110 "..\..\SettingsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SearchButton_Click;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 96 "..\..\SettingsPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).KeyDown += this.SearchTextBox_KeyDown;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

