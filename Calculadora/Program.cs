using Calculadora.Services;

CalculadoraImp calculadoraImp = new CalculadoraImp("03/06/2024");

int num1 = 2;
int num2 = 3;

Console.WriteLine($"Total da soma {num1} + {num2} = {calculadoraImp.Somar(num1,num2)}");