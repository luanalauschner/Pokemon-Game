using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneInteract : MonoBehaviour
{
    //[SerializeField] string targetScene;
    public void ChangeScene()
    {
        //FindObjectOfType<GameSceneManager>().SwitchEnviromentScene(targetScene);
        SceneManager.LoadScene("Combat");
    }
}
