using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Dragon_Manager : MonoBehaviour
{
    public Health selfLevel;
    public Health enemy;

    private int level;
    private int allyHealth;

    public float attackOneBaseDamage;
    public float attackTwoBaseDamage;
    public float attackThreeBaseDamage;
    public float attackFourBaseDamage;
    private int attackOneDamage;
    private int attackTwoDamage;
    private int attackThreeDamage;
    private int attackFourDamage;

    private bool canUseOne;
    private bool canUseTwo;
    private bool canUseThree;
    private bool canUseFour;
    public int attackOneCounter_Enemy;
    public int attackTwoCounter_Enemy;
    public int attackThreeCounter_Enemy;
    public int attackFourCounter_Enemy;

    private int chosen;
    public TurnManager TurnManager;

    void Update()
    {
        chosen = TurnManager.number;
        level = selfLevel.level;
        allyHealth = enemy.health;
        attackOneDamage = level * (int)attackOneBaseDamage / 8;
        attackTwoDamage = level * (int)attackTwoBaseDamage / 8;
        attackThreeDamage = level * (int)attackThreeBaseDamage / 8;
        attackFourDamage = level * (int)attackFourBaseDamage / 8;

        canUseOne = TurnManager.canUseAttackOne;
        canUseTwo = TurnManager.canUseAttackTwo;
        canUseThree = TurnManager.canUseAttackThree;
        canUseFour = TurnManager.canUseAttackFour;
    }

    public void Attack_One()
    {
        if (canUseOne == true)
        {
            StartCoroutine(One());
            attackOneCounter_Enemy = 1;
        }
        if (canUseOne == false)
        {
            TurnManager.random();
        }
    }
    public void Attack_Two()
    {
        if (canUseTwo == true)
        {
            StartCoroutine(Two());
            attackTwoCounter_Enemy = 2;
        }
        if (canUseTwo == false)
        {
            TurnManager.random();
        }
    }
    public void Attack_Three()
    {
        if (canUseThree == true)
        {
            StartCoroutine(Three());
            attackThreeCounter_Enemy = 3;
        }
        if (canUseThree == false)
        {
            TurnManager.random();
        }
    }
    public void Attack_Four()
    {
        if (canUseFour == true)
        {
            StartCoroutine(Four());
            attackFourCounter_Enemy = 4;
        }
        if (canUseFour == false)
        {
            TurnManager.random();
        }
    }
    IEnumerator One()
    {
        yield return new WaitForSeconds(1);
        if (chosen == 1)
        {
            enemy.health = allyHealth - attackOneDamage;
        }
    }
    IEnumerator Two()
    {
        yield return new WaitForSeconds(1);
        if (chosen == 2)
        {
            enemy.health = allyHealth - attackTwoDamage;
        }
    }
    IEnumerator Three()
    {
        yield return new WaitForSeconds(1);
        if (chosen == 3)
        {
        enemy.health = allyHealth - attackThreeDamage;
        }
    }
    IEnumerator Four()
    {
        yield return new WaitForSeconds(1);
        if (chosen == 4)
        { 
        enemy.health = allyHealth - attackFourDamage;
        }
    }
}
