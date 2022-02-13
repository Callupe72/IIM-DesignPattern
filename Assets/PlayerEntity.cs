using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : MonoBehaviour
{
    [SerializeField] int MaxHealth;

    public int CurrentHealth { get; private set; }

    private void Awake()
    {
        CurrentHealth = MaxHealth;
    }

    public void Damage(int amount)	// M�thode appell� par l�ennemi s�il touche le joueur
    {
        CurrentHealth -= amount;
        Debug.Log($"Damage. Current Health : {CurrentHealth}");
    }



}
