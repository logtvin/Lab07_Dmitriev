//1 задание

//string[] days = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};

//for (int i = days.Length - 1; i >= 0; i--) {
//    Console.WriteLine($"{i}: {days[i]}");
//}

//2-3 задание

//int[] prices = {120, 45, 300, 80, 15, 210};
//int sum = 0;
//int collect = 0;
//int min = prices[0];
//int max = prices[0];
//int index = 0;

//for (int i = 1; i < prices.Length; i++) {
//    if (prices[i] > max) {
//        max = prices[i];
//    }
//    if (prices[i] < min) {
//        min = prices[i];
//        index += 1;
//    }
//}

//foreach (int pri in prices) {
//    sum += pri;
//    if (pri > 100) {
//        collect += 1;
//    }
//}

//double average = (double)sum / prices.Length;
//Console.WriteLine($"Сумма: {sum}, среднее: {average:F2}, кол-во товаров больше 100: {collect}. Минимум: {min}, самый дорогой: {index}");

// 4 задание

//int[] balance = {100, -50, 20, -5, 0, 75};
//for (int i = 0; i < balance.Length; i++) 
//{
//    if (balance[i] < 0) 
//    {
//        balance[i] = 0;
//    }
//}

//Console.WriteLine("Измененный:");
//foreach (int cofe in balance) 
//{
//   Console.Write(cofe + " "); 
//}

// 5 задание
int[] numb = (new int[5]);
int collect = 0;
for (int i = 1; i < numb.Length; i++) {
    numb[i] = Convert.ToInt32(Console.ReadLine());

}
for (int j = days.Length - 1; j >= 0; j--) {
    Console.WriteLine($"{j}: {numb[j]}");
}
foreach(int n in numb) {
    if (n % 2 == 0) {
        collect +=1;
    }
}