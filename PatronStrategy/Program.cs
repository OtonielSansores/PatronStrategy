using PatronStrategy.Interfaces;
using System;

namespace PatronStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormato jpge = new Jpge();
            IFormato png = new Png();
            IFormato bmp = new Bmp();
            PatronStrategy.Context.Context context = new Context.Context(jpge);

            Console.WriteLine("Ingrese el nombre de la imagen");
            string nombreImagen = Console.ReadLine();


            Console.WriteLine("Seleccione el formato con el cual quiere guardar la imagen");
            Console.WriteLine("1 = JPGE");
            Console.WriteLine("2 = PNG");
            Console.WriteLine("3 = BMP");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    context = new Context.Context(jpge);
                    break;
                case 2:
                    context = new Context.Context(png);
                    break;
                case 3:
                    context = new Context.Context(bmp);
                    break;
            }

            Console.WriteLine(context.GuardarImagen(nombreImagen));
            Console.ReadKey();
        }
    }
}
