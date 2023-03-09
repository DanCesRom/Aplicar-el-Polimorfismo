namespace ClassPrecensia
{
    public class General 
    
    {
        public static void Main(string[] args)
        {
            Chihuaha chihuaha1 = new Chihuaha();
            PastorAleman pastorAleman1 = new PastorAleman();
            Poodle poodle1 = new Poodle();

            List<string> opciones = new List<string>();
            opciones.Add("a. Chihuaha");
            opciones.Add("b. Pastor Aleman");
            opciones.Add("c. Poodle");

            Console.WriteLine("Elige el perro: ");
            Console.WriteLine('\n'); 
            foreach (string x in opciones)
            {
                Console.WriteLine(x);
            }

            ConsoleKeyInfo opcion = Console.ReadKey();
            Console.Clear();

            if (opcion.KeyChar.ToString() == "a")
            {
                Console.WriteLine(chihuaha1.Ladrar());
                Console.WriteLine(chihuaha1.Comer());
                Console.WriteLine(chihuaha1.Saltar());
                Console.WriteLine(chihuaha1.Correr());
                Console.WriteLine(chihuaha1.Beber());
                Console.WriteLine(chihuaha1.Dormir());
            }
            else if (opcion.KeyChar.ToString() == "b")
            {
                Console.WriteLine(pastorAleman1.Ladrar());
                Console.WriteLine(pastorAleman1.Comer());
                Console.WriteLine(pastorAleman1.Saltar());
                Console.WriteLine(pastorAleman1.Correr());
                Console.WriteLine(pastorAleman1.Beber());
                Console.WriteLine(pastorAleman1.Dormir());
            }

            else if (opcion.KeyChar.ToString() == "c")
            {
                Console.WriteLine(poodle1.Ladrar());
                Console.WriteLine(poodle1.Comer());
                Console.WriteLine(poodle1.Saltar());
                Console.WriteLine(poodle1.Correr());
                Console.WriteLine(poodle1.Beber());
                Console.WriteLine(poodle1.Dormir());
            }

            else 
            { 
                Console.WriteLine("No elegiste ningun animal disponible");
            }






        }
    }

}



