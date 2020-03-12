using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    /*
        This enum represents the type of the Ibutton. 
        *Button
        *Radio button
        *Checkbox
        *Decimal UpDown (Numeric)
        
     */

    public enum IbuttonType : ushort
    {
        DUpDown = 1,
        CheckBox = 2,
        Button = 3,
        RadioButton = 4
    }
}
