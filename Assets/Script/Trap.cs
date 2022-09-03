using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Trap : MonoBehaviour
{
    [SerializeField] private float damage = 20f;
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponentInChildren<HealthBar>().hp -= damage;
            collision.GetComponentInChildren<HealthBar>().UpdateHp();
        }
    }
}
