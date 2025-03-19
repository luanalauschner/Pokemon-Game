using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostDebugMessage : MonoBehaviour
{
    [SerializeField] string message;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Post(){
        Debug.Log(message);
    }
}
