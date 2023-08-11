using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCount : MonoBehaviour
{
    public int countDownPoint = 100;
    public bool isTrue = true;

    private IEnumerator UpdatePoint()
    {
        while (isTrue && countDownPoint >= 0)
        {   
            yield return new WaitForSeconds(1f);

            countDownPoint --;
        }
    }

    private void Start() 
    {
        StartCoroutine(UpdatePoint());
    }
}
