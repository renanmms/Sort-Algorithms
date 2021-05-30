#include <iostream>
#include <algorithm>
#include <vector>

int main()
{
    std::vector<int> v(6);
    v = {6, 4, 3, 2, 1, 9};

    std::stable_sort(v.begin(), v.end());

    for(int i: v)
    {
        std::cout << i << " " ;
    }


}