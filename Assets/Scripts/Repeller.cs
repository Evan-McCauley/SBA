using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeller : MonoBehaviour
{
    public Rigidbody rigid;

    private float maxRepelDistance = 30;

    private Vector3 buoyantForce(Repeller other)
    {
        Rigidbody repellerRigid = other.rigid;
        Vector3 pullVector = rigid.position - repellerRigid.position;
        float distance = pullVector.magnitude;
        if (distance > maxRepelDistance)
        {
            return pullVector * 0;
        }
        pullVector = pullVector.normalized;
        return pullVector * (1 - (distance / maxRepelDistance)) * (rigid.mass * repellerRigid.mass) / 100000;
    }

    void FixedUpdate()
    {
        Repeller[] repellers = FindObjectsOfType<Repeller>();
        Vector3 totalForce = new Vector3(0, 0, 0);
        foreach (Repeller repeller in repellers)
        {
            if (this != repeller)
            {
                totalForce = totalForce + buoyantForce(repeller);
            }
        }
        rigid.AddForce(totalForce);
    }
}
