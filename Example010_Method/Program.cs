﻿             // задача для любого количества элементов
         //     0   1   2   3  4  5    6   7  
//int[] array = { 1, 12, 31, 4, 15, 16, 17, 18 };

//int n = array.Length;    // что бы обратиться к массиву. А внутри есть информация, ск-ко эл-тов находится
                         // т.е. Length указывает длину или количество эл-тов массива
//int find = 18;  //пользователь вводит индекс эл-та массива

//nt index = 0;  // счетчик

//while (index < n)
//{

//    if (array[index] == find)
//    {
//       Console.WriteLine(index);
//    }

         // index = index + 1;
//    index++;
//}

// в этом варианте, если будет несколько одинаковых элементов, то нам покажут индексы их всех
// может это исправить. смотрим ниже:

           //   0   1   2  3   4  5   6    7   8
int[] array = { 1, 12, 31, 4, 15, 12, 16, 17, 18 };

int n = array.Length;    
                         
int find = 12;  

int index = 0;  

while (index < n)
{

    if (array[index] == find)
    {
       Console.WriteLine(index);
       break;   // "прерви". Это если несколько элементов одинаковых, а показать надо первый, к-й найдет
    }

        index++;
}