using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WpfApp2.Models
{
    /*
     This class implements IDataProvider for IbuttonObj instances.
     */

    class ControlsProvider : IDataProvider<IbuttonObj>
    {
        private const string RootXname = "IbuttonObj";
        private readonly XDocument doc;
        private readonly string xmlFilePath;

        public ControlsProvider(string path)
        {
            this.xmlFilePath = path;
            this.doc = XDocument.Load(this.xmlFilePath);
        }

        public IEnumerable<IbuttonObj> GetAll()
        {
            return doc.Descendants(RootXname).Select(element => element.FromXElement<IbuttonObj>());
        }
    }
}
