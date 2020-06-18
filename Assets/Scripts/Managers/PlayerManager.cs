using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int maxHealth = 40;
    public int baseAttack = 3;


    public int health;
    public int attack;
    public float defense;


    public static PlayerManager Instance { get; private set; }


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        attack = baseAttack;


        if (Instance != null)
            return;

        Instance = this;
    }

    public void TakeDamage(int damage)
    {
        float postDefense = (float)damage * (1 - defense);

        if (postDefense < 0)
            postDefense = 0;

        int dmgTaken = Mathf.RoundToInt(postDefense);

        //Play dmg animation


        health -= dmgTaken;
        HealthDisplay.Instance.UpdateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
