using UnityEngine;
using System.Collections;

public class GeraGrids : MonoBehaviour {

	private int posX, posY;
	public GameObject ObjetoAgua;

	// Use this for initialization
	void Start () {
		for (posX = -10; posX <=10 ; posX++)
			for (posY =-5; posY <=5; posY++)
				Instantiate(ObjetoAgua, new Vector3(posX, posY, 0), Quaternion.identity);
	
	}
}
