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

            //Book b1 = new Book();
            //b1.title = "Atomic Habits";
            //b1.pages = 200;


            //Console.WriteLine(b1.ToString());
            //Console.WriteLine(b1.Equals(b1));
            //Console.WriteLine(b1.GetHashCode());
            //Console.WriteLine(b1.GetType());
            #endregion

            #region Question 3
            /*Q03.  Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            int pages = "464";*/

            // Compile-time Error
            //int pages = 464;
            #endregion

            #region Question 4
            /*Q04.  Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
            zero", and then prints "Done" in a finally block.*/

            //int n1 = 10, n2 = 0;
            //try
            //{
            //    Console.WriteLine(n1 / n2);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Cannot Divide By Zero!");
            //    Console.WriteLine(ex.GetType());
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion

            #region Question 5
            /*Q05.  Declare an int pages = 300; then store it in a double variable without using a cast.*/

            //int pages = 300;
            //double p1 = pages;
            #endregion

            #region Question 6
            /*Q06.  Declare a double price = 49.99; then convert it into an int using a cast.*/

            //double price = 49.99;

            //int p1 = (int)price;
            //int p2 = Convert.ToInt32(price);
            #endregion

            #region Question 7
            /*Q07.  Given string pagesText = "464";, convert it into an int using the Convert class.*/

            //string pagesText = "464";

            //int p1 = Convert.ToInt32(pagesText);
            #endregion

            #region Question 8
            /*Q08.  Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
            use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.*/

            //string yearText = "2023";
            //string badText = "abc";

            //int year = int.Parse(yearText);

            //if (int.TryParse(badText, out int x))
            //{
            //    Console.WriteLine(x);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}
            #endregion

            #region Question 9
            /*Q09.  Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()
            to prove it's now a string.*/

            //int pages = 464;

            //string p1 = pages.ToString();

            //Console.WriteLine(p1.GetType());
            #endregion

            #region Question 10
            /*Q10.  Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
            variable, and print both.*/

            //int copies = 100;

            //object c1 = copies;

            //int c2 = (int)c1;

            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            #endregion

            #region Question 11
            /*Q11.  Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.
            */

            //int? year = null;

            //Console.WriteLine(year.HasValue);

            //year = 2023;

            //Console.WriteLine($"New Value: {year}");
            #endregion

            #region Question 12
            /*Q12.  Declare a string? reviewer = null;. Print whether it is null.*/

            //string? reviewer = null;

            //if (reviewer is null)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            #endregion
        }
    }
}
