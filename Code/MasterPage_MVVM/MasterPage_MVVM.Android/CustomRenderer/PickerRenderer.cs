using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MasterPage_MVVM.Controls.Picker), typeof(MasterPage_MVVM.Droid.CustomRenderer.PickerRenderer))]
namespace MasterPage_MVVM.Droid.CustomRenderer
{
    public class PickerRenderer : Xamarin.Forms.Platform.Android.PickerRenderer
    {
        public PickerRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // Write your logic here...
            }
        }
    }
}