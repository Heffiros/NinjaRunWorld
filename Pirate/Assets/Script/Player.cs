using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


class Player
{
	public enum PointIncome
	{
		ZOMBIE = 10,
		SPAWNER = 50,
	};

	public enum Level
	{
		_SHOP = 2,

		CITY = 1,
		DESERT = 3,
	};

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

	public int Wave { get; set; }

	private Level _nextLevel = Level.CITY;

	public void GoShopThenLevel(Level level)
	{
		_nextLevel = level;
		Application.LoadLevel((int)Level._SHOP);
	}

	public void AddPoints(PointIncome points)
	{
		Points += points;
	}

	public void GoToNextLevel()
	{
		// first level => we're going at it again!
		if (_nextLevel == Level.CITY) {
			Wave++;
		}
		Application.LoadLevel ((int)_nextLevel);
	}

	public Level GetNextLevel()
	{
		if (Application.loadedLevel == (int)Level.DESERT) {
			return Level.CITY;
		} else {
			return Level.DESERT;
		}
	}

	private Player()
	{
		nameWeapon = "Kunai";
		AttSpeed = 10;
		HP = 20;
		HPMax = 10;
		WeaponDamage = 10;
		weaponInv = new List<int>();
	}
}