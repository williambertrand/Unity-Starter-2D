using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayGame()
    {
        // TODO: If your game does not have GameScene as the scene directly after the menu scene, change the next line
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
