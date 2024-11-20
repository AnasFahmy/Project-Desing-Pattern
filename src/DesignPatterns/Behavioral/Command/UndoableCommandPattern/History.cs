using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Behavioral.Command.UndoableCommandPattern
{
    // Class to keep track of the commands that we've applied.
    public class History
    {
        private List<UndoableCommand> _commands = new List<UndoableCommand>();

        public void Push(UndoableCommand command)
        {
            _commands.Add(command);
        }

        public UndoableCommand Pop()
        {
            var last = _commands.Last();
            _commands.Remove(last);
            return last;
        }

        public int Size()
        {
            return _commands.Count;
        }
    }
}