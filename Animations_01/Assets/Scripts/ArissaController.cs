using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArissaController : MonoBehaviour
{
    private Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();


    }

    void Update()
    {
     
        if (Input.GetKeyDown(KeyCode.X))
        {
            anim.SetTrigger("TauntTrigger");
        }
         if (Input.GetKeyDown(KeyCode.Z))
        {
            anim.SetTrigger("CatWalkTrigger");
        }
         if (Input.GetKeyDown(KeyCode.Y))
        {
            anim.SetBool("Caprio", true);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("Caprio", false);
        }
    }

}
