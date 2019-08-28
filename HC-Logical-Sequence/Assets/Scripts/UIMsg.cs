using UnityEngine;
using UnityEngine.SceneManagement;


public class UIMsg : MonoBehaviour
{
    public MySceneManager mySceneManager;


    public void btnMakeDecision()
    {
        if (mySceneManager.isPlayerWin) {
            btnNextLevel();
        }
        else
        {
            btnPlayAgain();
        }
    }


    public void btnNextLevel()
    {
        //to do setar a próxima cena
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("Fase02");
    }

    public void btnPlayAgain()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);

    }
}
