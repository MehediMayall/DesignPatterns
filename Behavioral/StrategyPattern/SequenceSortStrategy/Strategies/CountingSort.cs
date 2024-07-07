namespace SequenceSortStrategy;

public class CountingSort : ISortStrategy
{
    public int[] Sort(int[] numbers)
    {
        return numbers.OrderBy(x=> x).ToArray();
    }
}