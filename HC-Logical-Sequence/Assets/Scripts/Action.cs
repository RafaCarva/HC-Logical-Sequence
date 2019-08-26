using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{

    public int instructionPosition;

    public GameObject MySceneManager;
    public GameObject Player;


    void OnTriggerStay(Collider other)
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
         //pegar a posição do array de instruções 
        Debug.Log("Entrouuuuuuu");

        this.Player.GetComponent<Rigidbody>()
            .AddForce(Vector3.up * 3, ForceMode.Acceleration);
    }
}


//other.rigidbody.AddForce(Vector3.up * hoverForce, ForceMode.Acceleration);