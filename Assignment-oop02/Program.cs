using Assignment_oop02.Classes;

namespace Assignment_oop02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //1- 
            //a) What is the difference between a class and a struct?
            //Class => Reference Type , Storge in Heap , Support the inheritance , Can be Null.
            //Struct => Value Type , Storge in Stack , Not Support the inheritance , Cannot be null. 
            //b) Why are classes more suitable than structs for large applications?
            //A:  Because it follows all the OOP principles, and its data is stored in the heap.
            #endregion

            #region Question02
            //2-
            //a) Which class is the parent class?
            //A: Shipment
            //b) Which class is the child class?
            //A: ExpressShipment
            //c) What members are inherited by ExpressShipment?
            //A: inherited the Prop Auto (Tracking Code)
            //d) Why is inheritance better than duplicating the same code in multiple classes? 
            //A: Because it prevents code duplication and spaghetti code, and it follows the basic principles of the language, which is OOP. 
            #endregion

            #region Question03

            DeliveryCenter deliveryCenter = new DeliveryCenter();

            Console.Write("Enter Delivery Center Name: ");
            string center = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("===============================================================");
            Console.WriteLine($"Delivery Center: {center}");
            Console.WriteLine("===============================================================");
            Console.WriteLine("Standard Shipment");
            Console.WriteLine();
            Console.Write("Tracing Code: ");
            string tracingCode01 = Console.ReadLine();
            Console.Write("Description: ");
            string description01 = Console.ReadLine();
            Console.Write("Weight: ");
            double weight01 = double.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal deliveryFee01 = decimal.Parse(Console.ReadLine());
            Console.Write("City: ");
            string city01 = Console.ReadLine();
            Console.Write("Street: ");
            string street01 = Console.ReadLine();
            Console.Write("Building Number: ");
            int buildingNumber01 = int.Parse(Console.ReadLine());
            DeliveryAddress address = new DeliveryAddress(
                  city01,
                  street01,
                  buildingNumber01
                  );
            StandardShipment standard = new StandardShipment(
                tracingCode01,
                description01,
                weight01,
                deliveryFee01,
              address
                );

            if (deliveryCenter.AddShipment(standard))
            {
                Console.WriteLine("Shipment Added Successfully");
                Console.WriteLine("-----------------------------------------------------------------");
            }
            ///////////////////////////////////////////////////////////////
            Console.WriteLine("Express Shipment");
            Console.WriteLine();
            Console.Write("Tracing Code: ");
            string tracingCode02 = Console.ReadLine();
            Console.Write("Description: ");
            string description02 = Console.ReadLine();
            Console.Write("Weight: ");
            double weight02 = double.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal deliveryFee02 = decimal.Parse(Console.ReadLine());
            Console.Write("Extra Fee: ");
            decimal extraaFee = decimal.Parse(Console.ReadLine());
            Console.Write("City: ");
            string city02 = Console.ReadLine();
            Console.Write("Street: ");
            string street02 = Console.ReadLine();
            Console.Write("Building Number: ");
            int buildingNumber02 = int.Parse(Console.ReadLine());
            DeliveryAddress address02 = new DeliveryAddress(
      city02,
      street02,
      buildingNumber02
      );
            ExpressShipment express = new ExpressShipment(
                extraaFee,
                tracingCode02,
                description02,
                weight02,
                deliveryFee02,
              address02
                );

            if (deliveryCenter.AddShipment(express))
            {
                Console.WriteLine("Shipment Added Successfully");
                Console.WriteLine("-----------------------------------------------------------------");

            }
            /////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("International Shipment");
            Console.WriteLine();
            Console.Write("Tracing Code: ");
            string tracingCode03 = Console.ReadLine();
            Console.Write("Description: ");
            string description03 = Console.ReadLine();
            Console.Write("Weight: ");
            double weight03 = double.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal deliveryFee03 = decimal.Parse(Console.ReadLine());
            Console.Write("Destination Country: ");
            string destinationCountry = Console.ReadLine();
            Console.Write("Custom Fee: ");
            decimal customFee = decimal.Parse(Console.ReadLine());
            Console.Write("City: ");
            string city03 = Console.ReadLine();
            Console.Write("Street: ");
            string street03 = Console.ReadLine();
            Console.Write("Building Number: ");
            int buildingNumber03 = int.Parse(Console.ReadLine());
            DeliveryAddress address03 = new DeliveryAddress(
      city03,
      street03,
      buildingNumber03
      );
            InternationalShipment International = new InternationalShipment(
                destinationCountry,
                customFee,
                tracingCode03,
                description03,
                weight03,
                deliveryFee03,
              address03
                );

            if (deliveryCenter.AddShipment(International))
            {
                Console.WriteLine("Shipment Added Successfully");
                Console.WriteLine("-----------------------------------------------------------------");

            }

            Console.WriteLine("--- All Shipments ---");
for(int i =0; i < 20; i++)
            {
                if (deliveryCenter[i] != null)
                {
                    Console.WriteLine($"Shipments {i + 1}");
                    deliveryCenter[i].PrintShipment();
                    Console.WriteLine("=================================================================");
                }
            }


            //===========================Search==============================================//
       
            Console.WriteLine("\n Enter Tracing Code Search: ");
            string codeSarch = Console.ReadLine();

            Shipment result = deliveryCenter[codeSarch];

            if(result != null)
            {
                result.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment Not Found.");
            }

            //===========================Remove==============================================//

            Console.WriteLine("\n Enter Tracing Code to Rmove: ");
            string removeCode = Console.ReadLine();
             bool remove = deliveryCenter.RemoveShipment(removeCode);

            if(remove == true)
            {
                Console.WriteLine("Shipment Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Shipment Not Found.");

            }

            Console.WriteLine("========================================================================");
            Console.WriteLine("Remaining Shipments:");
            Console.WriteLine("\n========================================================================");
            for (int i = 0; i < 20; i++)
            {
                if (deliveryCenter[i] != null)
                {
                    Console.WriteLine("Shipments01");
                    deliveryCenter[i].PrintShipment();
                    Console.WriteLine("=================================================================");
                }
            }

            #endregion
        }
    }
}
