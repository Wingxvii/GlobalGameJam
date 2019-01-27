using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralAnimation : MonoBehaviour
{

    public bool isWalking;
    Animator localAnimator;
    Rigidbody2D localRigid2D;
    public GameObject objectToFlip;

    public float velY;
    public float velX;


    void Start()
    {
        localAnimator = GetComponentInChildren<Animator>();
        localRigid2D = this.gameObject.GetComponentInParent<Rigidbody2D>();
        objectToFlip = localAnimator.gameObject;
    }

    void Update()
    {
        velY = localRigid2D.velocity.normalized.y;
        velX = localRigid2D.velocity.normalized.x;
        if (localRigid2D.velocity.normalized.y != 0 || localRigid2D.velocity.normalized.x != 0)
        {
            isWalking = true;
            localAnimator.SetBool("isWalking", isWalking);

            if(localRigid2D.velocity.normalized.x > 0)
            {
                localAnimator.gameObject.transform.localScale =  new Vector3(1, localAnimator.gameObject.transform.localScale.y, localAnimator.gameObject.transform.localScale.z);
             //   Debug.Log(gameObject.name + " Fliped");
            } else if (localRigid2D.velocity.normalized.x < 0)
            {
                localAnimator.gameObject.transform.localScale = new Vector3(-1, localAnimator.gameObject.transform.localScale.y, localAnimator.gameObject.transform.localScale.z);
               // Debug.Log(gameObject.name +" Fliped -1");

            }

        }
        else
        {
            isWalking = false;
            localAnimator.SetBool("isWalking", isWalking);


        }

        

    }
}
