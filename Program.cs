// See https://aka.ms/new-console-template for more information
string? aux;
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
    aux = Console.ReadLine();
    if (aux == null)
    {
        Console.WriteLine("Ingrese una opcion valida");
        opcion = 0;
    }
    else
    {
        int.TryParse(aux, out opcion);
    }

    switch (opcion)
    {
        case 1:
            do
            {
                string? auxiliar1, auxiliar2, auxiliar3;
                Console.WriteLine("Ingrese dos numeros");
                auxiliar1 = Console.ReadLine();
                auxiliar2 = Console.ReadLine();
                int num1, num2;
                if (auxiliar1 == null || auxiliar2 == null)
                {
                    Console.WriteLine("Ingrese numeros validos");
                }
                else
                {
                    if (int.TryParse(auxiliar1, out num1) != false && int.TryParse(auxiliar2, out num2) != false)
                    {
                        resultado = num1 + num2;
                        Console.WriteLine("El resultado de la suma es:" + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Ingrese numeros validos");
                    }
                }
                Console.WriteLine("Desea realizar otra operacion? Ingrese 1 para si y ingrese 2 para No");
                auxiliar3 = Console.ReadLine();
                if (auxiliar3 == null)
                {
                    Console.WriteLine("Ingrese una decision valida");
                    decision = 0;
                }
                else
                {
                    if (int.TryParse(auxiliar3, out decision) == false)
                    {
                        Console.WriteLine("Ingrese una decision valida");
                        decision = 0;
                    }
                }
            } while (decision != 2);
            break;
        case 2:
            do
            {
                string? auxiliar1, auxiliar2, auxiliar3;
                Console.WriteLine("Ingrese dos numeros");
                auxiliar1 = Console.ReadLine();
                auxiliar2 = Console.ReadLine();
                int num1, num2;
                if (auxiliar1 == null || auxiliar2 == null)
                {
                    Console.WriteLine("Ingrese numeros validos");
                }
                else
                {
                    if (int.TryParse(auxiliar1, out num1) != false && int.TryParse(auxiliar2, out num2) != false)
                    {
                        resultado = num1 - num2;
                        Console.WriteLine("El resultado de la resta es:" + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Ingrese numeros validos");
                    }
                }
                Console.WriteLine("Desea realizar otra operacion? Ingrese 1 para si y ingrese 2 para No");
                auxiliar3 = Console.ReadLine();
                if (auxiliar3 == null)
                {
                    Console.WriteLine("Ingrese una decision valida");
                    decision = 0;
                }
                else
                {
                    if (int.TryParse(auxiliar3, out decision) == false)
                    {
                        Console.WriteLine("Ingrese una decision valida");
                        decision = 0;
                    }
                }
            } while (decision != 2);
            break;
        case 3:
            do
            {
                string? auxiliar1, auxiliar2, auxiliar3;
                Console.WriteLine("Ingrese dos numeros");
                auxiliar1 = Console.ReadLine();
                auxiliar2 = Console.ReadLine();
                int num1, num2;
                if (auxiliar1 == null || auxiliar2 == null)
                {
                    Console.WriteLine("Ingrese numeros validos");
                }
                else
                {
                    if (int.TryParse(auxiliar1, out num1) != false && int.TryParse(auxiliar2, out num2) != false)
                    {
                        resultado = num1 * num2;
                        Console.WriteLine("El resultado de la multiplicacion es:" + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Ingrese numeros validos");
                    }
                }
                Console.WriteLine("Desea realizar otra operacion? Ingrese 1 para si y ingrese 2 para No");
                auxiliar3 = Console.ReadLine();
                if (auxiliar3 == null)
                {
                    Console.WriteLine("Ingrese una decision valida");
                    decision = 0;
                }
                else
                {
                    if (int.TryParse(auxiliar3, out decision) == false)
                    {
                        Console.WriteLine("Ingrese una decision valida");
                        decision = 0;
                    }
                }
            } while (decision != 2);
            break;

        case 4:
            do
            {
                string? auxiliar1, auxiliar2, auxiliar3;
                Console.WriteLine("Ingrese dos numeros");
                auxiliar1 = Console.ReadLine();
                auxiliar2 = Console.ReadLine();
                int num1, num2;
                if (auxiliar1 == null || auxiliar2 == null)
                {
                    Console.WriteLine("Ingrese numeros validos");
                }
                else
                {
                    if (int.TryParse(auxiliar1, out num1) != false && int.TryParse(auxiliar2, out num2) != false)
                    {
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("El resultado de la division es:" + resultado);
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir por 0");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese numeros validos");
                    }
                }
                Console.WriteLine("Desea realizar otra operacion? Ingrese 1 para si y ingrese 2 para No");
                auxiliar3 = Console.ReadLine();
                if (auxiliar3 == null)
                {
                    Console.WriteLine("Ingrese una decision valida");
                    decision = 0;
                }
                else
                {
                    if (int.TryParse(auxiliar3, out decision) == false)
                    {
                        Console.WriteLine("Ingrese una decision valida");
                        decision = 0;
                    }

                }
            } while (decision != 2);
             break;
    }
} while (opcion != 5);
