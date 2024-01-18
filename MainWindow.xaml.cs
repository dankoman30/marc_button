using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window ,INotifyPropertyChanged
    {

        public ICommand TestClick { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            TestClick = new CommandsBase(Test);
        }

        private void Test(object? obj)
        {
            Console.WriteLine("Test");
        }


        private bool? _tnIsRotated = null;
        public bool? TNIsRotated
        {
            get => _tnIsRotated;
            set
            {
               _tnIsRotated = value;
               OnPropertyChanged(nameof(TNIsRotated));
            }
        }
        
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}