using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MasterPage_MVVM.Controls.Picker), typeof(MasterPage_MVVM.iOS.CustomRenderer.PickerRenderer))]
namespace MasterPage_MVVM.iOS.CustomRenderer
{
    public class PickerRenderer : Xamarin.Forms.Platform.iOS.PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // Write your logic here
            }
        }
    }
}