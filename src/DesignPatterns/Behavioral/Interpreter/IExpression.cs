using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Behavioral.Interpreter
{
    public interface IExpression
    {
        int Interpret(Context context);
    }
}