using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversion_de_dépendance
{
    public class Program
    {
        public static void Main()
        {
            Terminal terminal = new Terminal();
            while (!terminal.Exited)
            {
                Adapter adapter = terminal.PromptCommand();
                terminal.ExecuteCommand(adapter);
            }
        }
    }



 



    
}
