﻿#pragma checksum "C:\Users\ed\documents\visual studio 2015\Projects\JeSuiSCatholic\JeSuiSCatholic\Prayer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7E544FACFE1324F0EF162E16021F12B9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeSuiSCatholic
{
    partial class Prayer : 
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
                    this.RootGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 11 "..\..\..\Prayer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.RootGrid).SizeChanged += this.RootGrid_SizeChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.ParallaxRoot = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 3:
                {
                    this.PerspectiveTransform = (global::Windows.UI.Xaml.Media.Media3D.PerspectiveTransform3D)(target);
                }
                break;
            case 4:
                {
                    this.RainierBackgroundImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5:
                {
                    this.CliffBackgroundImage = (global::Windows.UI.Xaml.Controls.Image)(target);
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
