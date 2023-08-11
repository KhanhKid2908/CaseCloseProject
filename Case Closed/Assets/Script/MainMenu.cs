using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Database;
using Firebase.Auth;
using System.Threading.Tasks;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button startBtn, settingBtn, quitBtn, backBtn, musicBtn, soundBtn;
    // [SerializeField] Toggle soundTgl;
    [SerializeField] GameObject settingPannel, mainmenuPannel;
    // [SerializeField] Slider music;
    public TMP_Text usernameText;

    [Header("Firebase")]
    public DependencyStatus dependencyStatus;
    public FirebaseAuth auth;
    public FirebaseUser User;
    public DatabaseReference DBreference;

    public static MainMenu Instance;

    void Awake()
    {
        startBtn.onClick.AddListener(OnClickStart);
        settingBtn.onClick.AddListener(OnClickSetting);
        backBtn.onClick.AddListener(OnClickBack);
        // musicBtn.onClick.AddListener(OnClickMusic);
        // quitBtn.onClick.AddListener(OnClickQuit);
        // soundTgl.onValueChanged.AddListener(SoundToggle);

        if(!Instance) //if (Instance == null)
        {
            Instance = this;
        }
        // bool isSound = PlayerPrefs.GetInt("Sound") == 1? true : false;
        // float isMusic = PlayerPrefs.GetFloat("Sound");
    }

    // Load Intro Cutscene
    public void OnClickStart()
    {
        SceneManager.LoadScene("IntroCutscene");
    }

    // Load pannel Setting
    public void OnClickSetting()
    {
        settingPannel.SetActive(true);
        mainmenuPannel.SetActive(false);
    }

    // public void OnClickMusic()
    // {
    //     if (AudioListener.volume == 0)
    //     {
    //         AudioListener.volume = 1;
    //         PlayerPrefs.SetInt("Music_Vol", 1);
    //     } else {
    //         AudioListener.volume = 0;
    //         PlayerPrefs.SetInt("Music_Vol", 0);
    //     }
    // }

    // Load pannel Main Menu
    public void OnClickBack()
    {
        settingPannel.SetActive(false);
        mainmenuPannel.SetActive(true);
    }

    private IEnumerator LoadUserData()
    {
        //Get the currently logged in user data
        Task<DataSnapshot> DBTask = DBreference.Child("users").Child(User.UserId).GetValueAsync();

        yield return new WaitUntil(predicate: () => DBTask.IsCompleted);

        if (DBTask.Exception != null)
        {
            Debug.LogWarning(message: $"Failed to register task with {DBTask.Exception}");
        }
        else if (DBTask.Result.Value == null)
        {
            //No data exists yet
            usernameText.text ="No data available";
        }
        else
        {
            //Data has been retrieved
            DataSnapshot snapshot = DBTask.Result;

            usernameText.text = snapshot.Child("users").Value.ToString();
        }
    }

    private IEnumerator UpdateUsernameDatabase(string _username)
    {
        //Set the currently logged in user username in the database
        var DBTask = DBreference.Child("users").Child(User.UserId).Child("username").SetValueAsync(_username);

        yield return new WaitUntil(predicate: () => DBTask.IsCompleted);

        if (DBTask.Exception != null)
        {
            Debug.LogWarning(message: $"Failed to register task with {DBTask.Exception}");
        }
        else
        {
            //Database username is now updated
        }
    }

    private IEnumerator UpdateUsernameAuth(string _username)
    {
        //Create a user profile and set the username
        UserProfile profile = new UserProfile { DisplayName = _username };

        //Call the Firebase auth update user profile function passing the profile with the username
        var ProfileTask = User.UpdateUserProfileAsync(profile);
        //Wait until the task completes
        yield return new WaitUntil(predicate: () => ProfileTask.IsCompleted);

        if (ProfileTask.Exception != null)
        {
            Debug.LogWarning(message: $"Failed to register task with {ProfileTask.Exception}");
        }
        else
        {
            //Auth username is now updated
        }        
    }


    void Start() 
    {
         StartCoroutine(UpdateUsernameAuth(usernameText.text));
         StartCoroutine(UpdateUsernameDatabase(usernameText.text));

        if (!PlayerPrefs.HasKey("Music_Vol"))
        {
            PlayerPrefs.SetFloat("Music_Vol", 1);
        } else {
            PlayerPrefs.GetFloat("Music_Vol");
        }

        settingPannel.SetActive(false);
        mainmenuPannel.SetActive(true);
    }

}
