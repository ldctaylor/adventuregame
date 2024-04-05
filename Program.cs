using adventuregame;

Text.LoadLanguage(new English());

Console.WriteLine(Text.Language.ChooseYourName);

string? name = Console.ReadLine();

if (string.IsNullOrEmpty(name))
{
    name = Text.Language.DefaultName;
}

// if (name == String.Empty)
//    name = "No Name";

var player = new Adventurer(name);

Console.WriteLine(Text.Language.Welcome, player.Name);

var house = new Dungeon(player);
