﻿#pragma checksum "..\..\..\Windows\addNewFeatWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D7EA3BCB0741B2AF8C0C232D6FFFDAA0061EFE77CD3D609D686C44DF57D39F1A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PathFinderCharacterCreator.Windows;
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


namespace PathFinderCharacterCreator.Windows {
    
    
    /// <summary>
    /// addNewFeatWindow
    /// </summary>
    public partial class addNewFeatWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Windows\addNewFeatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FeatTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Windows\addNewFeatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxFeats;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Windows\addNewFeatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FeatNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Windows\addNewFeatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox TextBoxDescription;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows\addNewFeatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Windows\addNewFeatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Windows\addNewFeatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Windows\addNewFeatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLevel;
        
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
            System.Uri resourceLocater = new System.Uri("/PathFinderCharacterCreator;component/windows/addnewfeatwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\addNewFeatWindow.xaml"
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
            this.FeatTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\..\Windows\addNewFeatWindow.xaml"
            this.FeatTypeComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FeatTypeComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listBoxFeats = ((System.Windows.Controls.ListBox)(target));
            
            #line 20 "..\..\..\Windows\addNewFeatWindow.xaml"
            this.listBoxFeats.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBoxFeats_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FeatNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TextBoxDescription = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 5:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Windows\addNewFeatWindow.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Windows\addNewFeatWindow.xaml"
            this.SaveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DeleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Windows\addNewFeatWindow.xaml"
            this.DeleteButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtLevel = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

