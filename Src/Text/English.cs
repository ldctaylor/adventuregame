using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventuregame

{
    public class English: Language
    {
    public English()
    {
        ChooseYourName = "Hello, what is your name?";
        DefaultName = "Anonymous";
        Welcome = "Welcome to your OOP adventure, {0}!";
        DefaultChamberName = "Chamber {0} ({1},{2})";
        DefaultChamberDescription = "You are in a chamber with an archway to the {0}";
    }

    }
}
