using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TurnManager : MonoBehaviour
{
    public int number;

    public GameObject AttackOne;
    public GameObject AttackTwo;
    public GameObject AttackThree;
    public GameObject AttackFour;

    public int AttackOneCounter;
    public int AttackTwoCounter;
    public int AttackThreeCounter;
    public int AttackFourCounter;
    public Button AttackOneButton;
    public Button AttackTwoButton;
    public Button AttackThreeButton;
    public Button AttackFourButton;
    public TMPro.TMP_Text AttackOneText;
    public TMPro.TMP_Text AttackTwoText;
    public TMPro.TMP_Text AttackThreeText;
    public TMPro.TMP_Text AttackFourText;

    public int AttackOneCounter_Enemy;
    public int AttackTwoCounter_Enemy;
    public int AttackThreeCounter_Enemy;
    public int AttackFourCounter_Enemy;
    public bool canUseAttackOne;
    public bool canUseAttackTwo;
    public bool canUseAttackThree;
    public bool canUseAttackFour;

    public Dragon_Manager Dragon_Manager;
    public Enemy_Dragon_Manager Enemy_Dragon_Manager;

    public void random()
    {
        number = Random.Range(1, 5);
    }

    public void Wait()
    {
        AttackOne.SetActive(false);
        AttackTwo.SetActive(false);
        AttackThree.SetActive(false);
        AttackFour.SetActive(false);
        StartCoroutine(Okay());
    }

    IEnumerator Okay()
    {
        yield return new WaitForSeconds(1);
        AttackOne.SetActive (true);
        AttackTwo.SetActive (true);
        AttackThree.SetActive (true);
        AttackFour.SetActive (true);
    }

    public void CounterDown()
    {
        AttackOneCounter = AttackOneCounter - 1;
        AttackTwoCounter = AttackTwoCounter - 1;
        AttackThreeCounter = AttackThreeCounter - 1;
        AttackFourCounter = AttackFourCounter - 1;

        AttackOneCounter_Enemy = AttackOneCounter_Enemy - 1;
        AttackTwoCounter_Enemy = AttackTwoCounter_Enemy - 1;
        AttackThreeCounter_Enemy = AttackThreeCounter_Enemy - 1;
        AttackFourCounter_Enemy = AttackFourCounter_Enemy - 1;
    }

    private void Update()
    {
        if(AttackOneCounter > 0)
        {
            AttackOneButton.interactable = false;
            AttackOneText.text = AttackOneCounter.ToString();
        }
        if(AttackOneCounter <= 0)
        {
            AttackOneButton.interactable = true;
            AttackOneText.text = "AttackOne".ToString();
        }
        if (AttackTwoCounter > 0)
        {
            AttackTwoButton.interactable = false;
            AttackTwoText.text = AttackTwoCounter.ToString();
        }
        if(AttackTwoCounter <= 0)
        {
            AttackTwoButton.interactable = true;
            AttackTwoText.text = "AttackTwo".ToString();
        }
        if (AttackThreeCounter > 0)
        {
            AttackThreeButton.interactable = false;
            AttackThreeText.text = AttackThreeCounter.ToString();
        }
        if(AttackThreeCounter <= 0)
        {
            AttackThreeButton.interactable = true;
            AttackThreeText.text = "AttackThree".ToString();
        }
        if (AttackFourCounter > 0)
        {
            AttackFourButton.interactable = false;
            AttackFourText.text = AttackFourCounter.ToString();
        }
        if(AttackFourCounter <= 0)
        {
            AttackFourButton.interactable = true;
            AttackFourText.text = "Attack Four".ToString();
        }

        if (AttackOneCounter_Enemy > 0)
        {
            canUseAttackOne = false;
        }
        if (AttackOneCounter_Enemy <= 0)
        {
            canUseAttackOne = true;
        }
        if (AttackTwoCounter_Enemy > 0)
        {
            canUseAttackTwo = false;
        }
        if (AttackTwoCounter_Enemy <= 0)
        {
            canUseAttackTwo = true;
        }
        if (AttackThreeCounter_Enemy > 0)
        {
            canUseAttackThree = false;
        }
        if (AttackThreeCounter_Enemy <= 0)
        {
            canUseAttackThree = true;
        }
        if (AttackFourCounter_Enemy > 0)
        {
            canUseAttackFour = false;
        }
        if (AttackFourCounter_Enemy <= 0)
        {
            canUseAttackFour = true;
        }
    }

    public void OnePressed()
    {
        AttackOneCounter = Dragon_Manager.attackOneCounter;
        CheckNumber();
    }
    public void TwoPressed()
    {
        AttackTwoCounter = Dragon_Manager.attackTwoCounter;
        CheckNumber();
    }
    public void ThreePressed()
    {
        AttackThreeCounter = Dragon_Manager.attackThreeCounter;
        CheckNumber();
    }
    public void FourPressed()
    {
        AttackFourCounter = Dragon_Manager.attackFourCounter;
        CheckNumber();
    }

    public void CheckNumber()
    {
        if(number == 1)
        {
            AttackOneCounter_Enemy = Enemy_Dragon_Manager.attackOneCounter_Enemy;
        }
        if (number == 2)
        {
            AttackTwoCounter_Enemy = Enemy_Dragon_Manager.attackTwoCounter_Enemy;
        }
        if (number == 3)
        {
            AttackThreeCounter_Enemy = Enemy_Dragon_Manager.attackThreeCounter_Enemy;
        }
        if (number == 4)
        {
            AttackFourCounter_Enemy = Enemy_Dragon_Manager.attackFourCounter_Enemy;
        }
    }
}
