using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacingSwitcher : MonoBehaviour
{
    Rigidbody2D localRigid2D;

    public float velY;
    public float velX;


    void Start()
    {
        localRigid2D = this.gameObject.GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        velY = localRigid2D.velocity.normalized.y;
        velX = localRigid2D.velocity.normalized.x;

        if (localRigid2D.velocity.normalized.x > 0)
        {
            gameObject.transform.localScale = new Vector3(-1, gameObject.transform.localScale.y, gameObject.transform.localScale.z);

        }
        else if (localRigid2D.velocity.normalized.x < 0)
        {
            gameObject.transform.localScale = new Vector3(1, gameObject.transform.localScale.y, gameObject.transform.localScale.z);

        }




    }
    
}
