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
            OutputText.Text += $"\n촬영: 영상 촬영을 시작합니다.";
            OutputText.TextColor = Color.Blue; 
        }

        private void OnButtonClicked2(object sender, Tizen.NUI.Components.ClickedEventArgs e)
        {
            OutputText.Text += $"\n설정: 스마트 미러의 설정을 시작합니다.";
            OutputText.TextColor = Color.Green;
        }

        private void OnButtonClicked3(object sender, Tizen.NUI.Components.ClickedEventArgs e)
        {
            OutputText.Text += $"\n효과주기: 분석된 얼굴에 효과를 입힙니다.";
            OutputText.TextColor = Color.Magenta;
        }

        private void OnButtonClicked4(object sender, Tizen.NUI.Components.ClickedEventArgs e)
        {
            OutputText.Text += $"\n얼굴분석: AI를 이용하여 얼굴 분석을 시작합니다.";
            OutputText.TextColor = Color.Red;
        }
    }
}
