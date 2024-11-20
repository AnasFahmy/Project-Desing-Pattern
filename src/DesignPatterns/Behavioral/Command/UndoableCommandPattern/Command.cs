using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Behavioral.Command.UndoableCommandPattern
{
    public interface Command
    {
        void Execute();
    }
}