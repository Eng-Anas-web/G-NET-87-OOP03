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
        }
    }
}
