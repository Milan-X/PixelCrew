using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image hpImage;
    public Image hpEffect;

    [HideInInspector] public float hp;
    [SerializeField] private float maxHp;
    [SerializeField] private float hurtSpeed = 0.005f;
    

    // Start is called before the first frame update
    void Start()
    {
        hp = maxHp;
        
    }

    // Update is called once per frame
    public void UpdateHp()
    {
        StartCoroutine(UpdateHpCo());
        StartCoroutine(Invulnerability());
        GameObject.Find("Player (1)").SendMessage("CurrentHp", hp);
    }

    IEnumerator UpdateHpCo()
    {
        hpImage.fillAmount = hp / maxHp;
        while (hpEffect.fillAmount >= hpImage.fillAmount)
        {
            hpEffect.fillAmount -= hurtSpeed;
            yield return new WaitForSeconds(0.005f);
            //Debug.Log("A");
        }
        if (hpEffect.fillAmount < hpImage.fillAmount)
        {
            hpEffect.fillAmount = hpImage.fillAmount;
        }
        
    }

    IEnumerator Invulnerability()
    {
        Physics2D.IgnoreLayerCollision(10, 11, true);
        yield return new WaitForSeconds(2f);
        Physics2D.IgnoreLayerCollision(10, 11, false);
    }

}
