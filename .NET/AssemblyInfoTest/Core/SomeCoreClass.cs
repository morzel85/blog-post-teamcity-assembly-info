using System.Reflection;

namespace Core
{
    public class SomeCoreClass
    {
        public static string GetAssemblyInfo()
        {
            return Assembly.GetExecutingAssembly().FullName;
        }
    }
}
