using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMsg : MonoBehaviour
{
    public void btnMakeDecision()
    {
        //if succsses, call btnNextLevel
        //if fail, call btnPlayAgain

    }


    public void btnNextLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);

    }

    public void btnPlayAgain()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);

    }
}
