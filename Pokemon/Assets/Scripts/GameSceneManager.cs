using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    string curretnEnviromentScene;
    string newScene;
    [SerializeField] Rigidbody playerTransform;

    private void Start()
    {
        DetectCurrentEnviromentScene();
    }

    private void DetectCurrentEnviromentScene()
    {
        for(int i=0; i<SceneManager.sceneCount; i++){
            Scene scene = SceneManager.GetSceneAt(i);

            if(scene.name == "Essential"){
                continue;
            }
            curretnEnviromentScene = scene.name;
        }
    }


    public void SwitchEnviromentScene(string newScene){
        this.newScene = newScene;

        StartCoroutine(SwitchScene());
    }
    
    IEnumerator SwitchScene(){
        AsyncOperation unload = SceneManager.UnloadSceneAsync(curretnEnviromentScene);
        AsyncOperation load = SceneManager.LoadSceneAsync(newScene, LoadSceneMode.Additive);

        curretnEnviromentScene = newScene;

        while(unload.isDone == false){
            yield return new WaitForEndOfFrame();
        }

        while(load.isDone == false){
            yield return new WaitForEndOfFrame();
        }

        Transform waypoint = FindObjectOfType<SceneInfoContainer>().entranceWaypoints[0];
        playerTransform.position = waypoint.position;
        playerTransform.rotation = waypoint.rotation;
        yield return null;
    }
}
