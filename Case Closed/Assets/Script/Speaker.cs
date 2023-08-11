using UnityEngine;

[CreateAssetMenu(fileName = "NewSpeaker", menuName = "Data/New Speakers")]
[System.Serializable]
public class Speaker : ScriptableObject
{
    public string speakerName;
    public Sprite charIcon;
}