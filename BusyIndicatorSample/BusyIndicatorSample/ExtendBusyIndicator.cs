using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace BusyIndicatorSample
{
    public class ExtendBusyIndicator : BusyIndicator
    {
        public ExtendBusyIndicator()
        {
            this.DefaultStyleKey = typeof(ExtendBusyIndicator);
        }



        /// <summary>
        /// 获取或设置BusyInformation的值
        /// </summary>  
        public object BusyInformation
        {
            get { return (object)GetValue(BusyInformationProperty); }
            set { SetValue(BusyInformationProperty, value); }
        }

        /// <summary>
        /// 标识 BusyInformation 依赖属性。
        /// </summary>
        public static readonly DependencyProperty BusyInformationProperty =
            DependencyProperty.Register("BusyInformation", typeof(object), typeof(ExtendBusyIndicator), new PropertyMetadata(null, OnBusyInformationChanged));

        private static void OnBusyInformationChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            ExtendBusyIndicator target = obj as ExtendBusyIndicator;
            object oldValue = (object)args.OldValue;
            object newValue = (object)args.NewValue;
            if (oldValue != newValue)
                target.OnBusyInformationChanged(oldValue, newValue);
        }

        protected virtual void OnBusyInformationChanged(object oldValue, object newValue)
        {

        }



        /// <summary>
        /// 获取或设置IdleInformation的值
        /// </summary>  
        public object IdleInformation
        {
            get { return (object)GetValue(IdleInformationProperty); }
            set { SetValue(IdleInformationProperty, value); }
        }

        /// <summary>
        /// 标识 IdleInformation 依赖属性。
        /// </summary>
        public static readonly DependencyProperty IdleInformationProperty =
            DependencyProperty.Register("IdleInformation", typeof(object), typeof(ExtendBusyIndicator), new PropertyMetadata(null, OnIdleInformationChanged));

        private static void OnIdleInformationChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            ExtendBusyIndicator target = obj as ExtendBusyIndicator;
            object oldValue = (object)args.OldValue;
            object newValue = (object)args.NewValue;
            if (oldValue != newValue)
                target.OnIdleInformationChanged(oldValue, newValue);
        }

        protected virtual void OnIdleInformationChanged(object oldValue, object newValue)
        {
        }
    }
}
