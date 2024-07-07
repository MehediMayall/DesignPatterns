namespace SequenceSortStrategy;

public class HeapSort : ISortStrategy
{
    public int[] Sort(int[] numbers)
    {
        return numbers.OrderBy(x=> x).ToArray();
    }
}