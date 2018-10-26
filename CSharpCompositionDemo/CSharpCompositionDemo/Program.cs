using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompositionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * In this program we are using a Logger class to 
             * display a message in bother Installer and
             * DbMigrate  class which is another example to 
             * code reuse
             */
            var dbMigrator = new DbMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
