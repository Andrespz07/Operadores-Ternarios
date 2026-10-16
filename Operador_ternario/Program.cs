using System;

namespace Operador_ternario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal exchangeRate = 1.16m; // 1 EUR = 1.16 USD

            Console.WriteLine("--- CONVERSOR DE DIVISAS ---");
            Console.WriteLine("1. De Euros (€) a Dólares ($)");
            Console.WriteLine("2. De Dólares ($) a Euros (€)");
            Console.Write("Elige una opción (1 o 2): ");

            string option = Console.ReadLine();

            Console.Write("Introduce la cantidad a convertir: ");
            decimal quantity = decimal.Parse(Console.ReadLine());

            // Usamos el operador ternario para definir la dirección de la conversión y el mensaje
            decimal result = (option == "1") ? quantity * exchangeRate : quantity / exchangeRate;
            string originalCurrency = (option == "1") ? "€" : "$";
            string targetCurrency = (option == "1") ? "$" : "€";

            // Mostramos el resultado formateado
            Console.WriteLine($"\nResultado: {quantity} {originalCurrency} equivalen a {result :F2} {targetCurrency}");





            //Calculadora de peso de una persona en diferentes planetas

            //Console.WriteLine("Dime tu peso en kg");
            //decimal pesoUsuario = decimal.Parse(Console.ReadLine());

            //const decimal mercurio = 0.38m;
            //const decimal venus = 0.93m;
            //const decimal marte = 0.37m;

            //Console.WriteLine("Elige un planeta para calcular tu peso:");
            //Console.WriteLine("1. Mercurio, 2. Venus, 3. Marte");
            //string opcionPlaneta = Console.ReadLine();

            //decimal pesoPlaneta = (opcionPlaneta == "1") ? pesoUsuario * mercurio :
            //                      (opcionPlaneta == "2") ? pesoUsuario * venus : pesoUsuario * marte;
            //                      (opcionPlaneta == "3") ? pesoUsuario * marte; // Default case if input is invalid

            //Console.WriteLine($"\nTu peso en {opcionPlaneta} es: {pesoPlaneta:F2} kg");






            // Calculadora de peso de una persona en diferentes planetas version 2

            Console.WriteLine("Dime tu peso en kg");
            decimal userWeight = decimal.Parse(Console.ReadLine());

            const decimal mercurio = 0.38m;
            const decimal venus = 0.93m;
            const decimal marte = 0.37m;

            Console.WriteLine("Elige un planeta para calcular tu peso:");
            Console.WriteLine("1. Mercurio, 2. Venus, 3. Marte");
            string planetChoice = Console.ReadLine();

            // 1. Operador ternario anidado para calcular el peso según la opción
            decimal planetWeight = (planetChoice == "1") ? userWeight * mercurio :
                                  (planetChoice == "2") ? userWeight * venus :
                                  userWeight * marte; // Si no es 1 ni 2, por defecto calcula Marte (o puedes ajustar si ponen otra cosa)

            // 2. Operador ternario anidado para obtener el NOMBRE del planeta en texto
            string planetName = (planetChoice == "1") ? "Mercurio" :
                                   (planetChoice == "2") ? "Venus" :
                                   "Marte";

            // 3. Mostramos el resultado usando la variable con el nombre del planeta
            Console.WriteLine($"\nTu peso en {planetName} es: {planetWeight:F2} kg");





            //Simulador de ataque elemental


            int enemy_healt = 100;

            string[] elements = ["Fuego", "Hielo", "Luz"];

            Console.WriteLine("Elige un elemento para atacar: Fuego, Hielo, o Luz");
            string chosenElement = Console.ReadLine();

            Console.WriteLine($"Has elegido atacar con {chosenElement}. Ahora elige con cuanto daño quieres atacar");
            int damage = int.Parse(Console.ReadLine());



            if (chosenElement == "Fuego")
            {
                enemy_healt -= damage * 2;
                Console.WriteLine($"Has atacado con {chosenElement} y has hecho {damage * 2} de daño, el enemigo es débil ante este elemento." +
                    $" La vida del enemigo ahora es {enemy_healt}");
            }
            else if (chosenElement == "Hielo")
            {
                enemy_healt -= damage / 2;
                Console.WriteLine($"Has atacado con {chosenElement} y has hecho {damage / 2} de daño, ya que el enemigo es resistente a este elemento." +
                    $" La vida del enemigo ahora es {enemy_healt}");
            }
            else if (chosenElement == "Luz")
            {
                enemy_healt += 33 % damage;
                Console.WriteLine($"Has atacado con {chosenElement} y has curado {33 % damage} puntos de vida al enemigo. La vida del enemigo ahora es {enemy_healt}");
            }
            else
            {
                Console.WriteLine("Elemento no válido. Por favor elige Fuego, Hielo, o Luz.");
            }
        }
    }
}