using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{

    public int instructionPosition;

    public GameObject MySceneManager;
    public GameObject Player;
    private float LocalPlayerForce=0;


    private void OnTriggerEnter(Collider other)
    {
        //permite a adiçãod e velocidade no fixedUpdate de MySceneManage
        MySceneManager.GetComponent<MySceneManager>().isPlayerRun=true;

        //Recupera a intensidade da força do script MySceneManager
        this.LocalPlayerForce = MySceneManager.GetComponent<MySceneManager>().playerForce;

        //Recuperar a instrução atual (ela começa em 0 e recebe +1 no end trigger)
        int acaoAtual = MySceneManager.GetComponent<MySceneManager>().actualInstruction;

        //Recupera o list de transforms que contem as escolhas do usuário
        List<Transform> acoesLocais = MySceneManager.GetComponent<MySceneManager>().acoes;

        switch (acoesLocais[acaoAtual].name)
        {
            case "seta-baixo":
                Debug.Log("Comando executado: " + acoesLocais[acaoAtual].name);
                //Rotate player at back diretction
                other.GetComponent<Transform>().right = Vector3.back;

                break;

            case "seta-cima":
                Debug.Log("Comando executado: " + acoesLocais[acaoAtual].name);
                //Rotate player at up diretction
                other.GetComponent<Transform>().right = Vector3.forward;
                break;

            case "seta-direita":
                Debug.Log("Comando executado: " + acoesLocais[acaoAtual].name);
                //Rotate player at rigth diretction
                other.GetComponent<Transform>().right = Vector3.right;
                break;

            case "seta-esquerda":
                Debug.Log("Comando executado: " + acoesLocais[acaoAtual].name);
                //Rotate player at left diretction
                other.GetComponent<Transform>().right = Vector3.left;
                break;

            default:
                Debug.Log("Default: " + acoesLocais[acaoAtual].name);
                Debug.Log("Comando não reconhecido");
                break;
        }

        

    }
    private void OnTriggerExit(Collider other)
    {
        MySceneManager.GetComponent<MySceneManager>().actualInstruction += 1;
    }
}
