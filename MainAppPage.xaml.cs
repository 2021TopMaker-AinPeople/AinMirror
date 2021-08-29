using Tizen.NUI;
using Tizen.NUI.BaseComponents;

namespace AinMirror
{
    public partial class MainAppPage : View
    {
        public MainAppPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked1(object sender, Tizen.NUI.Components.ClickedEventArgs e)
        {
            OutputText.Text += $"\nButton1 clicked!";
        }

        private void OnButtonClicked2(object sender, Tizen.NUI.Components.ClickedEventArgs e)
        {
            OutputText.Text += $"\nButton2 clicked!";
        }

        private void OnButtonClicked3(object sender, Tizen.NUI.Components.ClickedEventArgs e)
        {
            OutputText.Text += $"\nButton3 clicked!";
        }

        private void OnButtonClicked4(object sender, Tizen.NUI.Components.ClickedEventArgs e)
        {
            OutputText.Text += $"\nButton4 clicked!";
        }
    }
}
