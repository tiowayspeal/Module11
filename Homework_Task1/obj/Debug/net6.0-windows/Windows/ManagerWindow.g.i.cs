﻿#pragma checksum "..\..\..\..\Windows\ManagerWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47E169B37D1F7FDE9077B826AECC723AB87446DD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Homework_Task1;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Homework_Task1 {
    
    
    /// <summary>
    /// ManagerWindow
    /// </summary>
    public partial class ManagerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Windows\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxClients;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Windows\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock clientDataFieldNamexTextBlock;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Windows\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listItem;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Windows\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ChangeTextBox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Windows\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeParameterButton;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\Windows\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveChangesButton;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\Windows\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SaveChangesButtonText;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\Windows\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddClientButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Homework_Task1;component/windows/managerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\ManagerWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\Windows\ManagerWindow.xaml"
            ((Homework_Task1.ManagerWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listBoxClients = ((System.Windows.Controls.ListBox)(target));
            
            #line 14 "..\..\..\..\Windows\ManagerWindow.xaml"
            this.listBoxClients.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBoxClients_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.clientDataFieldNamexTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.listItem = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.ChangeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ChangeParameterButton = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\..\Windows\ManagerWindow.xaml"
            this.ChangeParameterButton.Click += new System.Windows.RoutedEventHandler(this.ChangeParameter_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SaveChangesButton = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\..\Windows\ManagerWindow.xaml"
            this.SaveChangesButton.Click += new System.Windows.RoutedEventHandler(this.SaveChanges_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SaveChangesButtonText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.AddClientButton = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\..\..\Windows\ManagerWindow.xaml"
            this.AddClientButton.Click += new System.Windows.RoutedEventHandler(this.AddClientButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

