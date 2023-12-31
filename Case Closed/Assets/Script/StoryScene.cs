using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewStoryScene", menuName = "Data/New Story Scene")]
[System.Serializable]
public class StoryScene : ScriptableObject
{
    public List<Sentence> sentences;
    public StoryScene nextScene;

    [System.Serializable]
    public struct Sentence
    {
        public Speaker speaker;
        
        [TextArea]
        public string text;
    }
}
