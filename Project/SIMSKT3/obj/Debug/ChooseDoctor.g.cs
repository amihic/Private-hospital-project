<<<<<<< HEAD
﻿#pragma checksum "..\..\ChooseDoctor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D3CAB7E3DBB45AFE567B5785D16964D685207142619E1BF682649A67E84CFEDE"
=======
﻿#pragma checksum "..\..\ChooseDoctor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C99F2F7641278F1387F4C8A496EDFA8AD8009E1F47929437871B8B55EC2912FE"
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
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
    /// ChooseDoctor
    /// </summary>
    public partial class ChooseDoctor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ChooseDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox7;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ChooseDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox6;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ChooseDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lv_doctors;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ChooseDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lb_doctors;
        
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
            System.Uri resourceLocater = new System.Uri("/SIMSKT3;component/choosedoctor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChooseDoctor.xaml"
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
            this.Textbox7 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Textbox6 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 15 "..\..\ChooseDoctor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClickClear);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 16 "..\..\ChooseDoctor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ChoseDoc);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 17 "..\..\ChooseDoctor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClickBack);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 18 "..\..\ChooseDoctor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClickReadAllDoctors);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lv_doctors = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            this.lb_doctors = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
