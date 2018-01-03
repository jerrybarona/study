using NUnit.Framework;
using Ninject;
using System.Reflection;

namespace Study.Test
{
    public abstract class TestBase
    {
        protected StandardKernel Kernel { get; set; }

        [SetUp]
        public virtual void BeforeEachTest()
        {
            Kernel = new StandardKernel();
            Kernel.Load(Assembly.GetExecutingAssembly());
        }
    }
}
