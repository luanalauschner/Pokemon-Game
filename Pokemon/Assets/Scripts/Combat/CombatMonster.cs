using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatMonster : MonoBehaviour
{
    public void Init(PokemonData monsterData){
        GameObject monModel = Instantiate(monsterData.modelPrefab, transform);
        monModel.transform.localPosition = Vector3.zero;
        monModel.transform.localRotation = Quaternion.identity;
    }
}
