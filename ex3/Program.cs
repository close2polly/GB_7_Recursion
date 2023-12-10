// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

int[] array = [1,2,3,4,5,6,4,2,4,5,2,1,4,5,8];


void Recursion(int[] arr, int index) {
    System.Console.WriteLine(arr[index]); 
    if (index != 0){
        Recursion(arr, index - 1);
    }
}


Recursion(array, array.Length - 1);