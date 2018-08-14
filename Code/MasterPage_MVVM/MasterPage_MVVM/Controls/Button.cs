using Xamarin.Forms;

namespace MasterPage_MVVM.Controls
{
    public class Button : Xamarin.Forms.Button
    {
        public Button()
        {
            FontFamily = Device.RuntimePlatform == Device.iOS ? "HelveticaNeue" : Device.RuntimePlatform == Device.Android ? "HelveticaNeueLt.ttf#HelveticaNeueLt"
               : "Assets/HelveticaNeue.ttf";

            FontSize = 20;
        }
    }
}