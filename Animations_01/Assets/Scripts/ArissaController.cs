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
    }

}
