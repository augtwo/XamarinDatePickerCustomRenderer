using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MemosoftDatePicker.Renderers
{
    public class DatePickerRenderer : DatePicker
    {

        public static readonly BindableProperty OnDateSelectedCommandProperty = BindableProperty.Create(
            propertyName: nameof(OnDateSelected),
            returnType: typeof(Action),
            declaringType: typeof(DatePickerRenderer),
            defaultValue: null);

        public Action OnDateSelected
        {
            get => (Action)GetValue(OnDateSelectedCommandProperty);
            set => SetValue(OnDateSelectedCommandProperty, value);
        }

        //public static readonly BindableProperty SetTextColorProperty = BindableProperty.Create(
        //    propertyName: nameof(TextColor),
        //    returnType: typeof(string),
        //    declaringType: typeof(DatePickerRenderer),
        //    defaultValue: null);
        //    );

        //public string TextColor
        //{
        //    get => (string)GetValue(SetTextColorProperty);
        //    set => SetValue(SetTextColorProperty, value);
        //}

    }
}
