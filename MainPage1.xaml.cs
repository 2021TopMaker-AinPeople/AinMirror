using Tizen.NUI;
using Tizen.NUI.BaseComponents;

namespace AinMirror
{
    public partial class MainPage1 : View
    {
        public MainPage1()
        {
            InitializeComponent();
        }

        private void OnImgClicked1(object sender, Tizen.NUI.Components.ClickedEventArgs e)
        {            
            this.Unparent();
        }
    }
}
