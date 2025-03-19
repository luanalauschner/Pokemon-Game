using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class WorldTriggerArea : MonoBehaviour
{
    public UnityEvent onEnter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerCharacter pc = other.GetComponent<PlayerCharacter>();

        if(pc != null){
            //Debug.Log("other.gameObject.name");
            onEnter?.Invoke();
        }
    }
}
