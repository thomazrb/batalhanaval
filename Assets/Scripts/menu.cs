using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	public void Sair () {
		Application.Quit();
	}

	public void Novo () {
		Application.LoadLevel("jogo");
	}
}
