using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "SceneController", menuName = "Second2DProject/SceneController", order = 0)]
public class SceneController : ScriptableObject
{
    [SerializeField] private int goToScene;

    public void GotoScene()
    {
        if (goToScene == -1)
        {
            Application.Quit();
        }
        else
        {
            SceneManager.LoadScene(goToScene);
        }
    }
}