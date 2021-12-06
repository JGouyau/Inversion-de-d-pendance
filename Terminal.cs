using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversion_de_dépendance
{
    public class Terminal
    {
        public bool Exited { get; set; }
        private string _promptString;

        public Terminal()
        {
            _promptString = String.Format("{0}$ ", System.Security.Principal.WindowsIdentity.GetCurrent().Name);
            Exited = false;
        }

        public Adapter PromptCommand()
        {
            string commandLine = Prompt();
            return new Adapter(commandLine);
        }


        public string Prompt()
        {
            Console.Write(_promptString);
            string userCommand = Console.ReadLine();
            return userCommand;
        }


        public void ExecuteCommandAdapt(Adapter adapter)
        {
            try
            {
                adapter.Launch();
                if (adapter.Output.Length > 0)
                {
                    Console.WriteLine(adapter.Output);
                }
            }
            catch (InvalidOperationException exception)
            {
                Console.Error.WriteLine("{0}: path not found", adapter);
            }
        }

        public void ExecuteCommand(Adapter adapter)
        {
            try
            {
                adapter.Launch();
                if (adapter.Output.Length > 0)
                {
                    Console.WriteLine(adapter.Output);
                }
            }
            catch (InvalidOperationException exception)
            {
                Console.Error.WriteLine("{0}: path not found", adapter.Output);
            }
        }
    }
}
