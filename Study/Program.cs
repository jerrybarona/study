using Ninject;
using Study.Services;
using Study.Services.Utility;
using Study.Application.DataStructures.LinkedLists;
using Study.Application.DataStructures.Arrays;
using System.Reflection;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            kernel.Get<IArrayService>();
            kernel.Get<IArrayUtility>();
            kernel.Get<IGlobalUtility>();

            var app = kernel.Get<IArrayRepository>();

            app.FindNumberInSorted2DMatrix();
        }
    }
}
