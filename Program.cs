// See https://aka.ms/new-console-template for more information

string aux;
int opcion;
do
{

    double resultado;
    int decision;
    Console.WriteLine("Seleccione la operacion que quiera hacer:");
    Console.WriteLine("[5] Valor absoluto:");
    Console.WriteLine("[6] El cuadrado de un numero:");
    Console.WriteLine("[7] Raiz cuadrada:");
    Console.WriteLine("[8] El seno de un angulo:");
    Console.WriteLine("[9] El coseno de un angulo");
    Console.WriteLine("[10] Parte entera de un tipo float");
    aux = Console.ReadLine();
    if (int.TryParse(aux, out opcion) == false)
    {
        Console.WriteLine("Ingrese una opcion valida");
        opcion = 10;
    }
    switch (opcion)
    {
        case 5:
            do
            {
                string auxiliar1, auxiliar3;
                Console.WriteLine("Ingrese el numero que quiere saber el valor absoluto");
                auxiliar1 = Console.ReadLine();
                int num1;

                if (int.TryParse(auxiliar1, out num1) != false)
                {
                    if (num1 < 0)
                    {
                        resultado = num1 * -1;
                        Console.WriteLine("El valor absoluto del numero es: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("El valor absoluto del numero es: " + num1);
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese numeros validos");
                }
                Console.WriteLine("Desea realizar otra operacion Ingrese 1 para si y ingrese 2 para No");
                auxiliar3 = Console.ReadLine();
                if (int.TryParse(auxiliar3, out decision) == false)
                {
                    Console.WriteLine("Ingrese una decision valida");
                    decision = 0;
                }

            } while (decision != 2);
            break;
        case 6:
            do
            {
                string auxiliar1, auxiliar3;
                Console.WriteLine("Ingrese un numeros");
                auxiliar1 = Console.ReadLine();

                int num1;
                if (int.TryParse(auxiliar1, out num1) != false)
                {
                    resultado = num1 * num1;
                    Console.WriteLine("El cuadrado del numero es: " + resultado);
                }
                else
                {
                    Console.WriteLine("Ingrese numeros validos");
                }

                Console.WriteLine("Desea realizar otra operacion Ingrese 1 para si y ingrese 2 para No");
                auxiliar3 = Console.ReadLine();
                if (int.TryParse(auxiliar3, out decision) == false)
                {
                    Console.WriteLine("Ingrese una decision valida");
                    decision = 0;
                }

            } while (decision != 2);
            break;
        case 7:
            do
            {
                string auxiliar1, auxiliar3;
                Console.WriteLine("Ingrese un numero");
                auxiliar1 = Console.ReadLine();
                int num1;
                if (int.TryParse(auxiliar1, out num1) != false)
                {
                    resultado = Math.Sqrt(num1);
                    Console.WriteLine("El resultado de la raiz cuadrada es: " + resultado);
                }
                else
                {
                    Console.WriteLine("Ingrese numeros validos");
                }

                Console.WriteLine("Desea realizar otra operacion Ingrese 1 para si y ingrese 2 para No");
                auxiliar3 = Console.ReadLine();
                if (int.TryParse(auxiliar3, out decision) == false)
                {
                    Console.WriteLine("Ingrese una decision valida");
                    decision = 0;
                }

            } while (decision != 2);
            break;

        case 8:
            do
            {
                string auxiliar1, auxiliar3;
                Console.WriteLine("Ingrese el angulo");
                auxiliar1 = Console.ReadLine();
                int num1;
                if (int.TryParse(auxiliar1, out num1) != false)
                {
                    resultado = Math.Sin(num1);
                    Console.WriteLine("El valor del seno es: " + resultado);
                }
                else
                {
                    Console.WriteLine("Ingrese un numero valido");
                }
                Console.WriteLine("Desea realizar otra operacion Ingrese 1 para si y ingrese 2 para No");
                auxiliar3 = Console.ReadLine();
                if (int.TryParse(auxiliar3, out decision) == false)
                {
                    Console.WriteLine("Ingrese una decision valida");
                    decision = 0;
                }
            } while (decision != 2);
            break;
        case 9:
            do
            {
                string auxiliar1, auxiliar3;
                Console.WriteLine("Ingrese el angulo");
                auxiliar1 = Console.ReadLine();
                
                int num1;
                if (int.TryParse(auxiliar1, out num1) != false)
                {
                    resultado = Math.Cos(num1);
                    Console.WriteLine("El valor del coseno es:" + resultado);
                }
                else
                {
                    Console.WriteLine("Ingrese numeros validos");
                }

                Console.WriteLine("Desea realizar otra operacion Ingrese 1 para si y ingrese 2 para No");
                auxiliar3 = Console.ReadLine();
                if (int.TryParse(auxiliar3, out decision) == false)
                {
                    Console.WriteLine("Ingrese una decision valida");
                    decision = 0;
                }

            } while (decision != 2);
            break;
             case 10:
            do
            {
                string auxiliar1, auxiliar2, auxiliar3;
                Console.WriteLine("Ingrese dos numeros");
                auxiliar1 = Console.ReadLine();
                auxiliar2 = Console.ReadLine();
                int num1, num2;
                if (int.TryParse(auxiliar1, out num1) != false && int.TryParse(auxiliar2, out num2) != false)
                {
                    resultado = num1 * num2;
                    Console.WriteLine("El resultado de la multiplicacion es:" + resultado);
                }
                else
                {
                    Console.WriteLine("Ingrese numeros validos");
                }

                Console.WriteLine("Desea realizar otra operacion Ingrese 1 para si y ingrese 2 para No");
                auxiliar3 = Console.ReadLine();
                if (int.TryParse(auxiliar3, out decision) == false)
                {
                    Console.WriteLine("Ingrese una decision valida");
                    decision = 0;
                }

            } while (decision != 2);
             break;
    }
       
} while (opcion != 0);
