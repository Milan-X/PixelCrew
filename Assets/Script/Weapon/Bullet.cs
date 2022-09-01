using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float lifetime; // 经过lifetime后摧毁子弹本身


    private float[] attackDetails = new float[2]; // 2维数组，attackDetails[0]是伤害，attackDetails[1]是方向
    public float attackRadius;
    public bool canDestroy;
    private float attackDamage = 20f;//普通子弹伤害
    private float chargedattackDamage = 50f;
    public LayerMask whatIsEnemy;
    //public GameObject destroyEffect;

    public GameObject Bullet1;
    public GameObject ChargedBullet;
  
    // Start is called before the first frame update
    void Start()
    {
        
        rb.velocity = transform.right * speed;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Bullet1)
            attackDetails[0] = attackDamage;
        if (ChargedBullet)
            attackDetails[0] = chargedattackDamage;

        attackDetails[1] = transform.position.x;

        Collider2D damageHit = Physics2D.OverlapCircle(rb.position, attackRadius, whatIsEnemy);

     
        //if (damageHit)
        //{
            //GameObject.Find("Enemy").SendMessage("Damage", attackDetails);
            //DestroyBulletTiles();
        //}
    }
    
}
