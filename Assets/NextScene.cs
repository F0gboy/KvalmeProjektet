using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextScene : MonoBehaviour
{
    public string ThisScene;
    public string SceneName;
    public Button button;

    public GameObject QuizSystemObject;
    private QuizSystem QuizSystemScript;  // Reference to the script that has the list of GameObjects

    // Start is called before the first frame update
    void Start()
    {
        QuizSystemObject = GameObject.Find("Answers");
        QuizSystemScript = QuizSystemObject.GetComponent<QuizSystem>(); // Getting reference to the script

        button.onClick.AddListener(LoadNextScene);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LoadNextScene()
    {
        // Reset the GameObjects before loading the next scene
        if (QuizSystemScript != null)
        {
            QuizSystemScript.ResetGameObjects(); // Call the method to reset GameObjects
        }

        LoadNextSceneFunctionality();
    }

    void LoadNextSceneFunctionality()
    {
        SceneManager.LoadScene(SceneName, LoadSceneMode.Additive);

        SceneManager.UnloadSceneAsync(ThisScene);  // Unload the current scene
    }
}
