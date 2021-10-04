using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class ErrorView : UserControl
    {
        public static readonly DependencyProperty ErrorsProperty = DependencyProperty.Register(
          nameof(Errors), typeof(ObservableCollection<string>), typeof(ErrorView), new PropertyMetadata(null));

        public ObservableCollection<string> Errors
        {
            get => (ObservableCollection<string>)GetValue(ErrorsProperty);
            set => SetValue(ErrorsProperty, value);
        }
        public ErrorView()
        {
            this.InitializeComponent();
        }
    }
}
