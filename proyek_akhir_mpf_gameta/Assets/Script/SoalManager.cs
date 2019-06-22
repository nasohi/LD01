using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoalManager : MonoBehaviour {

	[System.Serializable]
	public class Soal {

		[TextArea]
		[Header("Soal")]
		public string soal;

		[Header("Pilihan untuk Jawaban")]
		public string pilA;
		public string pilB, pilC, pilD;

		[Header("Kunci Jawaban")]
		public bool A; 
		public bool B, C, D;

	}

	public GameObject ulangBtn, mainMenuBtn;
	public float waktu;
	public int skor;
	private int nilaiAcak;
	Text textSoal, textA, textB, textC, textD, textWaktu;
	public List<Soal> kumpulanSoal;

	// Use this for initialization
	void Start () {
		textSoal = GameObject.Find ("TextSoal").GetComponent<Text>();
		textA = GameObject.Find ("A").GetComponent<Text>();
		textB = GameObject.Find ("B").GetComponent<Text>();
		textC = GameObject.Find ("C").GetComponent<Text>();
		textD = GameObject.Find ("D").GetComponent<Text>();

		textWaktu = GameObject.Find ("TextWaktu").GetComponent<Text>();

		nilaiAcak = Random.Range (0, kumpulanSoal.Count);
	}
	
	// Update is called once per frame
	void Update () {
		textWaktu.text = "Time : " + waktu.ToString("0.0");
		waktu -= Time.deltaTime; 

		if (waktu <= 0) {
			kumpulanSoal.RemoveAt (nilaiAcak);
			waktu = 15;
			nilaiAcak = Random.Range (0, kumpulanSoal.Count);
		}

		if (kumpulanSoal.Count > 0) {
			textSoal.text = kumpulanSoal [nilaiAcak].soal;
			textA.text = kumpulanSoal [nilaiAcak].pilA;
			textB.text = kumpulanSoal [nilaiAcak].pilB;
			textC.text = kumpulanSoal [nilaiAcak].pilC;
			textD.text = kumpulanSoal [nilaiAcak].pilD;
		} else {
			mainMenuBtn.SetActive (true);
			ulangBtn.SetActive (true);
			textSoal.text = "Skor : " + skor;

			//GameObject.Find("/Canvas/Panel/TextWaktu").SetActive(false);
			//GameObject.Find("Panel").SetActive(false); 
		}
	}

	public void CekJawaban(string jawaban) {
		if (kumpulanSoal [nilaiAcak].A == true && jawaban == "a") {
			skor += 5;
		} 

		if (kumpulanSoal [nilaiAcak].B == true && jawaban == "b") {
			skor += 5;
		} 

		if (kumpulanSoal [nilaiAcak].C == true && jawaban == "c") {
			skor += 5;
		} 

		if (kumpulanSoal [nilaiAcak].D == true && jawaban == "d") {
			skor += 5;
		} 

		kumpulanSoal.RemoveAt (nilaiAcak);
		nilaiAcak = Random.Range (0, kumpulanSoal.Count);
		waktu = 15;
	}

	public void Ulang() {
		Application.LoadLevel (Application.loadedLevel);
	}

	public void KembaliKeMainMenu() {
		UnityEngine.SceneManagement.SceneManager.LoadScene ("category");
	}
} 
