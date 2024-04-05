using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventuregame.Src.Actions
{
    public sealed class Actions
    {
        private static Actions _instance;

        public static Actions Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Actions();

                return _instance;
            }
        }

        private readonly Dictionary<string, Action> _registeredActions = new();

        private Actions()
        {

        }

        public void Register(Action action)
        {
            var name = action.Name.ToLower();

            if (_registeredActions.ContainsKey(name))
                _registeredActions[name] = action;
            else
            _registeredActions.Add(name, action);
            {
                
            }
        }

    }
}
