﻿#pragma checksum "..\..\..\OtherWindows\DealWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FFFB131FF2AE61DCF8EBE8BD7019BFF0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace Client.OtherWindows {
    
    
    /// <summary>
    /// DealWindow
    /// </summary>
    public partial class DealWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\OtherWindows\DealWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_Seller;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\OtherWindows\DealWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_Buyer;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\OtherWindows\DealWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_PersonalNumberOfDeal;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\OtherWindows\DealWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_ObjOfTransact;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\OtherWindows\DealWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_KindOfCalc;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\OtherWindows\DealWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_DateOfDeal;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\OtherWindows\DealWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_TransactionAmount;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\OtherWindows\DealWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Add;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\OtherWindows\DealWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Correct;
        
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
            System.Uri resourceLocater = new System.Uri("/Client;component/otherwindows/dealwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\OtherWindows\DealWindow.xaml"
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
            this.ComboBox_Seller = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\OtherWindows\DealWindow.xaml"
            this.ComboBox_Seller.LostFocus += new System.Windows.RoutedEventHandler(this.ComboBox_Seller_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboBox_Buyer = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.TextBox_PersonalNumberOfDeal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ComboBox_ObjOfTransact = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\..\OtherWindows\DealWindow.xaml"
            this.ComboBox_ObjOfTransact.LostFocus += new System.Windows.RoutedEventHandler(this.ComboBox_ObjOfTransact_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ComboBox_KindOfCalc = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.TextBox_DateOfDeal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TextBox_TransactionAmount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Button_Add = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\OtherWindows\DealWindow.xaml"
            this.Button_Add.Click += new System.Windows.RoutedEventHandler(this.Button_Add_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Button_Correct = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\OtherWindows\DealWindow.xaml"
            this.Button_Correct.Click += new System.Windows.RoutedEventHandler(this.Button_Correct_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

