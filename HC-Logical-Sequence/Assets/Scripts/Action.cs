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

                //other.attachedRigidbody.velocity = Vector3.zero;
                // other.attachedRigidbody.angularVelocity = Vector3.zero;
                //other.attachedRigidbody.AddForce(Vector3.back * LocalPlayerForce, ForceMode.Acceleration);
                //other.GetComponent<Transform>().Rotate(0,90, 0);
                //other.GetComponent<Transform>().Rotate(0, 90, 0, Space.World);
                //other.GetComponent<Transform>().Rotate(Vector3.down * 20f * Time.deltaTime, Space.World);
                other.GetComponent<Transform>().right = Vector3.back;

                break;

            case "seta-cima":
                Debug.Log("Comando executado: " + acoesLocais[acaoAtual].name);
                //other.attachedRigidbody.AddForce(Vector3.forward * LocalPlayerForce, ForceMode.Acceleration);
                //other.attachedRigidbody.AddForce(Vector3.forward * LocalPlayerForce, ForceMode.Acceleration);
                //other.GetComponent<Transform>().Rotate(0,-90,0, Space.World);
                //other.GetComponent<Transform>().Rotate(Vector3.up * 20f * Time.deltaTime, Space.Self);
                //other.GetComponent<Transform>(). = Vector3.right;
                other.GetComponent<Transform>().right = Vector3.forward;
                break;

            case "seta-direita":
                Debug.Log("Comando executado: " + acoesLocais[acaoAtual].name);
                //other.attachedRigidbody.AddForce(Vector3.right * LocalPlayerForce, ForceMode.Acceleration);
                //other.attachedRigidbody.AddForce(Vector3.right * LocalPlayerForce, ForceMode.Acceleration);
                //other.GetComponent<Transform>().Rotate(0,360, 0, Space.Self);
                //other.GetComponent<Transform>().Rotate(Vector3.right * 20f * Time.deltaTime, Space.World);
                //other.GetComponent<Transform>().Rotate(Vector3.right, Space.World);
                other.GetComponent<Transform>().right = Vector3.right;
                break;

            case "seta-esquerda":
                Debug.Log("Comando executado: " + acoesLocais[acaoAtual].name);
                //other.attachedRigidbody.AddForce(Vector3.left * LocalPlayerForce, ForceMode.Acceleration);
                //other.attachedRigidbody.AddForce(Vector3.forward * LocalPlayerForce, ForceMode.Acceleration);
                //other.GetComponent<Transform>().Rotate(0, 180, 0, Space.World);
                //other.GetComponent<Transform>().Rotate(Vector3.left * 20f * Time.deltaTime, Space.Self);
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

//this.Player.GetComponent<Rigidbody>().AddForce(Vector3.up * 3, ForceMode.Acceleration);
//other.rigidbody.AddForce(Vector3.up * hoverForce, ForceMode.Acceleration);


/*
 foreach(Transforma objet in ObjetoAOcultar)
{
    objet.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, alphaLevel);
}

 */
