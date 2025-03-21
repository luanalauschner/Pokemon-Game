using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CombatMonster : MonoBehaviour
{
    PokemonData pokemon;
    [SerializeField] MonsterAnimate monsterAnimate;

    [SerializeField] public GameObject textoGanhou;
    [SerializeField] public GameObject textoPerdeu;
    [SerializeField] public TextMeshProUGUI timerText;

    public Int2Val HP;
    public int damage = 10;

    private float timer = 30f; 
    private bool combatEnded = false;
    


    private void Start()
    {
        // Desativa os textos no início (caso já não estejam desativados)
        if (textoGanhou != null)
        {
            textoGanhou.SetActive(false);
        }
        if (textoPerdeu != null)
        {
            textoPerdeu.SetActive(false);
        }

        // Inicializa o texto do timer
        UpdateTimerText();
    }
    private void Update()
    {
        if (!combatEnded)
        {
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                timer = 0f;
                EndCombat(false); 
            }
        }
        UpdateTimerText();
    }

    public void Init(PokemonData monsterData)
    {
        pokemon = monsterData;
        GameObject monModel = Instantiate(monsterData.modelPrefab, transform);
        monModel.transform.localPosition = Vector3.zero;
        monModel.transform.localRotation = Quaternion.identity;
        monsterAnimate.Init(monModel);
        int hp = monsterData.stats.Get(PokemonStats.HP);
        HP = new Int2Val(hp, hp);
    }

    public void Attack(CombatMonster target)
    {
        monsterAnimate.Attack();
        target.TakeDamage(damage);
    }

    public void TakeDamage(int damage)
    {
        HP.current -= damage;
        Debug.Log("Pokemon: " + pokemon.pokemonName + " HP: " + HP.current.ToString());
        if (HP.current <= 0)
        {
            HP.current = 0;
            Debug.Log("Ganhou!");

            if (textoGanhou != null)
            {
                textoGanhou.SetActive(true);
            }

            EndCombat(true);
        }
    }

    private void EndCombat(bool playerWon)
    {
        combatEnded = true; 

        if (playerWon)
        {
            if (textoGanhou != null)
            {
                textoGanhou.SetActive(true);
            }
        }
        else
        {
            if (textoPerdeu != null)
            {
                textoPerdeu.SetActive(true);
            }
        }

        StartCoroutine(LoadSceneAfterDelay(2f));
    }

    //public void ChangeScene()
    //{
    //    FindObjectOfType<GameSceneManager>().SwitchEnviromentScene("Town");
    //}

    private IEnumerator LoadSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        SceneManager.LoadScene("Town");
    }

    private void UpdateTimerText()
    {
        // Atualiza o texto do timer
        if (timerText != null)
        {
            timerText.text = "Tempo: " + Mathf.Ceil(timer).ToString(); // Exibe o tempo arredondado para cima
        }
    }

}
