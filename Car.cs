using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FixedUpdate()
    {
        MoveCharacter();
    }

    public void MoveCharacter()
    {
        if (Input.GetKey(KeyCode.D))
            animator.SetBool("right", true);
        else
            animator.SetBool("right", false);

        if (Input.GetKey(KeyCode.A))
            animator.SetBool("left", true);
        else
            animator.SetBool("left", false);
    }
}


