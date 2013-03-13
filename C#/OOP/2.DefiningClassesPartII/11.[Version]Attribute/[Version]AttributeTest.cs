using System;

namespace VersionAttribute
{
    [Version("1.00")]
    class VersionAttributeTest
    {
        static void Main()
        {
            Type type = typeof(VersionAttributeTest);
            object[] attributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute versionAttribute in attributes)
            {
                Console.WriteLine("Version: {0}", versionAttribute.Version);
            }
        }
    }
}
