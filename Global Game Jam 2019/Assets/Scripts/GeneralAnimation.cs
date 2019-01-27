using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralAnimation : MonoBehaviour
{


    Animator localAnimator;
    Rigidbody2D localRigid2D;


    void Start()
    {
        localAnimator = GetComponentInChildren<Animator>();
        localRigid2D = this.gameObject.GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        

    }
}
