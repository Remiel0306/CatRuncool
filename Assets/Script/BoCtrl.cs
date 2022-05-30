using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.UIElements;

namespace remiel
{
    public class BoCtrl : MonoBehaviour
    {
        Animator animator;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            animator = GetComponent<Animator>();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if(other.collider.tag == "Spike")
            {
                Collider2D[] colliders = GetComponentsInChildren<Collider2D>();
                for (int i = 0; i < colliders.Length; i++)
                {
                    colliders[i].isTrigger = true;
                }
            }
        }
    }
}
