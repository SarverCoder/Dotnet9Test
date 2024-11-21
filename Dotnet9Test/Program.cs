using System.Text.RegularExpressions;

namespace Dotnet9Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(IsValidName("Sarvar"));
            Console.WriteLine(IsValidNumber("934548544"));
            Console.WriteLine(IsValidEmail("sarvargamer8544@gmail.com "));

          
            
        }  
        
        static bool IsValidName(string name)
        {
            string pattern = @"^([A-Z]{1}[a-z]+)$";

            return Regex.IsMatch(name, pattern);
        }

        static bool IsValidNumber(string email)
        {
            string pattern = "(^[0-9]{9}$)|(^[0-9]{2}-[0-9]{3}-[0-9]{2}$)";

            return Regex.IsMatch(email, pattern);
           
        }

        static bool IsValidEmail(string email)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            return Regex.IsMatch(email, pattern);
        }
        static void Add()
        {
            Console.WriteLine("Added two numbers");
        }
    }
}
