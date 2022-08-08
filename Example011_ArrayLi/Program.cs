void FillArray(int[] collection) // int[] collection - назвали так аргумент
{
   int Length = collection.Length;
   int index = 0;
   while (index < Length)   // цикл
   {
        collection[index] = new Random().Next(1, 10);
        index++;   // index = index +1
   }
}
                            // имя col -ч.б.различные аргументы назывались по-разному (Col, collection)
void PrintArray(int[] col)  // void - это метод, который не возвращает значения.
                            // тогда нельзя использовать return
{
    int count = col.Length;  // кол-во элементов обозначили
    int position = 0;  // позицию не через индекс, а через текущую позицию
    while (position < count)
    {
         Console.WriteLine(col[position]);
         position++;
    }

}

int[] arrey = new int[10]; // определяем массив с названием array
                             // указываем, что в массиве будет 10 эл-тов
                             // new int [10] означает "создай массив, в котором будет 10 эл-тов"
FillArray(array);
PrintArray(array);