using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CommandSource
    {
        private ICommand _command;

        public CommandSource(ICommand command)
        {
            _command = command;
        }

        public void Trigger()
        {
            _command.Execute();
        }
    }
}
