namespace projects_nested_iteration_fraudulent_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // arrays_foreach loop
            string[] fraudulentOrderID = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            Console.Write("The following orders start with the letter B: ");

            foreach (string currentOrderID in fraudulentOrderID)
            {
                if (currentOrderID.StartsWith("B"))
                {
                    Console.Write($"{currentOrderID}, ");

                }
            }
            ;

            Console.Write("\n");
        }
    }
}
