using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

/// <summary>
/// �v���C���[�̓����𐧌䂷��X�N���v�g
/// </summary>
public class PlayerController : MonoBehaviour
{
    [SerializeField] float Gender; //boy��girl�𔻕ʂ���ϐ��@0:boy�@1:girl
    [SerializeField] float JumpPower; //�W�����v��

    Rigidbody rb;

    private bool isJumping; //�W�����v���𔻒肷��
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
