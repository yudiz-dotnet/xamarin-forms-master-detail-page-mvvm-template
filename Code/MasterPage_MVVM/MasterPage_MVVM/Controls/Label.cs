using Xamarin.Forms;

namespace MasterPage_MVVM.Controls
{
    public class Label : Xamarin.Forms.Label
    {
        public Label()
        {
            FontFamily = Device.RuntimePlatform == Device.iOS ? "HelveticaNeue" : Device.RuntimePlatform == Device.Android ? "HelveticaNeueLt.ttf#HelveticaNeueLt"
              : "Assets/HelveticaNeue.ttf";

            FontSize = 20;
        }
    }
}