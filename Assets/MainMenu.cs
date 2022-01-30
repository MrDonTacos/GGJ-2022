using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    enum Scene
    {
        BattleField = 1,
        HighScores,
        Options,
        Help, 
        Credits
    }

    public void LoadScene(int button)
    {
        SceneManager.LoadScene(((Scene)button).ToString());
    }
}
