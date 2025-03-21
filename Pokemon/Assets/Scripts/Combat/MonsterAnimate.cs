using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAnimate : MonoBehaviour
{
    Animator animator;
    public void Init(GameObject monsterObject)
    {
        animator = monsterObject.GetComponent<Animator>();
    }

    public void Attack()
    {
        animator.SetTrigger("Attack");
    }
}
