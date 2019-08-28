using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : MonoBehaviour
{
    public MySceneManager mySceneManager;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        //Interrompe o movimento do player
        mySceneManager.isPlayerRun = false;

        mySceneManager.isPlayerWin = true;

        //stageUIBuilder é a função que vai montar a UI de acordo com o resultado da partida.
        mySceneManager.stageUIBuilder();

    }

    private void OnTriggerStay(Collider other)
    {
        //other.GetComponent<Rigidbody>().AddForce(0,10,0);
        other.GetComponent<Rigidbody>().AddForce(0, 0.25f, 0, ForceMode.Impulse);
    }
}
