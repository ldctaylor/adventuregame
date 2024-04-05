using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventuregame.Src.Actions
{
    public abstract class Action
    {
        public virtual string Name => "";
        public virtual void Execute(string[] args)
        {
            // the reason we put this exception in, is so that if
            // a new inherited action is created but the coder forgets to 
            // add statements to the Execute method, i.e. how the action needs to 
            // execute, the program will revert back to the Execute method of the 
            // abstract Action class and throw an exception.
            throw new Exception("Nothing to execute");
        }

    }
}
