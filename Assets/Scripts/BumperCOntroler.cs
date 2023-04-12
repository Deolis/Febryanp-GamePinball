using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BumperCOntroler : MonoBehaviour
{
    [SerializeField]
    private Collider bola;
    [SerializeField]
    private float multiplayer;
    [SerializeField]
    private Color color;
    private Renderer render;
    private Animator animator;

    private void Start()
    {
        render = GetComponent<Renderer>();
        render.material.color = color;
        animator = GetComponent<Animator>();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplayer;
            animator.SetTrigger("Hits");
        }

    }

}
