﻿#pragma checksum "..\..\..\..\Windows\ModManager.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "24B04F5F7366E27E39EF17357E7B423F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AMLResources.Properties;
using ArtemisModLoader;
using ArtemisModLoader.Controls;
using ArtemisModLoader.Properties;
using RussLibrary.ValueConverters;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace ArtemisModLoader.Windows {
    
    
    /// <summary>
    /// ModManager
    /// </summary>
    public partial class ModManager : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Windows\ModManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ArtemisModLoader.Windows.ModManager uc;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\Windows\ModManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar pb;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\Windows\ModManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pbText;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\Windows\ModManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ArtemisModLoader.Controls.PredefinedMods predefinedMods;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\..\Windows\ModManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ArtemisModLoader.Controls.Missions ctlMissions;
        
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
            System.Uri resourceLocater = new System.Uri("/AMLLibrary;component/windows/modmanager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\ModManager.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.uc = ((ArtemisModLoader.Windows.ModManager)(target));
            
            #line 10 "..\..\..\..\Windows\ModManager.xaml"
            this.uc.Loaded += new System.Windows.RoutedEventHandler(this.uc_Loaded);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\..\Windows\ModManager.xaml"
            this.uc.Drop += new System.Windows.DragEventHandler(this.uc_Drop);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\..\Windows\ModManager.xaml"
            this.uc.DragOver += new System.Windows.DragEventHandler(this.uc_DragOver);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\..\Windows\ModManager.xaml"
            this.uc.Closing += new System.ComponentModel.CancelEventHandler(this.uc_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 37 "..\..\..\..\Windows\ModManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnInstall_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 46 "..\..\..\..\Windows\ModManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnCopy);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pb = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 5:
            this.pbText = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.predefinedMods = ((ArtemisModLoader.Controls.PredefinedMods)(target));
            return;
            case 7:
            this.ctlMissions = ((ArtemisModLoader.Controls.Missions)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

