using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f); //Movement vector. Only the X axis value is changed.
        transform.position = transform.position + horizontal * Time.deltaTime;    //"Time.deltaTime" makes movement "smoother",
                                                                                  //since the script is run at every frame update.

    }
}
