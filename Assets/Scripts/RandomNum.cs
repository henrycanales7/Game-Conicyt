using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomNum : MonoBehaviour {

	public Image UIImagen;
	public Image UIImagen2;
	public Image UISigno;
	public Button Opcion1;
	public Button Opcion2;
	public Button Opcion3;
	// Use this for initialization
	void Start () {
		UIImagen = GameObject.Find("A").GetComponent<Image>();
		int n = Random.Range (1, 11);
		UIImagen.sprite = Resources.Load<Sprite>("Sprites/"+n);
		int n2 = Random.Range (1, 11);
		UIImagen2.sprite = Resources.Load<Sprite>("Sprites/"+n2);
		int n3 = Random.Range (1, 3);
		int respuesta = 0;
		if (n3 == 1) {
			UISigno.sprite = Resources.Load<Sprite> ("Sprites/+");
			respuesta = n + n2;
		} else {
			UISigno.sprite = Resources.Load<Sprite> ("Sprites/-");
			respuesta = n - n2;
			if(respuesta < 0 )
			{
				respuesta = respuesta * -1;
			}
		}

		int n4 = Random.Range (1, 4);
		if (n4 == 1) {
			Opcion1.image.sprite = Resources.Load<Sprite> ("Sprites/" + respuesta);
		} else {
			Opcion1.image.sprite = Resources.Load<Sprite> ("Sprites/" + Random.Range (1, 11));
		}
		if (n4 == 2) {
			Opcion2.image.sprite = Resources.Load<Sprite> ("Sprites/" + respuesta);
		}else {
			Opcion2.image.sprite = Resources.Load<Sprite> ("Sprites/" + Random.Range (1, 11));
		}
		if (n4 == 3) {
			Opcion3.image.sprite = Resources.Load<Sprite> ("Sprites/" + respuesta);
		}else {
			Opcion3.image.sprite = Resources.Load<Sprite> ("Sprites/" + Random.Range (1, 11));
		}
	}
	
	// Update is called once per frame
	void Update () {

	



	
	}
}
