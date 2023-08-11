using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public StoryScene currentScene;
    public DialogueController dialogue;
    public GameObject dialoguePannel;

    // Start is called before the first frame update
    void Start()
    {
        dialogue.PlayeScene(currentScene);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if(dialogue.IsCompleted())
            {
                if(dialogue.IsLastSentence())
                {
                    // currentScene = currentScene.nextScene;
                    // dialogue.PlayeScene(currentScene);
                    dialoguePannel.SetActive(false);
                }
                dialogue.PlayNextSentence();
            }
        }
    }
}
