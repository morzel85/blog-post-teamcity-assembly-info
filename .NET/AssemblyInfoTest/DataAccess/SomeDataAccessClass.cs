using System.Reflection;

namespace DataAccess
{
    public class SomeDataAccessClass
    {
        public static string GetAssemblyInfo()
        {
            return Assembly.GetExecutingAssembly().FullName;
        }
    }
}
