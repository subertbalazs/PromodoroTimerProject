﻿#pragma checksum "C:\DEV\CKeritesProjects\PromodoroTimerProject\TimerEm2\NewTimer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7F99FE383B52C8E1DB78E4A7E54BC167"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimerEm2
{
    partial class NewTimer : 
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
                    this.cbWork = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 11 "..\..\..\NewTimer.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cbWork).SelectionChanged += this.cbWork_SelectionChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.cbRest = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 12 "..\..\..\NewTimer.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cbRest).SelectionChanged += this.cbRest_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.tbWork = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.tbRest = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.tbIntervals = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.checkBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 7:
                {
                    this.cbEndSound = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 8:
                {
                    this.nameBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\NewTimer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.btnBackNT = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 21 "..\..\..\NewTimer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnBackNT).Click += this.btnBackNT_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.cbIntervals = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 14:
                {
                    this.NewTimerFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
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

