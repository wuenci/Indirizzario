using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Configuration.Install;

namespace Indirizzario.Wcf
{
    public partial class WcfService : ServiceBase
    {

        public ServiceHost serviceHost = null;

        public WcfService()
        {
            InitializeComponent();
        }

        public void DoDebug()
        {
            Console.WriteLine("Service in debug mode");
            OnStart(null);
            Console.WriteLine("Press any key to stop debug!");
            Console.ReadKey();
        }

        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            serviceHost = new ServiceHost(typeof(ComunicationService));
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
