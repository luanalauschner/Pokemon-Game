using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandPanel : MonoBehaviour
{
    [SerializeField] public CommandManager commandManager;
    public void Attack(){
        commandManager.Attack();
    }
    public void Bag(){
        Debug.Log("Bag");
    }
    public void Pokemon(){
        Debug.Log("Pokemon");
    }
    public void Run(){
        Debug.Log("Run");
    }
}
