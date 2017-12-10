using System;

namespace Study.Services.Utility
{
    public class GlobalUtility : IGlobalUtility
    {
        public void ClosingProgramMessage()
        {
            Console.WriteLine("\n\nPress [ENTER] to exit...");
            Console.ReadLine();
        }

        public void OpeningProgramMessage(string methodName = "")
        {
            Console.WriteLine("Running " + methodName + " program\n");
        }

        public void PrintLineSeparator(int size = 0)
        {
            while (size-- > 0)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
