using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(String[] args)
    {
        //variables
        int count;
        List<Vehicle> parking = new List<Vehicle>();
        Console.WriteLine("Quanti veicoli vuoi inserire?");

        while (!int.TryParse(Console.ReadLine(), out count))
        {
            Console.WriteLine("Devi inserire un numero, riprova!");
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Tipo <car> <motorbike>");
            string type;

            do
            {
                type = Console.ReadLine().ToLower().Trim();

                if (type != "car" && type != "motorbike")
                {
                    Console.WriteLine("Devi iniserire un tipovalido: <car> <motorbike>");
                }
            } while (type != "car" && type != "motorbike");

            Console.WriteLine("Nome del modello?");
            string ModelName = Console.ReadLine();
            Console.WriteLine("Data di immatricolazione? <yyyy-MM-dd>");
            DateTime RegistrationDate;

            while (!DateTime.TryParseExact(
                Console.ReadLine(),
                "yyyy-MM-dd",
                null,
                System.Globalization.DateTimeStyles.None,
                out RegistrationDate
            ))
            {
                Console.WriteLine("Deve essere in formato <yyyy-MM-dd>");
            }

            switch (type)
            {
                case "car":
                    parking.Add(new Car(ModelName, RegistrationDate));
                    break;
                case "motorbike":
                    parking.Add(new Motorbike(ModelName, RegistrationDate));
                    break;
            }

        }

        Console.WriteLine("Stampa: ");

        foreach (Vehicle v in parking)
        {
            Console.WriteLine(v.ToString() + "\n");
            v.Sound();
        }

    }
}

