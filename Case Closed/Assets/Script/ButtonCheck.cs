using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCheck : MonoBehaviour
{
    public bool button1Hit = false;
    public bool button2Hit = false;
    public bool button3Hit = false;
    public bool button4Hit = false;

    public bool AllButtonsHit()
    {
        return button1Hit && button2Hit && button3Hit && button4Hit;
    }
}