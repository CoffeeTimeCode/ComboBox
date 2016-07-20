using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Item : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}

	public void EscolherOpcao (){
		GameObject.Find ("ComboBox").GetComponent<ComboBox>()._itemSelecionado.text = this.gameObject.GetComponentInChildren<Text>().text;
		GameObject.Find ("ComboBox").GetComponent<ComboBox> ()._abrir = false;
	}

}
