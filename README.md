# Кафе
### Функциональные требования
Кафе (Cafe) должно иметь несколько видов меню для каждого приема пищи:
<table>
    <tr>
        <th></th>
        <th>Main</th>
        <th>Salad</th>
        <th>Dessert</th>
        <th>Drink</th>
    </tr>
    <tr>
        <th>Breakfast</th>
        <td>Porridge</td>
        <td>Eggs</td>
        <td>Pancake</td>
        <td>Coffee</td>
    </tr>
    <tr>
        <th>Lunch</th>
        <td>Pasta</td>
        <td>Vegies</td>
        <td>Biscuit</td>
        <td>Compote</td>
    </tr>
    <tr>
        <th>Supper</th>
        <td>Yogurt</td>
        <td>Fruit</td>
        <td>Cake</td>
        <td>Tea</td>
    </tr>
</table>

Реализовать решение, позволяющее клиенту (Cafe) одновременно работать только с блюдами
одного подменю в зависимости от времени дня.

### Нефункциональные требования:
1. Платформа: Консольное приложение для OS Windows.
2. Язык реализации: C# / Java / C++.

### Реализация
#### Ввод
В аргументы командной строки ввести одно из следующих значений:
* Breakfast
* Lunch
* Supper

Пример:

```bash
$ /path/to/Cafe.exe Breafast
```

#### Вывод 
Меню, построенное на основе выбранного времени приема пищи.

Пример:

```
Menu for Breakfast:

Main: Porridge
Salad: Eggs 
Dessert: Pancake
Drink: Coffee
```