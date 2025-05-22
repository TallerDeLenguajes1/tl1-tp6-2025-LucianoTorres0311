// See https://aka.ms/new-console-template for more information
int opcion;
do
{
    
    int resultado;
    int decision;
    Console.WriteLine("Seleccione la operacion que quiera hacer:");
    Console.WriteLine("[1] Suma de los numeros:");
    Console.WriteLine("[2] Resta de los numeros:");
    Console.WriteLine("[3] Multiplicacion de los numeros:");
    Console.WriteLine("[4] Division de los numeros:");
    Console.WriteLine("[5] salir");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            do
            {
                Console.WriteLine("Ingrese dos numeros");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                resultado = num1 + num2;
                Console.WriteLine("El resultado es:" + resultado);
                Console.WriteLine("Desea realizar otra operacion? Ingrese 1 para si y ingrese 2 para No");
                decision = int.Parse(Console.ReadLine());
            } while (decision != 2);

            break;
        case 2:
            do
            {
                Console.WriteLine("Ingrese dos numeros");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                resultado = num1 - num2;
                Console.WriteLine("El resultado es:" + resultado);
                Console.WriteLine("Desea realizar otra operacion? Ingrese 1 para si y ingrese 2 para No");
                decision = int.Parse(Console.ReadLine());
                if (decision == 2)
                {
                    opcion = 5;
                }
            } while (decision != 2);

            break;
        case 3:
            do
            {
                Console.WriteLine("Ingrese dos numeros");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                resultado = num1 * num2;
                Console.WriteLine("El resultado es:" + resultado);
                Console.WriteLine("Desea realizar otra operacion? Ingrese 1 para si y ingrese 2 para No");
                decision = int.Parse(Console.ReadLine());
                if (decision == 2)
                {
                    opcion = 5;
                }
            } while (decision != 2);

            break;
             case 4:
            do
            {
                Console.WriteLine("Ingrese dos numeros");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                resultado = num1 / num2;
                Console.WriteLine("El resultado es:" + resultado);
                Console.WriteLine("Desea realizar otro calculo? Ingrese 1 para si y ingrese 2 para No");
                decision = int.Parse(Console.ReadLine());
            } while (decision != 2);

            break;


    }
    
} while (opcion != 5);
