﻿#pragma checksum "C:\Users\ShiJiong\Documents\Visual Studio 2017\Projects\RPiCognitiveServie\RPiCognitiveServie\PhotoPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "93EE94CFD29D8E2761A9D135C8A3C854"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RPiCognitiveServie
{
    partial class PhotoPage : 
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
                    this.spMain = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 2:
                {
                    this.grdPicker = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.ringLoading = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 4:
                {
                    this.txtLocation = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.gridFaces = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6:
                {
                    this.gridTags = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7:
                {
                    this.gridDesc = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 8:
                {
                    this.txtDesc = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.txtDesc_Score = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.txtAdult = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.txtAdult_Score = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.txtRacy = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.txtRacy_Score = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.lstFiles = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 74 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.lstFiles).KeyUp += this.lstFiles_KeyUp;
                    #line 74 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.lstFiles).DoubleTapped += this.lstFiles_DoubleTapped;
                    #line default
                }
                break;
            case 15:
                {
                    this.lblBreadcrumb = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.btnSelect = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 70 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSelect).Click += this.btnSelect_Click;
                    #line default
                }
                break;
            case 17:
                {
                    this.btnCancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 71 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCancel).Click += this.btnCancel_Click;
                    #line default
                }
                break;
            case 18:
                {
                    this.imgPhoto = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 40 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.imgPhoto).ImageOpened += this.imgPhoto_ImageOpened;
                    #line default
                }
                break;
            case 19:
                {
                    this.cvasMain = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                    #line 47 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.cvasMain).SizeChanged += this.cvasMain_SizeChanged;
                    #line default
                }
                break;
            case 20:
                {
                    this.txtFileName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 28 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtFileName).TextChanged += this.txtFileName_TextChanged;
                    #line default
                }
                break;
            case 21:
                {
                    this.btnOpen = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnOpen).Click += this.btnOpen_Click;
                    #line default
                }
                break;
            case 22:
                {
                    this.btnBrowse = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 30 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnBrowse).Click += this.btnBrowse_Click;
                    #line default
                }
                break;
            case 23:
                {
                    this.btnClear = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\PhotoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnClear).Click += this.btnClear_Click;
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

