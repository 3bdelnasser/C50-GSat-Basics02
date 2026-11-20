namespace C50_GSat_Basics02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            /*Q01.  Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            variable of type object. Print it.*/

            //Book b1 = new Book();
            //b1.title = "Atomic Habits";
            //b1.pages = 200;
            //object b2 = b1;

            //Console.WriteLine(b2);
            #endregion

            #region Question 2
            /*Q02.  Using the Book class above, print the result of calling ToString(), Equals() (compare book with
            itself), GetHashCode(), and GetType() on book.*/

            Book b1 = new Book();
            b1.title = "Atomic Habits";
            b1.pages = 200;
            

            Console.WriteLine(b1.ToString());
            Console.WriteLine(b1.Equals(b1));
            Console.WriteLine(b1.GetHashCode());
            Console.WriteLine(b1.GetType());
            #endregion
        }
    }
}
