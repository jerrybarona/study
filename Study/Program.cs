using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var service = kernel.Get<ILinkedListService>();
            var utility = kernel.Get<ILinkedListUtility>();
            var app = new SinglyLinkedListRepository(service, utility);
            app.CheckSinglyLinkedListContainsCycle();
            //app.PrintElementsInSinglyLinkedList();

            Console.ReadLine();
        }
    }
}
