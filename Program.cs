using System;

namespace RockPaperScissors
{
    class Program
    {

        /// <summary>
        /// Solicita al usuario una opción a jugar.
        /// </summary>
        /// <returns>La opción seleccionada: 1 - piedra, 2 - papel, 3 - tijera</returns>
        static int SelectOption()
        {
            Console.WriteLine("Selecciona la opción a jugar:");
            Console.WriteLine("1) Piedra");
            Console.WriteLine("2) Papel");
            Console.WriteLine("3) Tijera");

            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }

        static void Main(string[] args)
        {
            //Seleccionar opción a jugar (piedra, papel o tijera)
            // 1: piedra
            // 2: papel
            // 3: tijera
            int option = SelectOption();
            Console.WriteLine("Opción seleccionada: " + option);

            //TODO: La computadora genera su opción a jugar de manera aleatoria (piedra, papel o tijera)

            //TODO: Determinar quién ganó de acuerdo a las opciones seleccionadas, y mostrar al ganador

            //TODO: Jugar 3 partidas, y mencionar quién ganó al final (jugador o computadora)
        }
    }
}
