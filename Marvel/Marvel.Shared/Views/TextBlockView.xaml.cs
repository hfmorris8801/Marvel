using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Marvel.Views
{
    public sealed partial class TextBlockView : UserControl
    {
        public static readonly DependencyProperty LabelProperty = DependencyProperty.Register(
           nameof(Label), typeof(string), typeof(TextBlockView), new PropertyMetadata(null));

        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        } 
        
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
          nameof(Text), typeof(string), typeof(TextBlockView), new PropertyMetadata(null));

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public TextBlockView()
        {
            this.InitializeComponent();
        }
    }
}
