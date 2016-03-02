using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Primitives;
using System.Reflection;
using Caliburn.Addins;
using Caliburn.Addins.Commands;

namespace AddinDemo
{
    public class AppBootstrapper:BootstrapperBase
    {


        private CompositionContainer container;

        public AppBootstrapper()
        {
            Initialize();
        }


        protected override void Configure()
        {
            AggregateCatalog catalog = new AggregateCatalog(
                    AssemblySource.Instance.Select(a => new AssemblyCatalog(a)).OfType<ComposablePartCatalog>()
                );

            container = new CompositionContainer(catalog);

            CompositionBatch batch = new CompositionBatch();
            batch.AddExportedValue<IWindowManager>(new WindowManager());
            batch.AddExportedValue<IEventAggregator>(new EventAggregator());
            container.Compose(batch);
        }

        protected override object GetInstance(Type service, string key)
        {
            string contract = string.IsNullOrEmpty(key) ? AttributedModelServices.GetContractName(service) : key;
            return container.GetExportedValue<object>(contract);
        }

        protected override System.Collections.Generic.IEnumerable<object> GetAllInstances(Type service)
        {
            string contract = AttributedModelServices.GetContractName(service);
            return container.GetExportedValues<object>(contract);
        }

        protected override void BuildUp(object instance)
        {
            container.ComposeParts(instance);
        }

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e)
        {
            DisplayRootViewFor<IShell>();
        }
    }
}
