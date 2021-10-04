using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [Header("���ʳt��"),Range(0, 100)] 
    public float speed;

    [Header("���� Rigidbody2D")]
    public Rigidbody2D rig;

    [Header("�Ϥ���V�� SpriteRenderer")]
    public SpriteRenderer spr;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        Movement();
    }
    //��k-����
    void Movement()
    {
        float horizontalmove = Input.GetAxisRaw("Horizontal");
        rig.AddForce(new Vector2(horizontalmove * speed, rig.velocity.y));

        float facedircetion = Input.GetAxisRaw("Horizontal");
        if (facedircetion < 0)
        {
            spr.flipX = true;
        } else if(facedircetion > 0)
        {
            spr.flipX = false;
        }
    }   
}
