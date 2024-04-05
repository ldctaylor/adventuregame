namespace adventuregame;

public class  Chamber 
{
    public string Name { get; set; } = Text.Language.DefaultChamberName;
    public string Description { get; set; } = Text.Language.DefaultChamberDescription;

    public Dictionary<Directions, int> Neighbours { get; set; } = new()
    {
        {Directions.North, -1 },
        {Directions.East, -1 },
        {Directions.South, -1 },
        {Directions.West, -1 },
        {Directions.None, -1 },
    };

    public bool Visited { get; set; }
}
