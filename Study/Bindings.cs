using Ninject;
using Ninject.Modules;
using Study.Services;
using Study.Services.Utility;
using Study.Application.DataStructures.LinkedLists;
using Study.Application.DataStructures.Arrays;

namespace Study
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ISinglyLinkedListRepository>().To<SinglyLinkedListRepository>();
            Bind<IGeneralLinkedListRepository>().To<GeneralLinkedListRepository>();
            Bind<IArrayRepository>().To<ArrayRepository>();

            Bind<ILinkedListService>().To<LinkedListService>();
            Bind<IArrayService>().To<ArrayService>();

            Bind<ILinkedListUtility>().To<LinkedListUtility>();
            Bind<IArrayUtility>().To<ArrayUtility>();
            Bind<IGlobalUtility>().To<GlobalUtility>();
        }
    }
}