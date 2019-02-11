using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class levelSelect : MonoBehaviour {

    private void Awake()
    {
        Cursor.visible = true;
    }

    public void StartLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void Options()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
