using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{

    Animator anim;
    int isDeadHash;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        isDeadHash = Animator.StringToHash("isDead");
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void Die()
    {
        anim.SetBool(isDeadHash, true);
    }
}
