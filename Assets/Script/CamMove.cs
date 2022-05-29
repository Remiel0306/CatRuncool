using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace remiel
{
    public class CamMove : MonoBehaviour
    {
        public bool moveCam { get; set; }

        Collider2D collider2D;

        private void Start()
        {
            collider2D = GetComponent<Collider2D>();
        }

        private void Update()
        {
            OnTriggerEnter2D(collider2D);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if(other.name == "BO")
            {
                moveCam = true;
            }
        }
        //Collider2D collider2D;
        //// Start is called before the first frame update
        //void Start()
        //{
        //    collider2D = GetComponent<Collider2D>();
        //}

        //// Update is called once per frame
        //void Update()
        //{
        //    OnTriggerEnter2D(collider2D);
        //}

        //private void OnTriggerEnter2D(Collider2D other)
        //{
        //    if(other.name == "BO")
        //    {
        //        moveCam = true;
        //    }
        //}
    }
}
