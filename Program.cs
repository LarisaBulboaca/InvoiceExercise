using InvoiceExercise;
    public class Program
{
    public static void Main()
    {
        //created an array of type Item with one Item (I looked it up on google, still not sure I completely understand it)
        Item[] items1 = new Item[] 
        {
            new Item(1, "jacket", "marime S", 100, 1)
        }; 

        Invoice invoice1 = new Invoice(1, new DateTime(2023, 07, 30), "Larisa", items1, 16 );
        Console.WriteLine( invoice1);

        //I do not know how to display the contents of the items1 array
        

    }
}
