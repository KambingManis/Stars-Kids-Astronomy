using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kunci : MonoBehaviour {

	public static string lockmercury = "mercury", lockvenus = "venus", lockbumi = "bumi", lockbulan = "bulan", lockmars = "mars";
	public GameObject gbrlockmercury, gbrlockvenus, gbrlockbumi, gbrlockbulan, gbrlockmars;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!PlayerPrefs.GetString(lockmercury).Equals("lock")){
			gbrlockmercury.SetActive(false);
		}
		if(!PlayerPrefs.GetString(lockvenus).Equals("lock")){
			gbrlockvenus.SetActive(false);
		}
		if(!PlayerPrefs.GetString(lockbumi).Equals("lock")){
			gbrlockbumi.SetActive(false);
		}
		if(!PlayerPrefs.GetString(lockbulan).Equals("lock")){
			gbrlockbulan.SetActive(false);
		}
		if(!PlayerPrefs.GetString(lockmars).Equals("lock")){
			gbrlockmars.SetActive(false);
		}
	}

	public void mulaibaru(){
		if(!PlayerPrefs.GetString("NewGame").Equals("new game")){
			PlayerPrefs.SetString("NewGame","new game");
			PlayerPrefs.SetString(lockmercury,"lock");
			PlayerPrefs.SetString(lockvenus,"lock");
			PlayerPrefs.SetString(lockbumi,"lock");
			PlayerPrefs.SetString(lockbulan,"lock");
			PlayerPrefs.SetString(lockmars,"lock");
		}else{
			PlayerPrefs.GetString("NewGame");
			PlayerPrefs.GetString(lockmercury);
			PlayerPrefs.GetString(lockvenus);
			PlayerPrefs.GetString(lockbumi);
			PlayerPrefs.GetString(lockbulan);
			PlayerPrefs.GetString(lockmars);
		}
		/*PlayerPrefs.SetString("NewGame","new game");
			PlayerPrefs.SetString(lockmercury,"lock");
			PlayerPrefs.SetString(lockvenus,"lock");
			PlayerPrefs.SetString(lockbumi,"lock");
			PlayerPrefs.SetString(lockbulan,"lock");
			PlayerPrefs.SetString(lockmars,"lock");*/
	}
	public void suara3matahari(){
		PlayerPrefs.SetString(lockmercury,"unlock");
	}
	public void suara3mercury(){
		PlayerPrefs.SetString(lockvenus,"unlock");
	}
	public void suara3venus(){
		PlayerPrefs.SetString(lockbumi,"unlock");
	}
	public void suara3bumi(){
		PlayerPrefs.SetString(lockbulan,"unlock");
	}
	public void suara3bulan(){
		PlayerPrefs.SetString(lockmars,"unlock");
	}
	public void suara3mars(){
		//PlayerPrefs.SetString(lockquiz,"unlock");
	}
}
