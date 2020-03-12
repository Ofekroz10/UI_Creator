using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    public static class ErorMsg
    {
        public const string SelectableEror = "This ctor get only selectable type";
        public const string UnSelectableEror = "Unselectable control cannot ininialize with some values";
        public const string NullValue = "Value list cannot be null";
        public const string EmptyValue = "Value list cannot be empty";
        public const string IbuttonTypeEror = "Item is not type of IbuttonObj";

    }
}
