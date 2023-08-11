using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClueController : MonoBehaviour
{
    public Button clue1Btn, clue2Btn, clue3Btn, clue4Btn;
    public GameObject clue1Pannel, clue2Pannel, clue3Pannel, clue4Pannel, resultOption, concludePannel;
    public ButtonCheck buttonCheck;

    public void OnClickClue1()
    {
        Debug.Log("show clue1");
        clue1Pannel.SetActive(true);
        buttonCheck.button1Hit = true;
    }

    public void OnClickClue2()
    {
        Debug.Log("show clue2");
        clue2Pannel.SetActive(true);
        buttonCheck.button2Hit = true;
    }

    public void OnClickClue3()
    {
        Debug.Log("show clue3");
        clue3Pannel.SetActive(true);
        buttonCheck.button3Hit = true;
    }

    public void OnClickClue4()
    {
        Debug.Log("show clue4");
        clue4Pannel.SetActive(true);
        buttonCheck.button4Hit = true;
    }

    public void OnClickConclude()
    {
        Debug.Log("Conclude button hit");
        concludePannel.SetActive(true);
    }

    public void OnClickClosePn()
    {
        concludePannel.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        clue1Pannel.SetActive(false);
        clue2Pannel.SetActive(false);
        clue3Pannel.SetActive(false);
        clue4Pannel.SetActive(false);
        clue1Btn.onClick.AddListener(OnClickClue1);
        clue2Btn.onClick.AddListener(OnClickClue2);
        clue3Btn.onClick.AddListener(OnClickClue3);
        clue4Btn.onClick.AddListener(OnClickClue4);
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonCheck.AllButtonsHit())
        {
            resultOption.SetActive(true);
        }
    }
}
