using Ninject;
using Ninject.Modules;
using Study.Services;
using Study.Services.Utility;

namespace Study.Test
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ILinkedListService>().To<LinkedListService>();
            Bind<IArrayService>().To<ArrayService>();
            Bind<IBinaryTreeService>().To<BinaryTreeService>();
            Bind<IStackService>().To<StackService>();

            Bind<ILinkedListUtility>().To<LinkedListUtility>();
            Bind<IArrayUtility>().To<ArrayUtility>();
            Bind<IGlobalUtility>().To<GlobalUtility>();
            Bind<IBinaryTreeUtility>().To<BinaryTreeUtility>();
        }
    }
}
