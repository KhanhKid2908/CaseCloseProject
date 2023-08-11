using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayCutscene : MonoBehaviour
{
    public GameObject cutSceneCam;
    [SerializeField] Button skipBtn;

    void Awake()
    {
        skipBtn.onClick.AddListener(OnClickSkip);
    }

    public void OnClickSkip()
    {
        SceneManager.LoadScene("ChooseCase");
    }

    void SwitchToPlayerCam()
    {
        SceneManager.LoadScene("ChooseCase");
    }

    void Start() 
    {
        cutSceneCam.SetActive(true);
        Invoke("SwitchToPlayerCam", 144f);        
    }
}