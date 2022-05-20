using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "SceneController", menuName = "Second2DProjet/SceneController", order = 0)]
public class SceneController : ScriptableObject
{
    [SerializeField] int goToScene = 0;

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
