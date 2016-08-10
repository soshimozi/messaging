using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Shared
{
    public class ManagedExtensionTypeReader
    {
        public static void LoadTypes(object collector, string path)
        {
            //A catalog that can aggregate other catalogs 
            var aggrCatalog = new AggregateCatalog();

            var dirCatalog = new DirectoryCatalog(path, "*.dll");
            aggrCatalog.Catalogs.Add(dirCatalog);

            // this loads the instances into our container
            var container = new CompositionContainer(aggrCatalog);
            container.ComposeParts(collector);

        }
    }
}
