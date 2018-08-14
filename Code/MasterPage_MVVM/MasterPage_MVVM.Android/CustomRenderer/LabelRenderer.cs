using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MasterPage_MVVM.Controls.Label), typeof(MasterPage_MVVM.Droid.CustomRenderer.LabelRenderer))]
namespace MasterPage_MVVM.Droid.CustomRenderer
{
    public class LabelRenderer : Xamarin.Forms.Platform.Android.LabelRenderer
    {
        public LabelRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                //Write you logic here...
            }
        }
    }
}