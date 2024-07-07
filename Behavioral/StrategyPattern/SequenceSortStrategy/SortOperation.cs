namespace SequenceSortStrategy;
using static System.Console;


public class SortOperation(ISortStrategy sortStrategy)
{
    public void Sort(int[] numbers)
    {
        var sortedNumbers = sortStrategy.Sort(numbers);
        WriteLine($"================ {sortStrategy.GetType().Name.ToUpper()} ================");
        foreach(int item in sortedNumbers)
            Write(item.ToString().PadRight(4));

        WriteLine("\n");
    }   
}

