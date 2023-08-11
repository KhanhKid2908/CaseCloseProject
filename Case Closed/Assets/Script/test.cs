using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class test : MonoBehaviour
{
    public GameObject testImg;
    public TimeCount timeCount;

    public void OnClickTest()
    {
        timeCount.isTrue = false;
        Debug.Log(timeCount.countDownPoint);
    }
}
