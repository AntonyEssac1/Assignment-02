using System.Text;

namespace C__Session_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region   //question 1

            ///*Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.
            // * Print both title and upperTitle to show that title did not change.*/

            ////string title = "clean code ";
            ////string uperTitle = title.ToUpper();
            ////Console.WriteLine(title);
            ////Console.WriteLine(uperTitle);


            ///* Declare two separate string variables, both set to the literal "Clean Code".
            //     Use ReferenceEquals() to check if they point to the same object in memory.*/


            ////string title1 = "Clean Code";
            ////string title2 = "clean Code";
            ////Console.WriteLine(object.ReferenceEquals(title1,title2));  //false 

            #endregion

            #region //question 2

            /* Create a StringBuilder, Append() the text "Book List",
             then Append() " - Updated" onto the same object.Print the final result.*/

            //StringBuilder str = new();
            //str.Append("Book List");
            //str.Append("_Update");
            //str.Append("_Update2");

            ///*Using the StringBuilder from the question above, 
            //*use Replace() to change "Book List" into "Library". Print the result */

            //str.Replace("Book List", "Library");
            //Console.WriteLine(str);

            #endregion

            #region //question 3

            /*Given string title = "Clean Code"; and int pages = 464;,
            build the sentence "Book: Clean Code, Pages: 464" using the + operator. */

            //string title = "Clean Code ";
            //int pages = 464;
            //Console.WriteLine("Book: " + title + pages);

            /*Build the same sentence as above, 
            * but using string interpolation ($"...").*/

            //Console.WriteLine($"Book : {title}{pages}");

            //Build the same sentence again, but using string.Format(). 

            //string results = string.Format("the title is : {0} , the pages is {1}", title, pages);
            //Console.WriteLine(results);

            #endregion

            #region //question 4
            /* Given int pages = 464;, write an if / else statement 
             that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book".*/

            int pages = 464;
            if (pages > 300) Console.WriteLine("Long Book");
            else Console.WriteLine("Short Book");
            
            

            #endregion

        }
    }
}
