using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon_Manager : MonoBehaviour
{
    public Health monster;
    public Health enemy;

    private int level;
    private int enemyHealth;

    public float attackOneBaseDamage;
    public float attackTwoBaseDamage;
    public float attackThreeBaseDamage;
    public float attackFourBaseDamage;
    private int attackOneDamage;
    private int attackTwoDamage;
    private int attackThreeDamage;
    private int attackFourDamage;

    public int attackOneCounter;
    public int attackTwoCounter;
    public int attackThreeCounter;
    public int attackFourCounter;

    void Update()
    {
        level = monster.level;
        enemyHealth = enemy.health;

        attackOneDamage = level * (int)attackOneBaseDamage / 10;
        attackTwoDamage = level * (int)attackTwoBaseDamage / 10;
        attackThreeDamage = level * (int)attackThreeBaseDamage / 10;
        attackFourDamage = level * (int)attackFourBaseDamage / 10;
    }

    public void Attack_One()
    {
        StartCoroutine(One());
        attackOneCounter = 1;
    }
    public void Attack_Two()
    {
        StartCoroutine(Two());
        attackTwoCounter = 2;
    }
    public void Attack_Three()
    {
        StartCoroutine(Three());
        attackThreeCounter = 3;
    }
    public void Attack_Four()
    {
        StartCoroutine(Four());
        attackFourCounter = 4;
    }

    IEnumerator One()
    {
        yield return new WaitForSeconds(2);
        enemy.health = enemyHealth - attackOneDamage;
    }
    IEnumerator Two()
    {
        yield return new WaitForSeconds(2);
        enemy.health = enemyHealth - attackTwoDamage;
    }
    IEnumerator Three()
    {
        yield return new WaitForSeconds(2);
        enemy.health = enemyHealth - attackThreeDamage;
    }
    IEnumerator Four()
    {
        yield return new WaitForSeconds(2);
        enemy.health = enemyHealth - attackFourDamage;
    }
}
