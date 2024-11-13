using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string SceneName;
    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneName, LoadSceneMode.Additive);
    }

}
