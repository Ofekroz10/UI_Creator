using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using WpfApp2.Models;
using Xceed.Wpf.Toolkit;

namespace WpfApp2.ViewModels
{
    /*
     The MainViewModel, contains IList of IButton objects, instance of model for getting data from the xml file,
     Client instance to send messages to the server, and DelegateCommand(ICommand) for button clicked or value changed
     of numeric ...

     */

    class MainViewModel : BindableBase
    {
        private IList<IButton> _controls;
        private MainModel _mainModel;
        private Client _client;
        private DelegateCommand<String> _serverCommand;

        /* Properties */
        public IList<IButton> Controls
        {
            get { return this._controls; }
            set { this._controls = value;  }
        }

        public DelegateCommand<String> ServerCommand { get { return _serverCommand; } }

        public MainViewModel()
        {
            this._mainModel = new MainModel();
            this._client = new Client(ClientConfig.ADDR, ClientConfig.PORT);
            this._serverCommand = new DelegateCommand<String>(SendToServer);
            this._controls = new List<IButton>();
            this._controls = this._mainModel.GetAll().ToList<IButton>();
            this._controls.RemoveAt(0);
        }

        private void SendToServer(String msg)
        {
            //MessageBox.Show(msg);
            this._client.Send(msg);
        }
    }
}
