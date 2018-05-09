using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soal : MonoBehaviour {
	private string[,] soalb = new string[,]{{"Diantara planet berikut mana ukurannya yang paling besar","matahari","bumi"},
		{"planet manakah yang paling dekat dengan matahari","merkuri","mars"},
		{"Diantara planet berikut mana ukurannya yang paling besar","jupiter","bumi"}};

	public GameObject soal, jawaban1, jawaban2;

	public Sprite matahari, merkuri, venus, bumi, bulan, mars;
	private Sprite gbjawab1, gbjawab2;


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}

	public void shuflesoal(){
		shuffle (soalb);

		soal.GetComponent<Text> ().text = soalb[0,0];
		if (soalb [0, 1].Equals ("matahari")) {
			gbjawab1 = matahari;
		}else if(soalb [0, 1].Equals ("merkuri")){
			gbjawab1 = merkuri;
		}

		if (soalb [0, 2].Equals ("bumi")) {
			gbjawab2 = bumi;
		}else if(soalb [0, 2].Equals ("mars")){
			gbjawab2 = mars;
		}
		jawaban1.GetComponent<Image> ().sprite = gbjawab1;
		jawaban2.GetComponent<Image> ().sprite = gbjawab2;
	}

	public void jawab1(){
		
	}

	public void jawab2(){
	
	}

	public void printsoal(){
		print (soalb[0,1]);
	}

	private void shuffle(string[,] text){
		for(int i = 0; i<text.GetLength(0); i++){
			string tmp = text [i,0];
			int j = Random.Range (i, text.GetLength (0));
			text [i, 0] = text [j, 0];
			text [j, 0] = tmp;

			for (int x = 1; x < text.GetLength (1); x++) {
				string tmp1 = text [i, x];
				text [i, x] = text [j, x];
				text [j, x] = tmp1;
			}

			for (int x = 1; x < text.GetLength (1); x++) {
				string tmp2 = text [i, x];
				int y = Random.Range (x, text.GetLength (1));
				text [i, x] = text [i, y];
				text [i, y] = tmp2;
			}
		}
	}
}
