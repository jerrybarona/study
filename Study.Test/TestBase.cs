using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Study.Services;
using Study.Services.Utility;
using Study.Models;

namespace Study.Test
{
    public abstract class TestBase
    {
        protected ILinkedListService LinkedListService { get; set; }
        protected IArrayService ArrayService { get; set; }
        protected LinkedListUtility LinkedListUtility { get; set; }
        protected ArrayUtility ArrayUtility { get; set; }
        protected GlobalUtility GlobalUtility { get; set; }

        protected int[][] matrix4by4 { get; set; }

        [SetUp]
        public virtual void BeforeEachTest()
        {
            LinkedListService = new LinkedListService();
            ArrayService = new ArrayService();

            LinkedListUtility = new LinkedListUtility();
            ArrayUtility = new ArrayUtility();
            GlobalUtility = new GlobalUtility();

            matrix4by4 = new int[4][];
            matrix4by4[0] = new int[] { 1, 2, 4, 6 };
            matrix4by4[1] = new int[] { 2, 4, 7, 8 };
            matrix4by4[2] = new int[] { 8, 9, 10, 11 };
            matrix4by4[3] = new int[] { 9, 12, 13, 15 };
        }
    }
}
