﻿#pragma checksum "..\..\ManageAllergens.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "107390ABEF94E2D02D8F16F72F7188A859B978EBFE8370D92E2FE5E8775C0838"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SIMSKT3;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SIMSKT3 {
    
    
    /// <summary>
    /// ManageAllergens
    /// </summary>
    public partial class ManageAllergens : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\ManageAllergens.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox9;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ManageAllergens.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox10;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ManageAllergens.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lv_allergens;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ManageAllergens.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lb_allergens;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ManageAllergens.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox16;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SIMSKT3;component/manageallergens.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ManageAllergens.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Textbox9 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Textbox10 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 22 "..\..\ManageAllergens.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_CreateAllergens);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 23 "..\..\ManageAllergens.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClickReadAllergen);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 24 "..\..\ManageAllergens.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClickReadAllAllergens);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 25 "..\..\ManageAllergens.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClickUpdateAllergen);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 26 "..\..\ManageAllergens.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClickDeleteAllergen);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 27 "..\..\ManageAllergens.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_DeleteAllAllergens);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 28 "..\..\ManageAllergens.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClickClearAllergens);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 29 "..\..\ManageAllergens.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClickBack);
            
            #line default
            #line hidden
            return;
            case 11:
            this.lv_allergens = ((System.Windows.Controls.ListView)(target));
            
            #line 30 "..\..\ManageAllergens.xaml"
            this.lv_allergens.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lv_allergens_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.lb_allergens = ((System.Windows.Controls.ListBox)(target));
            return;
            case 13:
            this.Textbox16 = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

