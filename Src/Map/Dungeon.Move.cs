namespace adventuregame;

public partial class House
{
	public Chamber CurrentChamber { get; set; }

	public void GoToRoom(int index)
	{
		if(CurrentChamber != null)
		{
			CurrentChamber.Visited = true;
		}

		CurrentChamber = Chambers[index];
	}

	public void GoToStartingRoom()
	{
		GoToRoom(_rnd.Next(0,Chambers.Length));
	}
}