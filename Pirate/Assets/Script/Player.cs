using UnityEngine;
using System.Collections;


class Player
{
	static private Player _instance = new Player();
	static public Player Instance {
		get { return _instance; }
	}

	public int HP { get; set; }
	public int Points { get; set; }
	public int BareHandDamage { get; set; }
	public int WeaponDamage { get; set; }

	private Player()
	{
		HP = 10;
		WeaponDamage = 10;
	}
}
