using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    [SerializeField] CombatMonster playerCombatMonster;
    [SerializeField] CombatMonster enemyCombatMonster;
    public void StartBattle(PokemonData playerMon, PokemonData enemyMon){
        playerCombatMonster.Init(playerMon);
        enemyCombatMonster.Init(enemyMon);
    }
}
