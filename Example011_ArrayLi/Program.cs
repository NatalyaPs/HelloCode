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

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //сначала было =0. но -1 покажет, если нет такой позиции

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] arrey = new int[10]; // определяем массив с названием array
                             // указываем, что в массиве будет 10 эл-тов
                             // new int [10] означает "создай массив, в котором будет 10 эл-тов"
FillArray(array);  // заполнили масив
//array[4] = 4;  принудительно добавляем четверки, ч.б. проверить. Покажет все четверки и внизу выделит первую позицию, где 4
//array[6] = 4;
PrintArray(array);  // распечатали массив
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);