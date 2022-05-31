using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private int coinCount;

    private void Start()
    {
        coinCount = 0;
    }

    public Text textComponent;

    public void AddCoinCount()
    {
        coinCount=coinCount+1;
        Debug.Log("coinCount:"+coinCount);
        textComponent.text = "CoinCount : " + coinCount;
    }
    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
}
