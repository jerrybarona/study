using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Study.Services;
using Study.Services.Utility;
using Study.Application.DataStructures.LinkedLists;

namespace Study
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ILinkedListService>().To<LinkedListService>();
            Bind<ILinkedListUtility>().To<LinkedListUtility>();
            Bind<ISinglyLinkedListRepository>().To<SinglyLinkedListRepository>();
            Bind<IGeneralLinkedListRepository>().To<GeneralLinkedListRepository>();
            Bind<IGlobalUtility>().To<GlobalUtility>();
        }
    }
}
