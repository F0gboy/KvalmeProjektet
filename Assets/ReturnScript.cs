using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnScript : MonoBehaviour
{
    [SerializeField] string SceneName;
    public void ReturnToMenu()
    {
        SceneManager.UnloadScene(SceneName);
    }
}
