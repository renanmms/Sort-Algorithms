// See https://aka.ms/new-console-template for more information

var arr = new int[]{19, 1, 9, 7, 3, 10, 13, 15, 8, 12};

foreach(var i in arr){
    Console.Write($"| {i} ");
}

BubbleSort(arr);

Console.WriteLine("\n Sorting......");

foreach(var i in arr){
    Console.Write($"| {i} ");
}

static void BubbleSort(int[] arr){
    int temp = 0;
    for(int i = 0; i < arr.Count() - 1; i++){
        for(int j = 0; j < arr.Count() - (i + 1); j++){
            if(arr[j] > arr[j+1]){ 
                temp = arr[j+1]; 
                arr[j+1] = arr[j];
                arr[j] = temp;
            }
        }
    }    
}
