// See https://aka.ms/new-console-template for more information

var arr = new int[]{13, 19, 18, 4, 10};

foreach(var i in arr){
    Console.Write($"| {i} ");
}

SelectionSort(arr);
Console.WriteLine("\nSorting......");

foreach(var i in arr){
    Console.Write($"| {i} ");
}

static void SelectionSort(int[] arr){
    int key = 0;
    int min = int.MaxValue;
    int index = -1;

    for(int i = 0; i < arr.Count(); i++){
        key = arr[i]; 
        for(int j = i; j < arr.Count(); j++){
            if(min > arr[j]){
                min = arr[j]; 
                index = j;
            }
        }
        arr[i] = min; 
        arr[index] = key;
        min = int.MaxValue;
    }

}
