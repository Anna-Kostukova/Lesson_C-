﻿// Допустим, у нас есть массив array, в котором n элементов. Найдём элемент, совпадающий с
// некоторым значением, который определяет пользователей.
// 1. Сохраним его в переменную find. Затем установим счётчик в нулевую позицию.
// 2. Если на текущей позиции элемент совпал с find, операцию можно завершить, потому
// что мы нашли позицию.
// 3. Если элемент не совпал с find, увеличиваем значение счётчика index на 1 и переходим
// на предыдущий шаг.
// 4. Сравниваем снова. И если элемент совпал с find, значит, алгоритм закончил работу.
// 5. Если элемент совпал с find, снова увеличиваем индекс. Смотрим результат.
// 6. В результате если элемент находится, операция завершается успешно. А если этого
// элемента так и нет, надо сообщить об этом.

int[] array = {1,2,3,4,5,6,9,78};

int n =array.Length; //  n = длина или кол-во эл-тов в массиве
int find = 9; // необходимо найти индекс значения 9

int index = 0; 

while(index < n)
{
    if (array[index] == find) // если значение находится
    {
        Console.WriteLine(index); // выводим на консоль индекс этого значения
        break; // находим первый элемент и завершаем работу
    }
    index++;
}
