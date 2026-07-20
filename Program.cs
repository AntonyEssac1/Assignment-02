namespace C__Session_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region   //question 1

            /*Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.
             * Print both title and upperTitle to show that title did not change.*/

            //string title = "clean code ";
            //string uperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(uperTitle);


            /* Declare two separate string variables, both set to the literal "Clean Code".
                 Use ReferenceEquals() to check if they point to the same object in memory.*/


            //string title1 = "Clean Code";
            //string title2 = "clean Code";
            //Console.WriteLine(object.ReferenceEquals(title1,title2));  //false 

            #endregion
        }
    }
}
