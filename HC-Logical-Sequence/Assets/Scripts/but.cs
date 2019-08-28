using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class but : MonoBehaviour
{

    public GameObject panel;

    //Seto maualmente o GameObject MySceneManager no palco
    public GameObject MySceneManager;

    //public List<string> acoes = new List<string>();

    public void calcularSlots() {

        //Guardar os 4 últimos game objects da lista 
		List<Transform> buttonsTemp = new List<Transform>();
        buttonsTemp.Add(panel.transform.GetChild(4));
		buttonsTemp.Add(panel.transform.GetChild(5));
		buttonsTemp.Add(panel.transform.GetChild(6));
		buttonsTemp.Add(panel.transform.GetChild(7));

		//Ordenar a lista pela posição X
		List<Transform> buttonsTemp2 = buttonsTemp.OrderBy(o => o.transform.position.x).ToList();

        //o list do arquivo MySceneManager.cs recebe os 4 child ordenados pelo valor do eixo X
		MySceneManager.GetComponent<MySceneManager>().acoes = buttonsTemp2;

        //Debug, descomente para conferir os comandos capturados
        //foreach (Transform objet in buttonsTemp2)
       // {
        //    Debug.Log("Ação: " + objet);
       // }

        //Inicia o level 
        MySceneManager.GetComponent<MySceneManager>().LevelStart();

    }

}
