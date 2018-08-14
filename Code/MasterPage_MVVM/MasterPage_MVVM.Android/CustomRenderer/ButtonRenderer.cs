using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MasterPage_MVVM.Controls.Button), typeof(MasterPage_MVVM.Droid.CustomRenderer.ButtonRenderer))]
namespace MasterPage_MVVM.Droid.CustomRenderer
{
    public class ButtonRenderer : Xamarin.Forms.Platform.Android.ButtonRenderer
    {
        public ButtonRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // Write your logic here...
            }
        }
    }
}