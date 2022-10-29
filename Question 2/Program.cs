using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Question_2
{
    public class Window 
    {
        //Declaring the string Name and making the method that allows
        //for its change.
        public string Name; 
        public void ListingNameChange(string Name) 
        {
            Name = "John";
            
        }
    }


    public class ListBox : Window
    {
        //Listing what is in the variable derived from the
        //Window class in a print out to the user.
        public void getList () 
        {
            Console.WriteLine("From the Listing we can see you inputed: "+Name);
        }
    }


    internal class Program
    {
       
        static void Main(string[] args)
        {
            //Making a variable that will hold users input so as to
            //rename the variable name in the Window class and then
            //running the method in the ListBox class.
            ListBox name = new ListBox();
            Console.WriteLine("Please enter a name: ");
            string name1 = Console.ReadLine();

            name.Name = name1;           
            name.getList();
            Console.Read();
        }
    }
}
