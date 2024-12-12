using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float baseHealth;
    public int level;
    public int health;
    public int maxHealth;
    public float healthPercent;
    public Scrollbar scrollbar;

    // Start is called before the first frame update
    void Start()
    {
        health = (int)(baseHealth * level / 2);
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthPercent = (float)health / (float)maxHealth;
        scrollbar.size = healthPercent;
    }
    
}
