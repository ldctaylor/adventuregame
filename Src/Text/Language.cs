using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventuregame
{
public abstract class Language
    {
        public string Welcome { get; protected set; } = "";
        public string ChooseYourName { get; protected set; } = "";
        public string DefaultName { get; protected set; } = "";
        public string DefaultChamberName { get; protected set; } = "";
        public string DefaultChamberDescription { get; protected set; } = "";
    }
}
