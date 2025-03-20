using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatDebug : MonoBehaviour
{
    [SerializeField] PokemonData playerMonData;
    [SerializeField] PokemonData enemyMonData;

    CombatManager manager;
    private void Awake()
    {
        manager = GetComponent<CombatManager>();
    }   
    private void Start()
    {
        manager.StartBattle(playerMonData, enemyMonData);
    }
}
