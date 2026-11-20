namespace C50_GSat_Basics02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            /*Q01.  Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            variable of type object. Print it.*/

            Book b1 = new Book();
            b1.title = "Atomic Habits";
            b1.pages = 200;
            object b2 = b1;

            Console.WriteLine(b2);
            #endregion
        }
    }
}
