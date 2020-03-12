using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    /*
     This is the MainModel. generate the path to the xml file,
     and instance of IDataProvider for parse the IbuttonObj from xml file.
     */
    class MainModel
    {
        private const string path = "config.xml";
        private readonly IDataProvider<IbuttonObj> provider;


        public MainModel()
        {
            this.provider = new ControlsProvider(path);
        }

        public IEnumerable<IbuttonObj> GetAll()
        {
            return this.provider.GetAll();
        }
    }
}
