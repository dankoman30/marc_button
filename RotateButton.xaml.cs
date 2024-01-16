using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for RotateButton.xaml
    /// </summary>
    public partial class RotateButton : UserControl
    {
        public RotateButton()
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
                typeof(RotateButton),
                new UIPropertyMetadata(null));

        public bool TNIsActive
        {
            get { return (bool)GetValue(TNIsActiveProperty); }
            set { SetValue(TNIsActiveProperty, value); }
        }

        public static readonly DependencyProperty TNIsActiveProperty =
            DependencyProperty.Register("TNIsActive",
                typeof(bool),
                typeof(RotateButton),
                new PropertyMetadata(false));
    }
}
