using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp2.Models;

namespace WpfApp2.Helpers
{

    /* 
        This class represents an IbuttonObj template selector
        by override DataTemplateSelector class.
    */

    class IbuttonTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ButtonTemplate { get; set; }
        public DataTemplate RadioTemplate { get; set; }
        public DataTemplate CheckTemplate { get; set; }
        public DataTemplate NumericTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            DataTemplate selectedTemplate = this.RadioTemplate;

            var obj = item as IbuttonObj;
            if (obj == null) throw new InvalidCastException(ErorMsg.IbuttonTypeEror);

            switch (obj.Type)
            {
                case IbuttonType.RadioButton:
                    selectedTemplate = this.RadioTemplate;
                    break;

                case IbuttonType.CheckBox:
                    selectedTemplate = this.CheckTemplate;
                    break;

                case IbuttonType.DUpDown:
                    selectedTemplate = this.NumericTemplate;
                    break;

                case IbuttonType.Button:
                    selectedTemplate = this.ButtonTemplate;
                    break;
            }

            return selectedTemplate;
        }
    }
}

