using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySceneManager : MonoBehaviour
{
    public GameObject UIMsg;
    public List<Transform> acoes = new List<Transform>();
    public GameObject player;
    public float playerForce;
    public int actualInstruction = 0;

    private void Awake()
    {
        //Desativa a UI de MSG 
        UIMsg.gameObject.SetActive(false);
    }

    public void LevelStart()
    {
        player.GetComponent<Rigidbody>().isKinematic=false;

    }
}
