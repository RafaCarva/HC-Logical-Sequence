using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MySceneManager : MonoBehaviour
{
    
    public List<Transform> acoes = new List<Transform>();

    public GameObject UIMsg;
    public GameObject player;
    public GameObject coin;

    public float playerForce = 0;
    public int actualInstruction = 0;

    public bool isPlayerRun = false;
    public bool isPlayerWin = false;

    public Text finalCardMessage;

    private void Awake()
    {
        //FInal UI Disable
        UIMsg.gameObject.SetActive(false);
    }
   
    public void LevelStart()
    {
        player.GetComponent<Rigidbody>().isKinematic=false;
        //player.GetComponent<Rigidbody>().velocity = transform.localPosition * playerForce;
        //player.Rotate(Vector3.right * 20f * Time.deltaTime, Space.World);
        //player.GetComponent<Transform>().right = Vector3.right; 
    }
     
    private void FixedUpdate()
    {
        if (isPlayerRun) {
            //player.GetComponent<Rigidbody>().velocity = new Vector3(playerForce,0,0);
            // var locVel = transform.InverseTransformDirection(player.GetComponent<Rigidbody>().velocity);
            // locVel.x = playerForce;
            //player.GetComponent<Rigidbody>().velocity = transform.right * playerForce;
            player.GetComponent<Rigidbody>().transform.Translate(Vector3.right * playerForce * Time.deltaTime, Space.Self);
        }
    }

    public void stageUIBuilder()
    {
        
        
        //set card message
        if (isPlayerWin)
        {
            //Destroy Coin
            Destroy(coin);
            //TODO play collected coin audio

            //Set win message
            this.finalCardMessage.text="Sequência Correta!";
        }
        else
        {
            Destroy(player);
            this.finalCardMessage.text = "Sequência Incorreta!";
        }

        //Set UI Panel visible
        UIMsg.gameObject.SetActive(true);
    }


}
