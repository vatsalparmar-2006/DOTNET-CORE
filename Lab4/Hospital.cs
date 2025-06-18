using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Hospital
    {
        public void HospitalDetails()
        {
            Console.WriteLine("This is from Hospital.");
        }
    }

    class Apollo : Hospital
    {
        public void HospitalDetails()
        {
            base.HospitalDetails();
            Console.WriteLine("This is from Apolo.");
        }
    }

    class Wockhardt : Hospital
    {
        public void HospitalDetails()
        {
            base.HospitalDetails();
            Console.WriteLine("This is from Workardt.");
        }

    }

    class Gokul_Superspeciality : Hospital
    {
        public void HospitalDetails()
        {
            base.HospitalDetails();
            Console.WriteLine("This is from Gokul_Superspeciality.");
        }
    }
}
