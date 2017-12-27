using NUnit.Framework;
using Study.Services;
using Study.Services.Utility;

namespace Study.Test
{
    public abstract class TestBase
    {
        protected ILinkedListService LinkedListService { get; set; }
        protected IArrayService ArrayService { get; set; }
        protected LinkedListUtility LinkedListUtility { get; set; }
        protected ArrayUtility ArrayUtility { get; set; }
        protected GlobalUtility GlobalUtility { get; set; }
        protected BinaryTreeUtility BinaryTreeUtility { get; set; }

        [SetUp]
        public virtual void BeforeEachTest()
        {
            LinkedListService = new LinkedListService();
            ArrayService = new ArrayService();

            LinkedListUtility = new LinkedListUtility();
            ArrayUtility = new ArrayUtility();
            GlobalUtility = new GlobalUtility();
            BinaryTreeUtility = new BinaryTreeUtility();
        }
    }
}
