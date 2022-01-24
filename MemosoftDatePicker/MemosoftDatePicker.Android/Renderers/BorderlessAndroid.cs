using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MemosoftDatePicker.Droid.Renderers;
using MemosoftDatePicker.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using DatePickerRenderer = Xamarin.Forms.Platform.Android.DatePickerRenderer;

[assembly: ExportRenderer(typeof(BorderlessRenderer), typeof(BorderlessAndroid))]
namespace MemosoftDatePicker.Droid.Renderers
{
    public class BorderlessAndroid : DatePickerRenderer
    {
        public BorderlessAndroid(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.DatePicker> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = ;
                MarginLayoutParams layoutParams = new MarginLayoutParams(Control.LayoutParameters);
                layoutParams.SetMargins(0, 0, 0, 0);
                LayoutParameters = layoutParams;
                Control.LayoutParameters = layoutParams;
                Control.SetPadding(0, 0, 0, 0);
                SetPadding(0, 0, 0, 0);
            }
        }
    }
}