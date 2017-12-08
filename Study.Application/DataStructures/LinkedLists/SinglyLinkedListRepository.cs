using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study.Services;

namespace Study.Application.DataStructures.LinkedLists
{
    public class SinglyLinkedListRepository
    {
        private readonly ILinkedListService _singlyLinkedListService;

        public SinglyLinkedListRepository(ILinkedListService singlyLinkedListService)
        {
            _singlyLinkedListService = singlyLinkedListService;
        } 
    }
}
