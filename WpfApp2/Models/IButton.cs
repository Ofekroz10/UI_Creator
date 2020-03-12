using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WpfApp2.Models
{
    /*
     This interface is used for marking controls 
     In addition declaretes this properties:
     *Value- The message to send to the server: the value of radio button & checkbox is the selected item
     *Type- IbuttonType 
     *Name- The name of the control 
     */

    public interface IButton
    {
        string Value { get; set; }
        string Name { get; set; }
        IbuttonType Type { get; set; }
    }
}
