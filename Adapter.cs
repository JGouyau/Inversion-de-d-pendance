using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversion_de_dépendance
{
    public class Adapter : ICommande
    {
        private Command _command;

        public string Output { get { return _command.Output; } set { } }

        public Adapter(string line)
        {
            _command = new Command(line);
            Output = _command.Output;
        }

        public void Launch()
        {
            _command.LaunchCommand();
            Output = _command.Output;
        }


    }
}
