int AskUser()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    int op = int.Parse(Ask);
    if (op>0) return op;
    else {
        Console.WriteLine("Введите число > 0!");
        return AskUser();
    };
}
catch (Exception)
{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}
else{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}

double AskUser2()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    double op = double.Parse(Ask);
    return op;
}
catch (Exception)
{
    Console.WriteLine("Введите верное число!");
    return AskUser2();
}
}
else{
    Console.WriteLine("Введите верное число!");
    return AskUser2();
}
}

int [,] FillArray(int[,] arrayToFill){
    for (int i = 0; i<arrayToFill.GetLength(0); i++){
        for (int j = 0; j<arrayToFill.GetLength(1); j++){
            arrayToFill[i,j] = new Random().Next(-1000,1000);
        }
    }
    return arrayToFill;
}

void Print2DimentionalArray(int[,] arrayToPrint){
    for (int i = 0; i<arrayToPrint.GetLength(0); i++){
        Console.WriteLine();
        for (int j = 0; j<arrayToPrint.GetLength(1); j++){
            Console.Write(arrayToPrint[i,j]+ " ");
        }
    }
Console.WriteLine();
}

void PrintArray(double[] arrayToPrint){
    for (int i = 0; i<arrayToPrint.Length; i++){
        Console.Write(arrayToPrint[i]+ " ");
    }
Console.WriteLine();
}

double [] GetAverageByColumn(int[,] arrayToGetAverage){
    double [] avgByColumns = new double [arrayToGetAverage.GetLength(0)];
    for(int i = 0; i < arrayToGetAverage.GetLength(0); i++){
        for(int j = 0; j < arrayToGetAverage.GetLength(1); j++){
            avgByColumns[i] += Convert.ToDouble(arrayToGetAverage[i,j]);
        }
        avgByColumns[i] /= arrayToGetAverage.GetLength(1);
    }
    return avgByColumns;
}

int [,] array = new int [AskUser(),AskUser()];
FillArray(array);
Print2DimentionalArray(array);
Console.WriteLine();
Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArray(GetAverageByColumn(array));