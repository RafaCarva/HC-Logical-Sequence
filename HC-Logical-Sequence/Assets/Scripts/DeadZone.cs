using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public MySceneManager mySceneManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Jogador, perdeu!");
            mySceneManager.isPlayerRun = false;

            //stageUIBuilder é a função que vai montar a UI de acordo com o resultado da partida.
            mySceneManager.stageUIBuilder();
        }
    }
}
