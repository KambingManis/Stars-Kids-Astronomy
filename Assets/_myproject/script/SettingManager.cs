using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour {

	public AudioSource BGMSource;
	public AudioSource[] SFXSource;

	public Sprite[] bgmIcon;
	public Sprite[] sfxIcon;

	public Button bgm_btn;
	public Button sfx_btn;

	public Text BGMText;
	public Text SFXText;

	public int muteBGM;
	public int muteSFX;

	// method start dieksekusi saat pertama kali game dimulai
	private void Start()
	{
		//PlayerPrefs digunakan u/ menyimpan sebuah value
		muteSFX = PlayerPrefs.GetInt("muteSFX",0);
		muteBGM = PlayerPrefs.GetInt("muteBGM",0);

		//menambahkan fungsi / listener method SwitchSFXButton ke dlm button sfx_btn
		sfx_btn.onClick.AddListener(SwitchSFXButton);
		bgm_btn.onClick.AddListener(SwitchBGMButton);
		
		//menjalankan method assignBGMSFXStatus
		AssignBGMSFXStatus();
	}

    //method untuk mengganti status sfx on / off
    public void SwitchSFXButton()
	{
		//mengecek kondisi mute sfx, jika mute sfx bernilai 1, maka kita rubah menjadi 0.
		if (muteSFX == 1) muteSFX = 0;
		else muteSFX = 1;

		AssignBGMSFXStatus();
	}

	public void SwitchBGMButton()
	{
		if (muteBGM == 1) muteBGM = 0;
		else muteBGM = 1;

		AssignBGMSFXStatus();
	}

	//berfungsi u/ mengganti gambar button, dan meng set audio source	
	public void AssignBGMSFXStatus()
	{
		//mengubah gambar sfx button
		sfx_btn.image.sprite = sfxIcon[muteSFX];
		bgm_btn.image.sprite = bgmIcon[muteBGM];

		//mengecek kondisi mute bgm, jika bernilai 1, maka mute bgm source
		if (muteBGM == 1){
			BGMSource.mute = true;
			BGMText.text = "Music Off";
		}
		else{
			BGMSource.mute = false;
			BGMText.text = "Music On";
		}
		//meng set semua sfx
		if (muteSFX == 1){
			//menjalankan fungsi looping u/ meng set semua sfx source
			for(int i = 0; i < SFXSource.Length ;i++){
				SFXSource[i].mute = true;
			}
			SFXText.text = "Sound Off";
		}            
		else{
			for(int i = 0; i < SFXSource.Length ;i++){
				SFXSource[i].mute = false;
			}
			SFXText.text = "Sound On";
		} 

		SaveSetting();
	}

	// method untuk menyimpan data setting
	public void SaveSetting()
	{
		PlayerPrefs.SetInt("muteSFX", muteSFX);
		PlayerPrefs.SetInt("muteBGM", muteBGM);
	}

	public void OpenLink(string link) {
        Application.OpenURL(link);
    }
}
