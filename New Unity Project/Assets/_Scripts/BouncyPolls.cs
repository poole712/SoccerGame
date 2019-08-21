using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyPolls : MonoBehaviour
{
    private Animation anim;

    private void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }
    public void OnTriggerEnter(Collider other)
    {
        anim.Play("BouncyPolls");
    }
}
