using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace InterfazBackUp
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PermissionSet permisos = new System.Security.PermissionSet(null);
            permisos.AddPermission(new UIPermission(PermissionState.Unrestricted));
            permisos.PermitOnly();

            FileIOPermission f = new FileIOPermission(PermissionState.None);
            f.AllLocalFiles = FileIOPermissionAccess.AllAccess;


            FileIOPermission f2 = new FileIOPermission(FileIOPermissionAccess.Read, @"D:\");
            f2.AddPathList(FileIOPermissionAccess.Write | FileIOPermissionAccess.Read, @"D:\");

            try
            {
                f.Demand();
                f2.Demand();            }
            catch (SecurityException s)
            {
                Console.WriteLine(s.Message);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
