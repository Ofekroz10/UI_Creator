using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp2.Views;

namespace WpfApp2
{
    class Runner
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application a = new Application();
            a.Run(new MainView());
        }
    }
}
