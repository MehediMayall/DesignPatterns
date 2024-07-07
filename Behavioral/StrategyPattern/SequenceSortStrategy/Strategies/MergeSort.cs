namespace SequenceSortStrategy;

public class MergeSort : ISortStrategy
{
    public int[] Sort(int[] numbers)
    {
        return numbers.OrderBy(x=> x).ToArray();
    }
}