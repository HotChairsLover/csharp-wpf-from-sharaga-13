﻿#pragma checksum "..\..\..\Pages\Statement.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2598DD7CC1360F5BDB86FFB75129F18CAE43FBF433761B30101BF95AFEFCC982"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Submission_of_Applications.Pages;
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


namespace Submission_of_Applications.Pages {
    
    
    /// <summary>
    /// Statement
    /// </summary>
    public partial class Statement : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\..\Pages\Statement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ochnayaForma;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Pages\Statement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton zaOchnayaForma;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Pages\Statement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton besplatno;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Pages\Statement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton platno;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Pages\Statement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox okonchil;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Pages\Statement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox godOkonchania;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Pages\Statement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button @continue;
        
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
            System.Uri resourceLocater = new System.Uri("/Submission of Applications;component/pages/statement.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Statement.xaml"
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
            this.ochnayaForma = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.zaOchnayaForma = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.besplatno = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.platno = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.okonchil = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.godOkonchania = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.@continue = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\..\Pages\Statement.xaml"
            this.@continue.Click += new System.Windows.RoutedEventHandler(this.NextPage);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

