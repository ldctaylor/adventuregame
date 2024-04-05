namespace adventuregame;

public partial class Dungeon
{
    public Adventurer Player { get; }

    private readonly Random _rnd = new(1234);

    public int Width { get; set; }
    public int Height { get; set; }
    public Chamber[] Chambers { get; private set; }

    public Dungeon(Adventurer player)
    {
        Player = player;
    }

}