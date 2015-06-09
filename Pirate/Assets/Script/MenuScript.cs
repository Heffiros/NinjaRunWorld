using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.Collections.Generic;


public class MenuScript : MonoBehaviour {
	
	public Canvas QuitMenu;
	public Canvas ShopMenu;

	public Button startText;
	public Button exitText;
	public Button weapon1;
	public Button weapon2;
	public Button weapon3;

	public Text Error;
	public Text nameWeapon;
	public Text vieText;
	public Text vieMaxText;
	public Text goldText;
	public Text attackWea;
	public Text attSpeed;

	private String[] armes = {"kunai1-1-128", "syurikenn1-1", "syurikenn2-1"};
	private int[] price = {500, 1000, 1500};
	private int[] degats = {10, 15, 25};
	private string[] name = {"Shuriken++", "kunai", "kunai++"};
	public IDictionary<int, Button> weapons;


	// Use this for initialization
	void Start () {
		ShopMenu = ShopMenu.GetComponent<Canvas> ();
		QuitMenu = QuitMenu.GetComponent<Canvas> ();

		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		weapon1 = weapon1.GetComponent<Button> ();
		weapon2 = weapon2.GetComponent<Button> ();
		weapon3 = weapon3	.GetComponent<Button> ();

		vieText = vieText.GetComponent<Text> ();
		goldText = goldText.GetComponent<Text> ();
		attackWea = attackWea.GetComponent<Text> ();
		vieMaxText = vieMaxText.GetComponent<Text> ();
		attSpeed = attSpeed.GetComponent<Text> ();
		Error = Error.GetComponent<Text> ();
		nameWeapon = nameWeapon.GetComponent<Text> ();

		weapons = new Dictionary<int, Button> ();
		weapons.Add (0, weapon1);
		weapons.Add (1, weapon2);
		weapons.Add (2, weapon3);
		
		QuitMenu.enabled = false;
		ShopMenu.enabled = false;

		maj ();
		checkWeap ();
	}

	public void chooseWea(int i) {
		if (gold (price[i])) {
			GameObject instance = Instantiate(Resources.Load(armes [i], typeof(GameObject))) as GameObject;
			Player.Instance.weaponInv.Add(i);
			Player.Instance.WeaponDamage = degats[i];
			Player.Instance.nameWeapon = name[i];
		}
		checkWeap ();
		maj ();
	}
	
	public void checkWeap() {
		foreach (int i in Player.Instance.weaponInv) {
			weapons[i].enabled = false;
		}
	}
	
	
	public void ExitPress() {
		QuitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
	}
	
	public void noPress () {
		startText.enabled = true;
		exitText.enabled = true;
		ShopMenu.enabled = false;
		QuitMenu.enabled = false;
		Debug.Log (ShopMenu.isActiveAndEnabled);
	}
	
	public void startShop () {
		ShopMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
	}
	
	public bool gold (int price) {
		if (Player.Instance.Points >= price) {
			Player.Instance.Points -= price;
			Error.text = "Purchase done";
			return true;
		} else {
			Error.text = "Not enough points";
			return false;
		}
	}
	
	public void exitGame () {
		Application.LoadLevel (3);
	}
	
	public void Potion () {
		if (gold (150)) {
			Player.Instance.HP = Player.Instance.HPMax;
			maj();
		}
	}
	
	public void maj() {
		attackWea.text = "Weapon Damage = " + Player.Instance.WeaponDamage;
		vieText.text = "HP = " + Player.Instance.HP + "/" + Player.Instance.HPMax;
		goldText.text = "Gold : " + Player.Instance.Points;
		vieMaxText.text = "HP Max = " + Player.Instance.HPMax;
		attSpeed.text = "Att.Speed = " + Player.Instance.AttSpeed;
		nameWeapon.text = "Weapon = " + Player.Instance.nameWeapon;
	}
	
	public void HpShop () {
		if (gold (150)) {
			Player.Instance.HPMax += Convert.ToInt32(Player.Instance.HPMax * 0.1);
		}
		maj ();
	}
	
	public void AttSpeed () {
		if (gold (150)) {
			Player.Instance.AttSpeed += Convert.ToInt32 (Player.Instance.AttSpeed * 0.1);
		}
		maj ();
	}
}
