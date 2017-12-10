using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study.Services;
using Study.Services.Utility;

namespace Study.Application.DataStructures.LinkedLists
{
    public class SinglyLinkedListRepository : ISinglyLinkedListRepository
    {
        private readonly ILinkedListService _linkedListService;
        private readonly ILinkedListUtility _linkedListUtility;
        private readonly IGlobalUtility _globalUtility;

        public SinglyLinkedListRepository(ILinkedListService linkedListService,
                                          ILinkedListUtility linkedListUtility,
                                          IGlobalUtility globalUtility)
        {
            _linkedListService = linkedListService;
            _linkedListUtility = linkedListUtility;
            _globalUtility = globalUtility;
        }

        public void CheckSinglyLinkedListContainsCycle()
        {
            _globalUtility.OpeningProgramMessage("CheckSinglyLinkedListContainsCycle");

            var list = _linkedListService.GenerateSinglyLinkedList(3, 3);
            if (_linkedListService.SinglyLinkedListContainsCycle(list))
            {
                Console.WriteLine("Program worked");
            }
            else
            {
                Console.WriteLine("Program did not work");
            }

            _globalUtility.ClosingProgramMessage();
        }

        public void PrintElementsInSinglyLinkedList()
        {
            _globalUtility.OpeningProgramMessage("PrintElementsInSinglyLinkedList");

            var list = _linkedListService.GenerateSinglyLinkedList(5, 0);
            _linkedListService.TraverseSinglyLinkedList(list, _linkedListUtility.PrintNode);

            _globalUtility.ClosingProgramMessage();
        }
    }
}
