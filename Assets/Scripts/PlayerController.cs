using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

/// <summary>
/// プレイヤーの動きを制御するスクリプト
/// </summary>
public class PlayerController : MonoBehaviour
{
    [SerializeField] float Gender; //boyとgirlを判別する変数　0:boy　1:girl
    [SerializeField] float JumpPower; //ジャンプ力

    Rigidbody rb;

    private bool isJumping; //ジャンプ中を判定する
    // Start is called before the first frame update
    void Start()
    {
        if (Gender >= 3) return;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Gender >= 3) return;
        if (isJumping) return;
        if (Gender == 0)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                BoyJump();
                isJumping = true;
            }
        }
        if (Gender == 1)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                GirlJump();
                isJumping = true;
            }
        }
    }
    public void BoyJump()
    {      
        if (isJumping) return;
        rb.AddForce(Vector3.up * JumpPower, ForceMode.VelocityChange);
        isJumping = true;
    }
   public void GirlJump() 
    {
        if (isJumping) return;
        rb.AddForce(Vector3.up * JumpPower,ForceMode.VelocityChange);
        isJumping = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false;
        }
    }
}
