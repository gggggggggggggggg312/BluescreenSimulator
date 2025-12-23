using System.Windows;
using BluescreenSimulator.ViewModels;

namespace BluescreenSimulator.Views
{
    public partial class BluescreenWindowWin11_2025 : Window
    {
        public BluescreenWindowWin11_2025()
        {
            InitializeComponent();

            // Reuse existing modern BSOD ViewModel
            DataContext = new Windows10BluescreenViewModel();

            // Ensure the window gets focus immediately
            Loaded += (s, e) => Activate();
        }
    }
}
