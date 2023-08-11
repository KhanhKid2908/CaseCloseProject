using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChoosingCase : MonoBehaviour
{
    public GameObject cutSceneCam, canvas, cutSceneCam2;
    public Button case1Btn;

    void SwitchToPlayerCam()
    {
        cutSceneCam.SetActive(false);
        canvas.SetActive(true);
        cutSceneCam2.SetActive(false);
    }

    void LoadCase1()
    {
        SceneManager.LoadScene("CutSceneLevel1");    
    }

    public void OnClickCase1()
    {
        canvas.SetActive(false);
        cutSceneCam.SetActive(false);
        cutSceneCam2.SetActive(true);
        Invoke("LoadCase1", 2f);
    }

    void Awake() 
    {
        case1Btn.onClick.AddListener(OnClickCase1);    
    }

    // Start is called before the first frame update
    void Start() 
    {
        cutSceneCam2.SetActive(false);
        cutSceneCam.SetActive(true);
        canvas.SetActive(false);
        Invoke("SwitchToPlayerCam", 2f);         
    }
}
