// See https://aka.ms/new-console-template for more information

var array = new int[]{14, 7, 3, 12, 9, 11, 6, 2};

DisplayArray(array);

void MergeSort(int[] array){
    int p = 0;
    int r = 0;
    int q = (p+r)/2;
}

void DisplayArray(int[] array){
    foreach(var element in array){
        Console.Write($"{element} ");
    }

    Console.WriteLine();
}
