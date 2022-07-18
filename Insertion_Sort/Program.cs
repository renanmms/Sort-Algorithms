static void InsertionSort(List<int> arr){
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

var arr = new List<int>(5);

arr.Add(9);
arr.Add(5);
arr.Add(1);
arr.Add(4);
arr.Add(3);

foreach(var i in arr){
    Console.Write($" {i} |");

}

Console.WriteLine("\nSorting...");
InsertionSort(arr);

foreach(var i in arr){
    Console.Write($" {i} |");

}