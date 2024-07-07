namespace SequenceSortStrategy;

public class RadixSort : ISortStrategy
{
    public int[] Sort(int[] numbers)
    {
        return numbers.OrderBy(x=> x).ToArray();
    }
}