using SequenceSortStrategy;

int[] nums = [3,19,49,58,29,69,99,0,1,33];


// Selection
new SortOperation(new SelectionSort()).Sort(nums);

// Bubble
new SortOperation(new BubbleSort()).Sort(nums);

// Merge
new SortOperation(new MergeSort()).Sort(nums);

// Insertion
new SortOperation(new InsertionSort()).Sort(nums);
