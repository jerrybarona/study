using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study.Services;
using Study.Services.Utility;

namespace Study.Application.DataStructures.Arrays
{
    public class ArrayRepository : IArrayRepository
    {
        private readonly IArrayService _arrayService;
        private readonly IArrayUtility _arrayUtility;
        private readonly IGlobalUtility _globalUtility;

        public ArrayRepository(IArrayService arrayService,
                               IArrayUtility arrayUtility,
                               IGlobalUtility globalUtility)
        {
            _arrayService = arrayService;
            _arrayUtility = arrayUtility;
            _globalUtility = globalUtility;
        }
        public void FindNumberInSorted2DMatrix()
        {
            _globalUtility.OpeningProgramMessage("FindNumberInSorted2DMatrix");

            int[][] arr = new int[4][];
                arr[0] = new int[] { 1, 2, 4, 6 };
                arr[1] = new int[] { 2, 4, 7, 8 };
                arr[2] = new int[] { 8, 9, 10, 11 };
                arr[3] = new int[] { 9, 12, 13, 15 };
            int numberToFind = 7;

            _arrayUtility.PrintMatrix(arr);

            if (_arrayService.FindInSorted2DMatrix(arr, numberToFind))
            {
                Console.WriteLine("Number to find " + numberToFind + " was found in matrix.");
            }
            else
            {
                Console.WriteLine("Number to find " + numberToFind + " was not found in matrix.");
            }

            _globalUtility.ClosingProgramMessage();
        }
    }
}
