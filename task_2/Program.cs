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

int AskUser2()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    int op = int.Parse(Ask);
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
            arrayToFill[i,j] = i+j;
        }
    }
    return arrayToFill;
}

void PrintArray(int[,] arrayToPrint){
    for (int i = 0; i<arrayToPrint.GetLength(0); i++){
        Console.WriteLine();
        for (int j = 0; j<arrayToPrint.GetLength(1); j++){
            Console.Write(arrayToPrint[i,j]+ " ");
        }
    }
}

int [,] array = new int [AskUser(),AskUser()];
FillArray(array);
PrintArray(array);
