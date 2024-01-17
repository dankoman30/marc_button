using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window ,INotifyPropertyChanged
    {

       public ICommand ButtonClick { get; set; }    
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            ButtonClick = new CommandsBase(Bob);
        }

        private void Bob(object? obj)
        {
            IsRotated = !IsRotated;
        }

        private bool _isRotated = false;
        public bool IsRotated
        {
            get => _isRotated;
            set
            {
                if(_isRotated != value)
                {
                    _isRotated = value;
                }
                OnPropertyChanged(nameof(IsRotated));
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}