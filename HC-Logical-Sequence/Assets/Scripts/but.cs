using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class but : MonoBehaviour
{

    public GameObject panel;

    //Seto maualmente o GameObject MySceneManager no palco
    public GameObject MySceneManager;

    //public List<string> acoes = new List<string>();

    public void calcularSlots() {

        playStartAudio();

        //Scene 01
        if (actualSceneName() == "Fase01")
        {
            Debug.Log("Lógica para Fase01");
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

        }else if (actualSceneName() == "Fase02")
        {
            Debug.Log("Lógica para Fase02");
            //Guardar os 10 últimos game objects da lista 
            List<Transform> buttonsTemp = new List<Transform>();
            buttonsTemp.Add(panel.transform.GetChild(10));
            buttonsTemp.Add(panel.transform.GetChild(11));
            buttonsTemp.Add(panel.transform.GetChild(12));
            buttonsTemp.Add(panel.transform.GetChild(13));
            buttonsTemp.Add(panel.transform.GetChild(14));
            buttonsTemp.Add(panel.transform.GetChild(15));
            buttonsTemp.Add(panel.transform.GetChild(16));
            buttonsTemp.Add(panel.transform.GetChild(17));
            buttonsTemp.Add(panel.transform.GetChild(18));
            buttonsTemp.Add(panel.transform.GetChild(19));

            //Ordenar a lista pela posição X
            List<Transform> buttonsTemp2 = buttonsTemp.OrderBy(o => o.transform.position.x).ToList();

            //o list do arquivo MySceneManager.cs recebe os 10 child ordenados pelo valor do eixo X
            MySceneManager.GetComponent<MySceneManager>().acoes = buttonsTemp2;
        }


            //Inicia o level 
            MySceneManager.GetComponent<MySceneManager>().LevelStart();

    }

    private void playStartAudio()
    {
        this.GetComponent<AudioSource>().Play();
    }

    private string actualSceneName() {
        string sceneName = SceneManager.GetActiveScene().name;
        return sceneName;
    }


}
