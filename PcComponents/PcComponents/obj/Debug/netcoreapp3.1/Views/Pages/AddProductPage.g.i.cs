﻿#pragma checksum "..\..\..\..\..\Views\Pages\AddProductPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67A1F0AE89F8619621951E47B1DB3BB4AA1D24B9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PcComponents.Views.Pages;
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


namespace PcComponents.Views.Pages {
    
    
    /// <summary>
    /// AddProductPage
    /// </summary>
    public partial class AddProductPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\..\Views\Pages\AddProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ProductStackPanel;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\Views\Pages\AddProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageProduct;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\Views\Pages\AddProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCategory;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\Views\Pages\AddProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbProductCost;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\Views\Pages\AddProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDiscount;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\Views\Pages\AddProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMaxDiscount;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\Views\Pages\AddProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridCharacteristics;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PcComponents;V1.0.0.0;component/views/pages/addproductpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Pages\AddProductPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ProductStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.imageProduct = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            
            #line 27 "..\..\..\..\..\Views\Pages\AddProductPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonChangePicture_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbCategory = ((System.Windows.Controls.ComboBox)(target));
            
            #line 34 "..\..\..\..\..\Views\Pages\AddProductPage.xaml"
            this.cbCategory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbCategories_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbProductCost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbDiscount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbMaxDiscount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.DataGridCharacteristics = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            
            #line 92 "..\..\..\..\..\Views\Pages\AddProductPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonSave_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 93 "..\..\..\..\..\Views\Pages\AddProductPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonGetBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

