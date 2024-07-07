namespace SequenceSortStrategy;

public class QuickSort : ISortStrategy
{
    public int[] Sort(int[] numbers)
    {
        return numbers.OrderBy(x=> x).ToArray();
    }
}