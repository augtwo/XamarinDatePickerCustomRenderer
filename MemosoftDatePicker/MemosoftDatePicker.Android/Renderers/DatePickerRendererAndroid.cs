using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MemosoftDatePicker.Droid.Renderers;
using MemosoftDatePicker.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using DatePicker = Xamarin.Forms.DatePicker;
using DatePickerRenderer = MemosoftDatePicker.Renderers.DatePickerRenderer;

[assembly: ExportRenderer(typeof(DatePickerRenderer), typeof(DatePickerRendererAndroid))]
namespace MemosoftDatePicker.Droid.Renderers
{
    public class DatePickerRendererAndroid : Xamarin.Forms.Platform.Android.DatePickerRenderer
    {
        protected DatePicker _element;

        public DatePickerRendererAndroid(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                _element = null;
            }

            if (e.NewElement != null)
            {
                _element = e.NewElement;
                Control.Gravity = GravityFlags.CenterHorizontal;
            }

        }

        protected override DatePickerDialog CreateDatePickerDialog(int year, int month, int day)
        {
            var dialog = new DatePickerDialog(Context, (o, e) =>
            {
                _element.Date = e.Date;
                ((IElementController)_element).SetValueFromRenderer(VisualElement.IsFocusedPropertyKey, false);
            }, year, month, day);

            dialog.SetButton((int)DialogButtonType.Positive, Context.Resources.GetString(global::Android.Resource.String.Ok), OnOkay);
            dialog.SetButton((int)DialogButtonType.Negative, Context.Resources.GetString(global::Android.Resource.String.Cancel), OnCancel);

            return dialog;
        }

        private void OnCancel(object sender, DialogClickEventArgs e)
        {
            _element.Unfocus();
        }

        private void OnOkay(object sender, DialogClickEventArgs e)
        {
            _element.Date = ((DatePickerDialog)sender).DatePicker.DateTime;
            _element.Unfocus();

            if (_element is DatePickerRenderer element)
            {
                element.OnDateSelected?.Invoke();
            }
        }
    }
}