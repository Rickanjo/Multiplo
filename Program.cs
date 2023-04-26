// Determine se um número é múltiplo de outro.
Console.WriteLine("--- Multiplos ---");

Console.Write("Digite o primeiro Número....:");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Digite o segundo Número.....:");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 % num2 == 0) {
    Console.WriteLine($"{num1} é múltiplo de {num2}");
}
else {
    Console.WriteLine($"{num1} não é múltiplo de {num2}");
}


