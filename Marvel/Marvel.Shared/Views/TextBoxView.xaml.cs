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
    public sealed partial class TextBoxView : UserControl
    {
        public static readonly DependencyProperty LabelProperty = DependencyProperty.Register(
           nameof(Label), typeof(string), typeof(TextBoxView), new PropertyMetadata(null, OnLabelChanged));

        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
          nameof(Value), typeof(string), typeof(TextBoxView), new PropertyMetadata(null));

        public string Value
        {
            get => (string)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }
        public TextBoxView()
        {
            this.InitializeComponent();
        }

        private static void OnLabelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var Localization = Windows.ApplicationModel.Resources.ResourceLoader.GetForViewIndependentUse();
            if (Localization != null && e.NewValue is string key && d is TextBoxView textBoxView)
            {
                textBoxView.LabelComponent.Text = Localization.GetString(key);
            }
        }
    }
}
