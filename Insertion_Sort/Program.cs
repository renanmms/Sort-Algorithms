static void InsertionSort(int[] arr){
    int key = 0;
    int size = arr.Count();
    int j = 0;

    for(int i = 1; i < size ; i++){ 
        key = arr[i]; 
        for(j = i; j > 0 && key < arr[j - 1]; j--){ 
            arr[j] = arr[j - 1]; 
        }
        arr[j] = key; 
    }
}

var arr = new int[]{9, 8, 1, 5, 6};

foreach(var i in arr){
    Console.Write($" {i} |");

}

Console.WriteLine("\nSorting...");
InsertionSort(arr);

foreach(var i in arr){
    Console.Write($" {i} |");

}