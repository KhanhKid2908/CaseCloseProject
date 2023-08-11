using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConcludeController : MonoBehaviour
{
    public GameObject falsePn, truePn, leaderboardPn;
    public TimeCount timeCount;

    public void OnClickTrueOption()
    {
        Debug.Log("Your option is correct");
        truePn.SetActive(true);
        timeCount.isTrue = false;
        Debug.Log(timeCount.countDownPoint);
    }

    public void OnClickFalseOption()
    {
        Debug.Log("Your option is not correct");
        timeCount.isTrue = false;
        Debug.Log(timeCount.countDownPoint);
        falsePn.SetActive(true);
    }

    public void OnClickLeaderboard()
    {
        leaderboardPn.SetActive(true);
    }

    public void OnClickMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnClickNextCase()
    {
        SceneManager.LoadScene("Case2");
    }

    public void OnClickTryAgain()
    {
        SceneManager.LoadScene("Case1");
    }
}
