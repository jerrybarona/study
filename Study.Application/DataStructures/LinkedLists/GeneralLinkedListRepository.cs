using Study.Services;
using Study.Services.Utility;


namespace Study.Application.DataStructures.LinkedLists
{
    public class GeneralLinkedListRepository : IGeneralLinkedListRepository
    {
        private readonly ILinkedListService _linkedListService;
        private readonly ILinkedListUtility _linkedListUtility;
        private readonly IGlobalUtility _globalUtility;

        public GeneralLinkedListRepository(ILinkedListService linkedListService,
                                           ILinkedListUtility linkedListUtility,
                                           IGlobalUtility globalUtility)
        {
            _linkedListService = linkedListService;
            _linkedListUtility = linkedListUtility;
            _globalUtility = globalUtility;
        }
        public void GenerateLinkedListFrom2DArray()
        {
            _globalUtility.OpeningProgramMessage("GenerateLinkedListFrom2DArray");

            int[][] arr = new int[3][];
            arr[0] = new int[] { 1, 4, 7 };
            arr[1] = new int[] { 2, 5, 8 };
            arr[2] = new int[] { 3, 6, 9 };

            var head = _linkedListService.GenerateLinkedListFrom2DMatrix(arr, 3, 3, 0, 0);
            _linkedListService.TraverseMatrixLinkList(head, _linkedListUtility.PrintNodeValue);

            _globalUtility.ClosingProgramMessage();
        }
    }
}
