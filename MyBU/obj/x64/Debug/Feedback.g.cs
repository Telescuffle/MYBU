﻿#pragma checksum "C:\Users\samue\Documents\Visual Studio 2015\Projects\MyBU\MyBU\Feedback.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0B2362DBCDED3C14794D553F035C1FFB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyBU
{
    partial class Feedback : 
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
                    global::Windows.UI.Xaml.Controls.PivotItem element1 = (global::Windows.UI.Xaml.Controls.PivotItem)(target);
                    #line 20 "..\..\..\Feedback.xaml"
                    ((global::Windows.UI.Xaml.Controls.PivotItem)element1).Loaded += this.PivotItem_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.PivotItem element2 = (global::Windows.UI.Xaml.Controls.PivotItem)(target);
                    #line 23 "..\..\..\Feedback.xaml"
                    ((global::Windows.UI.Xaml.Controls.PivotItem)element2).Loaded += this.PivotItem_Loaded_1;
                    #line default
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.PivotItem element3 = (global::Windows.UI.Xaml.Controls.PivotItem)(target);
                    #line 26 "..\..\..\Feedback.xaml"
                    ((global::Windows.UI.Xaml.Controls.PivotItem)element3).Loaded += this.PivotItem_Loaded_2;
                    #line default
                }
                break;
            case 4:
                {
                    this.SuggestionFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 5:
                {
                    this.ProblemFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 6:
                {
                    this.FeedbackFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
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

