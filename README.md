# Описание программы:

## Что делает программа

Данная программа создает массив строк из элементов заданного массива строк, чья длина больше либо равна заданной длины. Размер и элементы первоначального массива вводятся пользователем через консоль. Максимальная длина элементов для выборки из первоначального массива задается пользователем в консоли.

## Программа построена на использовании следующих методов:

* _InputInt32(string message)_ - используется для ввода целого числа в консоли с пригласительным сообщением "messgae"
* _InputStringArrayConsole(int Size)_ - ввод массива строк размером "Size" через консоль
* _PrintArray_ - отоброжение массива строк в консоли
* _CountElementsRequiredLength(string[] array, int StringLength)_ - нахождение количества элементов в массиве строк "array" чья длина меньше либо равна "StringLength" * _CreateArrayStringRequiredLength(string[] array, int StringLength)_ - создание нового массива строк из элементов из массива "array", чья длина меньше либо равна заданной длине "StringLength"

## Краткое описание логики программы:
1. Пользователю предлагается задать размер массива и ввести все его элементы через консоль
2. Пользователю предлагается задать максимальный размер элемента для выборки
3. В заданном массиве, программа считает сколько есть элементов длинной равной или меньше заданной для выборки
4. Программа создает новый пустой массив с количеством элементов определенных на предыдущем шаге
5. программа методом перебора заданного массива отбирает элементы подходящей длины и отправляет их в массив, созданный на шаге 4
6. программа отображает новый массив в консоли

## Блок схема алгоритма метода 
[CreateArrayStringRequiredLength(string[] array, int StringLength)](https://disk.yandex.ru/i/VY5VRb54i0ciMg)