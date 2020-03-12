using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Serialization;
using WPFtoolkitFramework.ViewModels;

namespace WpfApp2.Models
{
    /*
     This class represent an implementation of IButton (Name, Value, Type). 
     It can be a radioButton or button or button or numeric dependence by the Type.
    */

    [XmlRoot]
    public class IbuttonObj : BindableBase, IButton
    {
        private const string DefaultMsg = "No item selected";

        private string _name;
        private string _value;
        private IbuttonType _type;
        private const string TypePropName = "Type";

        [XmlAttribute]
        public string Value { get { return _value; } set { SetProperty(ref _value, value); } }

        [XmlAttribute]
        public string Name { get { return _name; } set { _name = value; } }

        [XmlIgnore]
        public IbuttonType Type {
            get { return _type; } set { _type = value;  }
        }

        [XmlAttribute(TypePropName)]
        public int TypeAsInt { get { return (int)Type; } set { Type = (IbuttonType)value; } }
        
        public IbuttonObj() { ; }

        public IbuttonObj(string name, string value, IbuttonType type) :this()
        {
            this.Value = value;
            this.Name = name;
            this.Type = type;
        }
    }
}
