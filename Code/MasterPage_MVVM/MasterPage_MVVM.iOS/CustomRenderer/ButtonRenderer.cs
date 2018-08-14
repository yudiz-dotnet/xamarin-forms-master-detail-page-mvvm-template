using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(MasterPage_MVVM.Controls.Button), typeof(MasterPage_MVVM.iOS.CustomRenderer.ButtonRenderer))]
namespace MasterPage_MVVM.iOS.CustomRenderer
{
    public class ButtonRenderer : Xamarin.Forms.Platform.iOS.ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // Write you login here...
            }
        }
    }
}