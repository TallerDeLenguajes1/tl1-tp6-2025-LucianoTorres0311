// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("Valor de a:"+a);
Console.WriteLine("Valor de b:" +b);
string numInvertir;
Console.WriteLine("Ingrese un numero");
numInvertir = Console.ReadLine();
int longitudCadena;
longitudCadena = numInvertir.Length;
int aux;
if (int.TryParse(numInvertir, out aux))
{
    if (aux > 0)
    {
        string auxiliar = "";
        for (int i = longitudCadena - 1; i >= 0; i--)
        {
            auxiliar += numInvertir[i];
        }
        Console.WriteLine("El numero es:" + aux);
        Console.WriteLine("El numero invertido es:" + auxiliar);
    }
    else
    {
        Console.WriteLine("El numero debe ser mayor a 0");
    }
}
else
{
    Console.WriteLine("No ingreso un numero");
}
