using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

    //UI
    public Text finalCardMessage;
    public Text finalButtonLabel;
    public Text finalStarsLabel;
    public GameObject UIStars;
    public Sprite[] starsImage;


    private void Awake()
    {
        //Final UI Disable
        UIMsg.gameObject.SetActive(false);
        UIStars.gameObject.SetActive(false);
        finalStarsLabel.gameObject.SetActive(false);

    }
   
    public void LevelStart()
    {
        //Player fall 
        player.GetComponent<Rigidbody>().isKinematic=false;
    }
     
    private void FixedUpdate()
    {
        if (isPlayerRun) {
            //Add constant velocity in x axis player
            player.GetComponent<Rigidbody>().transform.Translate(Vector3.right * playerForce * Time.deltaTime, Space.Self);
        }

        if (Input.GetMouseButtonDown(0))
        {
            //Play "Mouse Click" sound
            this.GetComponent<AudioSource>().Play();
        }
    }

    public void stageUIBuilder()
    {
        //set card message
        if (isPlayerWin)
        {
            if (coin)
            {
            //TODO play collected coin audio
            coin.GetComponent<AudioSource>().Play();
            }
            
            //Destroy Coin
            Destroy(coin,0.5f);
            

            //Set win message
            this.finalCardMessage.text="Sequência Correta!";
            this.finalButtonLabel.text = "Próxima fase!";

            //stage 1. 3 star logic
            if(SceneManager.GetActiveScene().name == "Fase01"  && actualInstruction <= 4 )
            {
                this.finalStarsLabel.text = "Você ganhou 3 Estrelas. Parabéns!";
                this.UIStars.GetComponent<Image>().sprite = starsImage[3];
            }else //stage 2. 2 star logic
            if (SceneManager.GetActiveScene().name == "Fase02" && actualInstruction == 7)
            {
                this.finalStarsLabel.text = "Você ganhou 2 Estrelas. Parabéns!\nDica: é possível usar menos comandos!";
                this.UIStars.GetComponent<Image>().sprite = starsImage[2];
            }
            else //stage 2. 3 star logic
            if (SceneManager.GetActiveScene().name == "Fase02" && actualInstruction < 7)
            {
                this.finalStarsLabel.text = "Você ganhou 3 Estrelas. Parabéns!";
                this.UIStars.GetComponent<Image>().sprite = starsImage[3];
            }
        }
        else //player lose
        {
            Destroy(player);
            this.finalCardMessage.text = "Sequência Incorreta!";
            this.finalButtonLabel.text = "Jogar novamente!";
        }

        //Set UI Panel visible
        UIMsg.gameObject.SetActive(true);
        UIStars.gameObject.SetActive(true);
        finalStarsLabel.gameObject.SetActive(true);
    }


}
