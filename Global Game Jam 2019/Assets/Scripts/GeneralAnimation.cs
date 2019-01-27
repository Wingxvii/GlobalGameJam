using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralAnimation : MonoBehaviour
{

    public bool isWalking;
    Animator localAnimator;
    Rigidbody2D localRigid2D;

    public float velY;
    public float velX;


    void Start()
    {
        localAnimator = GetComponentInChildren<Animator>();
        localRigid2D = this.gameObject.GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        velY = localRigid2D.velocity.normalized.y;
        velX = localRigid2D.velocity.normalized.x;
        if (localRigid2D.velocity.normalized.y != 0 || localRigid2D.velocity.normalized.x != 0)
        {
            isWalking = true;
            localAnimator.SetBool("isWalking", isWalking);

        }
        else
        {
            isWalking = false;
            localAnimator.SetBool("isWalking", isWalking);


        }

        

    }
}
