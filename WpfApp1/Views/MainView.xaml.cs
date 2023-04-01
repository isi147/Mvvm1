using System.Windows;
using System.Windows.Input;
using WpfApp1.Command;

namespace WpfApp1.Views
{

    public partial class MainView : Window
    {
        public ICommand ShowCommand { get; set; }
        public MainView()
        {
            InitializeComponent();
            DataContext = this;
            ShowCommand = new RelayCommand(ExecuteShowCommand,CanExecuteShowCommand);
        }
        void ExecuteShowCommand(object? parametr)
        {
            MessageBox.Show(txtBox.Text);
        }
        bool CanExecuteShowCommand(object? parametr)
            => txtBox.Text.Length>=5;

    }
}
