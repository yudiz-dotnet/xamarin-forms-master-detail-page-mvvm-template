using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MasterPage_MVVM.Controls.Label), typeof(MasterPage_MVVM.iOS.CustomRenderer.LabelRenderer))]
namespace MasterPage_MVVM.iOS.CustomRenderer
{
    public class LabelRenderer : Xamarin.Forms.Platform.iOS.LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // Write your logic here.
            }
        }
    }
}