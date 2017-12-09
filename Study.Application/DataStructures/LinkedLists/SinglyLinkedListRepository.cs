﻿using System;
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

        public SinglyLinkedListRepository(ILinkedListService linkedListService,
                                          ILinkedListUtility linkedListUtility)
        {
            _linkedListService = linkedListService;
            _linkedListUtility = linkedListUtility;
        }

        public void CheckSinglyLinkedListContainsCycle()
        {
            Console.WriteLine("Running CheckSinglyLinkedListContainsCycle program...");
            var list = _linkedListService.GenerateSinglyLinkedList(3, 3);
            if (_linkedListService.SinglyLinkedListContainsCycle(list))
            {
                Console.WriteLine("Program worked");
            }
            else
            {
                Console.WriteLine("Program did not work");
            }
            Console.ReadLine();
        }

        public void PrintElementsInSinglyLinkedList()
        {
            Console.WriteLine("Running PrintElementsInSinglyLinkedList program...");
            var list = _linkedListService.GenerateSinglyLinkedList(5, 0);
            _linkedListService.TraverseSinglyLinkedList(list, _linkedListUtility.PrintNode);
            Console.ReadLine();
        }
    }
}
