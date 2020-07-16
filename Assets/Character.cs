using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isRunning", true);
            transform.Translate(0, 0, 100f * Time.deltaTime);
        }
        else anim.SetBool("isRunning", false);
        transform.Rotate(0, 20f * Time.deltaTime * Input.GetAxis("Horizontal"), 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("isJumping");
        }
    }
}
