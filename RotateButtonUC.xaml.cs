using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp3
{
    public partial class RotateButtonUC : UserControl
    {
        public RotateButtonUC()
        {
            InitializeComponent();
        }

        public ICommand TNCommand
        {
            get { return (ICommand)GetValue(TNCommandProperty); }
            set { SetValue(TNCommandProperty, value); }
        }

        public static readonly DependencyProperty TNCommandProperty =
            DependencyProperty.Register("TNCommand",
                typeof(ICommand),
                typeof(RotateButtonUC),
                new UIPropertyMetadata(null));

        public object TNCommandParameter
        {
            get { return (object)GetValue(TNCommandParameterProperty); }
            set { SetValue(TNCommandParameterProperty, value); }
        }

        public static readonly DependencyProperty TNCommandParameterProperty =
            DependencyProperty.Register("TNCommandParameter",
                typeof(object),
                typeof(RotateButtonUC),
                new UIPropertyMetadata(null));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TNIsRotated == null)
                TNIsRotated = true;
            TNIsRotated = !TNIsRotated;
        }

        public bool? TNIsRotated
        {
            get { return (bool?)GetValue(TNIsRotatedProperty); }
            set { SetValue(TNIsRotatedProperty, value); }
        }

        public static readonly DependencyProperty TNIsRotatedProperty =
            DependencyProperty.Register("TNIsRotated",
                typeof(bool?),
                typeof(RotateButtonUC),
                new UIPropertyMetadata(null));
    }
}
