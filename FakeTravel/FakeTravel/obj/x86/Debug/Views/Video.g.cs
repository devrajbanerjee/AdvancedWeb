﻿#pragma checksum "C:\Users\devra\Documents\Visual Studio 2015\Projects\HTML CSS JS\FakeTravel\FakeTravel\Views\Video.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "25EB9984C4A11BC13C22207AD02C8FE2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FakeTravel.Views
{
    partial class Video : 
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
                    this.CanvasButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\Views\Video.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.CanvasButton).Click += this.CanvasButton_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 24 "..\..\..\Views\Video.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).Click += this.BackButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.PurchaseButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\Views\Video.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.PurchaseButton).Click += this.PurchaseButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.media = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 5:
                {
                    this.openFile = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 40 "..\..\..\Views\Video.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.openFile).Click += this.openFile_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.play = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 41 "..\..\..\Views\Video.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.play).Click += this.play_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.pause = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 42 "..\..\..\Views\Video.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.pause).Click += this.pause_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.stop = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 43 "..\..\..\Views\Video.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.stop).Click += this.stop_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.MediaInstruction = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.Link1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.Link2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

