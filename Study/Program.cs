using Ninject;
using Study.Services;
using Study.Services.Utility;
using Study.Application.DataStructures.LinkedLists;
using System.Reflection;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            kernel.Get<ILinkedListService>();
            kernel.Get<ILinkedListUtility>();

            var app = kernel.Get<ISinglyLinkedListRepository>();

            app.CheckSinglyLinkedListContainsCycle();
        }
    }
}
