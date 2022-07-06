#include <iostream>
#include <algorithm>
#include <vector>
#include <iomanip>
#include <chrono>

int main()
{
    // Declaring a vector int of 6 positions
    std::vector<int> v(12);
    v = {6, 4, 3, 2, 1, 9, 0, -2 , 100, 75, 90, 32};

    // Counting the elapsed time of the sort algorithm
    auto start = std::chrono::steady_clock::now();
    std::stable_sort(v.begin(), v.end());
    auto end = std::chrono::steady_clock::now();
    std::chrono::duration<double> elapsed_seconds = end-start;

    // Print values inside the vector
    for(int i: v)
    {
        std::cout << i << " " ;
    }

    std::cout << std::fixed;
    std::cout << std::endl << "Elapsed Time of Stable Sort: " << elapsed_seconds.count() << std::endl;


}