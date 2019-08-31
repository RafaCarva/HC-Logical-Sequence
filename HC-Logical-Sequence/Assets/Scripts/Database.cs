using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Database : MonoBehaviour
{
    public MySceneManager mySceneManager;

    public GameObject okImage;
    public InputField inputFieldName;
    public InputField inputFieldEmail;

    private string secretKey = "mySecretKey";
    private string addScoreURL = "https://hclogicalsequence.000webhostapp.com/addscore.php?";

    //public string name, email;
    //public int score;

    private void Awake()
    {
        okImage.gameObject.SetActive(false);
    }

    public void CallDatabae()
    {
        string name = inputFieldName.text;
        string email = inputFieldEmail.text;
        int score = mySceneManager.playerScore;
        StartCoroutine(PostScores(name,email,score));
    }

    // remember to use StartCoroutine when calling this function!
    IEnumerator PostScores(string name, string email, int score)
    {
        string post_url = addScoreURL + "name=" + WWW.EscapeURL(name) + "&email=" + WWW.EscapeURL(email) + "&score=" + score;
        // Post the URL to the site and create a download object to get the result.
        WWW hs_post = new WWW(post_url);
        yield return hs_post; // Wait until the download is done
        if (hs_post.error != null)
        {
            Debug.Log("There was an error posting the high score: " + hs_post.error);
        }
        else
        {
            okImage.gameObject.SetActive(true);
        }
    }


}