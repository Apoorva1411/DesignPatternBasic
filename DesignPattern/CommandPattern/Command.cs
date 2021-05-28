using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public interface ICommand
    {
        void Execute();
    }


    public class Command1 : ICommand
    {
        private CommandTarget _tgt;

        public Command1()
        {
            _tgt = new CommandTarget();
        }

        public void Execute()
        {
            _tgt.Method();
        }
    }

    public class Command2 : ICommand
    {
        private CommandTarget _tgt;

        public Command2()
        {
            _tgt = new CommandTarget();
        }
        public void Execute()
        {
            _tgt.Method();
        }
    }

    public class Commands : ICommand
    {
        private List<ICommand> _commands;

        public Commands()
        {
            _commands = new List<ICommand>();
            _commands.Add(new Command1());
            _commands.Add(new Command2());
        }
        public void Execute()
        {
            foreach (var command in _commands)
            {
               command.Execute();
            }
        }
    }
}
