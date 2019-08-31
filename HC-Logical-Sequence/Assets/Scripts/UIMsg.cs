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

        if (actualSceneName() == "Fase01")
        {
            //to do setar a próxima cena
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene("Fase02");
        }else if (actualSceneName() == "Fase02")
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene("Fase01"); //Todo: fase 03
        }
        
    }

    public void btnPlayAgain()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    private string actualSceneName()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        return sceneName;
    }
}
