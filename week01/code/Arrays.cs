public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>

    //Problem 1: Function to generate an array of multiples of a given number
    public static double[] MultiplesOf(double number, int length) // function definition with parameters 'number' and 'length'
    {
        var result = new double[length]; // create an array of doubles with the specified length
        for (int i = 0; i < length; i++) // loop through each index of the array
        {
            result[i] = number * (i + 1); // calculate the multiple and assign it to the current index
        }

        return result; // return the filled array
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    
    //Problem 2: Function to rotate a list to the right by a specified amount
    public static void RotateListRight(List<int> data, int amount)
    {
        int sectionA_length = data.Count - amount; // Calculate the length of the first section
        List<int> sectionA = data.GetRange(0, sectionA_length); // Extract the first section
        List<int> sectionB = data.GetRange(sectionA_length, amount); // Extract the second section
        data.Clear(); // Clear the original list
        data.AddRange(sectionB); // Add the second section first
        data.AddRange(sectionA); // Add the first section next
        Console.WriteLine(data); // Print the modified list
    }
}
