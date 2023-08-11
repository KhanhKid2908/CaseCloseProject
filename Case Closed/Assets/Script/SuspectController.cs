using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuspectController : MonoBehaviour
{
    public Button sus1Btn, sus2Btn, sus3Btn ;
    public GameObject sus1Info, sus2Info, sus3Info, susPannel, blurBg;

    public void OnClickClosePanel()
    {
        sus2Info.SetActive(false);
        sus1Info.SetActive(false);
        sus3Info.SetActive(false);
        blurBg.SetActive(false);
        susPannel.SetActive(true);
    }

    public void OnClickClose()
    {
        susPannel.SetActive(false);
    }

    public void OnClickSus1()
    {
        sus1Info.SetActive(true);
        sus2Info.SetActive(false);
        sus3Info.SetActive(false);
        susPannel.SetActive(false);
        blurBg.SetActive(true);
    }

    public void OnClickSus2()
    {
        sus2Info.SetActive(true);
        sus1Info.SetActive(false);
        sus3Info.SetActive(false);
        susPannel.SetActive(false);
        blurBg.SetActive(true);
    }

    public void OnClickSus3()
    {
        sus3Info.SetActive(true);
        sus2Info.SetActive(false);
        sus1Info.SetActive(false);
        susPannel.SetActive(false);
        blurBg.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        sus1Btn.onClick.AddListener(OnClickSus1);
        sus2Btn.onClick.AddListener(OnClickSus2);
        sus3Btn.onClick.AddListener(OnClickSus3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
