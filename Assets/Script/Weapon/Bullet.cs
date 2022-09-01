using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float lifetime; // ����lifetime��ݻ��ӵ�����


    private float[] attackDetails = new float[2]; // 2ά���飬attackDetails[0]���˺���attackDetails[1]�Ƿ���
    public float attackRadius;
    public bool canDestroy;
    private float attackDamage = 20f;//��ͨ�ӵ��˺�
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
