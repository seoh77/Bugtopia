using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButtonController : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
