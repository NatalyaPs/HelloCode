int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//               0   1   2   3  4    5   6   7   8    индекс элементов массива
int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };
//array[0] = 12;   // присвоили нулевому элементу массива значение 12
//Console.WriteLine(array[0]);   //как обратиться к массиву и получить значение соответсв-го эл-та (с индексом 0, н-р)


int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
    );

Console.WriteLine(max);

// функция Max - с большой буквы, 
// а переменная max - с маленькой
// или можно max заменить на resalt в 15 и 21 строках