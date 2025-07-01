    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Furniture
    {
        public String Material;
        public double Price;

        public void GetFurnitureDetails()
        {
            Console.Write("Enter Material : ");
            Material = Console.ReadLine();

            Console.Write("Enter Price : ");
            Price = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayFurnitureDetails()
        {
            Console.WriteLine($"\nMaterial : {Material}");
            Console.WriteLine($"Price : {Price}");
        }
    }

    class Table : Furniture
    {
        double Height;
        double SurfaceArea;

        public void GetTableDetails()
        {
            Console.Write("Enter Height : ");
            Height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Surface Area : ");
            SurfaceArea = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayTableDetails()
        {
            DisplayFurnitureDetails();
            Console.WriteLine($"Height : {Height}");
            Console.WriteLine($"Surface Area : {SurfaceArea}");
        }
    }
}
