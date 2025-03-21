using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandManager : MonoBehaviour
{
    [SerializeField] TurnRoundManager turnRoundManager;
    [SerializeField] CombatMonster opponent;

    public void Attack()
    {
        turnRoundManager.current.Attack(opponent);
    }
}
