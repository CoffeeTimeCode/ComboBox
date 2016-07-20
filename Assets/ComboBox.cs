using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ComboBox : MonoBehaviour {

	public string[] _opcoes;
	public Button[] _btns;
	public Text _itemSelecionado;

	public bool _abrir;
	public GameObject _items;

	void Start () {
		for (int i = 0; i < _opcoes.Length; i++) {
			_btns[i].GetComponentInChildren<Text>().text = _opcoes[i];
		}
		_items.SetActive (false);
	}
	
	void Update () {
		_items.SetActive (_abrir);
	}

	public void AbrirItems(){
		_abrir = !_abrir;
	}

}
