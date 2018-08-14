using Android.Content;
using MasterPage_MVVM.Controls;
using MasterPage_MVVM.Droid.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Textbox), typeof(TextboxRenderer))]
namespace MasterPage_MVVM.Droid.CustomRenderer
{
    public class TextboxRenderer : EntryRenderer
    {
        public TextboxRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // Write your code here
            }
        }
    }
}