using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperatorWithPermissions
{
  

    [Flags]
    enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4,
        Delete = 8
    }

    class Program
    {
        static void Main()
        {
            // Set permissions for a user
            Permissions userPermissions = Permissions.Read | Permissions.Write;

            // Check if user has Read permission
            bool hasReadPermission = (userPermissions & Permissions.Read) != 0;
            Console.WriteLine("User has Read permission: " + hasReadPermission);

            // Check if user has Execute permission
            bool hasExecutePermission = (userPermissions & Permissions.Execute) != 0;
            Console.WriteLine("User has Execute permission: " + hasExecutePermission);

            // Add Execute permission to user
            userPermissions |= Permissions.Execute;
            Console.WriteLine("Updated permissions: " + userPermissions);

            // Remove Write permission from user
            userPermissions &= ~Permissions.Write;
            Console.WriteLine("Updated permissions: " + userPermissions);


            Console.ReadKey();
        }
    }
}
