using MasterPage_MVVM.Controls;
using MasterPage_MVVM.iOS.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Textbox), typeof(TextboxRenderer))]

namespace MasterPage_MVVM.iOS.CustomRenderer
{
    public class TextboxRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // Write down your code here...
            }
        }
    }
}