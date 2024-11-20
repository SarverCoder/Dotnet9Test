using System.Text.RegularExpressions;

namespace Dotnet9Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(IsValidName("Sarvar"));
            Console.WriteLine(IsValidEmail("934548544"));

            string pattern = @"^([A-Z]{1}[a-z]+)$";

            Regex reg = new Regex(pattern);

            Console.WriteLine(reg.IsMatch("Ali"));
            
        }  
        
        static bool IsValidName(string name)
        {
            string pattern = @"^([A-Z]{1}[a-z]+)$";

            return Regex.IsMatch(name, pattern);
        }

        static bool IsValidEmail(string email)
        {
            string pattern = "(^[0-9]{9}$)|(^[0-9]{2}-[0-9]{3}-[0-9]{2}$)";

            return Regex.IsMatch(email, pattern);
           
        }

        
    }
}
