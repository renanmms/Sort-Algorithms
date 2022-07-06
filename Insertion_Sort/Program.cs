// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

static int InsertionSort(List<int> arr){

    bool isUnsorted = false;
    int index = 0;
    for(int i = 0; i < arr.Count - 1; i++){

        if(arr[i] > arr[i + 1]){
            isUnsorted = true;
            index = i;
            return index;
        }
    }

    return 1;
}

var arr = new List<int>(5);

arr.Add(7);
arr.Add(8);
arr.Add(5);
arr.Add(2);
arr.Add(4);

foreach(var i in arr){
    Console.Write($"{i} ");

}

Console.WriteLine($"\n\nThe array is unsorted in the {InsertionSort(arr)}th position");

// static void InsertionSort(int[] arr){



    
// }