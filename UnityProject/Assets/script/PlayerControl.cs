using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [Header("移動速度"),Range(0, 100)] 
    public float speed;

    [Header("剛體 Rigidbody2D")]
    public Rigidbody2D rig;

    [Header("圖片渲染器 SpriteRenderer")]
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
    //方法-移動
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
