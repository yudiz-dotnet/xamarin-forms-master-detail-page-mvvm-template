using Xamarin.Forms;

namespace MasterPage_MVVM.Controls
{
    public class Picker : Xamarin.Forms.Picker
    {
        public Picker()
        {
            FontFamily = Device.RuntimePlatform == Device.iOS ? "HelveticaNeue" : Device.RuntimePlatform == Device.Android ? "HelveticaNeueLt.ttf#HelveticaNeueLt"
             : "Assets/HelveticaNeue.ttf";

            FontSize = 20;
        }
    }
}