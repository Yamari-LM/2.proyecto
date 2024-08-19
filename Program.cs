using System;

class Notas
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sistema de Calculo de Notas");
        Console.WriteLine("Favor Ingresa tu Nombre");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Favor Ingresa el Nombre de la Asignatura");
        string Asignatura = Console.ReadLine();
        Console.WriteLine("Ingresa la Primer Nota parcial");
        int Notal = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa la Segunda Nota parcial");
        int Nota2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa la Tercer Nota parcial");
        int Nota3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa la Cuarta Nota parcial");
        int Nota4 = Convert.ToInt32(Console.ReadLine());
        int promedio = (Notal + Nota2 + Nota3 + Nota4) / 4;

        if (promedio <= 70)
        {
            Console.WriteLine("Usted esta reprobado");
            Console.ReadKey();
        }
        if (promedio > 70 & promedio <= 80)
        {
            Console.WriteLine("Usted se encuentra en la categoria de Bueno");
            Console.ReadKey();
        }
        if (promedio > 80 & promedio <= 90)
        {
            Console.WriteLine("Usted se encuentra en la categoria de Muy Bueno");
            Console.ReadKey();
        }
        if (promedio > 90 & promedio < 100)

            Console.WriteLine("Usted es Sobresaliente");
        Console.ReadKey();
    }
}

}


