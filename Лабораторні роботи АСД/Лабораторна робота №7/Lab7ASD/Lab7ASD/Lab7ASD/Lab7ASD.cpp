
#include <iostream>
using namespace std;
void fill_arr(char[], char[], int);
void display_arr(char[], int);
void fill_third_arr(char[], char[], char[], int);
int find_max_code(char[], int);
int find_min_code(char[], int);
int main()
{
    const int n = 10;
    char arr1[n];
    char arr2[n];
    char arr3[n]{};
    int sum, min_code, max_code;
    fill_arr(arr1, arr2, n);
    cout << "Array 1:" << endl;
    display_arr(arr1, n);
    cout << "Array 2:" << endl;
    display_arr(arr2, n);
    fill_third_arr(arr1, arr2, arr3, n);
    cout << "Array 3:" << endl;
    display_arr(arr3, n);
    min_code = find_min_code(arr3, n);
    max_code = find_max_code(arr3, n);
    cout << "Min code is: " << min_code << '\n' << "Max code is: " << max_code << endl;
    sum = min_code + max_code;
    cout << "Sum: " << sum << endl;
    return 0;
}
void fill_arr(char arr1[], char arr2[], int size)
{
    for (int i = 0; i < size; i++)
    {
        arr1[i] = 62 + 3 * i;
        arr2[i] = 74 - i;
    }
}

void display_arr(char arr[], int size) 
{
    for (int i = 0; i < size; i++)
    {
        cout << arr[i] << " ";
    }
    cout << endl;
}

void fill_third_arr(char arr_a[], char arr_b[], char arr3[], int size) 
{
    int k = 0;
    for (int i = 0; i < size; i++) 
    {
        for (int j = 0; j < size; j++) 
        {
            if (arr_a[i] == arr_b[j]) 
            {
                arr3[k] = arr_a[i];
                k++;
            }
        }
    }
}

int find_min_code(char arr[], int size)
{
    int i = 1;
    int prev_code = (int)arr[0];
    while ((int)arr[i] != 0 && i < size) 
    {
        if ((int)arr[i] < prev_code) 
        {
            prev_code = (int)arr[i];
        }
        i++;
    }
    return prev_code;
}

int find_max_code(char arr[], int size)
{
    int i = 1;
    int prev_code = (int)arr[0];
    while ((int)arr[i] != 0 && i < size)
    {
        if ((int)arr[i] > prev_code)
        {
            prev_code = (int)arr[i];
        }
        i++;
    }
    return prev_code;
}
