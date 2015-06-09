using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


class Player
{
	static private Player _instance = new Player();
	static public Player Instance {
		get { return _instance; }
	}
	
	public int HP { get; set; }
	public int HPMax { get; set;}
	public int Points { get; set; }
	public int WeaponDamage { get; set; }
	public GameObject Weapon { get; set; }
	public IList<int> weaponInv { get; set; }
	public int AttSpeed { get; set; }
	public string nameWeapon { get; set;}
	private Player()
	{
		nameWeapon = "Kunai";
		AttSpeed = 10;
		HP = 10;
		HPMax = 10;
		WeaponDamage = 10;
		weaponInv = new List<int>();
	}
}