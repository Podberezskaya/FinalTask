Задача: 

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 

Алгоритм решения:

Объявляем два массива: первый и второй одинаковой длины. Потом метод, в котором цикл, внутри цикла проверка условия ( <=3 (больше либо равно трем)), если да, то элемент первого массива заносится в count элемент второго массива. После присвоения увеличивается переменная count на 1 и возвращаемся к циклу for в котором i увеличивается на 1. И так проверяется до конца.