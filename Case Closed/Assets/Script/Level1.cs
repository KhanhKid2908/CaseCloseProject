using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    public GameObject cutSceneCam;
    [SerializeField] Button homeBtn, hintBtn, susBtn, infoBtn, closeBtn;
    public GameObject infoPannel, susPannel;
    public ButtonCheck buttonCheck;

    public void OnClickHome()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnClickInfo()
    {
        infoPannel.SetActive(true);
        susPannel.SetActive(false);
    }
    public void OnClickClosePanel()
    {
        infoPannel.SetActive(false);
    }

    public void OnClickSus()
    {
        susPannel.SetActive(true);
        infoPannel.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        homeBtn.onClick.AddListener(OnClickHome);
        infoBtn.onClick.AddListener(OnClickInfo);
        susBtn.onClick.AddListener(OnClickSus);
        closeBtn.onClick.AddListener(OnClickClosePanel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
