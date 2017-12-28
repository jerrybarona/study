namespace Study.Services
{
    public interface IStackService
    {
        bool GenerateStackFromArray(object[] arr);
        /// <summary>
        /// From Bloomberg 
        /// </summary>
        /// <param name="arr">char array</param>
        /// <returns>True if all braces are matched up</returns>
        bool CheckForBalancedBraces(object[] arr);
    }
}
