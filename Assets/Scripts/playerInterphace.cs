using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class playerInterphace : MonoBehaviour {

    public GameObject manager = null;
    public playerMovement movement = null;
    private bool toggleBool = false;

    private void Start()
    {
        if(manager != null)
        {
            Cursor.visible = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = !Cursor.visible;
            movement.enabled = !movement.enabled;
            toggleBool = !toggleBool;
            manager.SetActive(toggleBool);

        }

    }

    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void Continue()
    {
        Cursor.visible = !Cursor.visible;
        movement.enabled = !movement.enabled;
        toggleBool = !toggleBool;
        manager.SetActive(toggleBool);

    }

    public void LeaderBoard()
    {
        SceneManager.LoadScene("leaderBoard");
    }

    public void Levels()
    {
        SceneManager.LoadScene("levels");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
