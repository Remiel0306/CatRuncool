using System.Collections;
using System.Collections.Generic;
using remiel;
using UnityEngine;


namespace rmeiel
{
    /// <summary>
    /// ���a�q��
    /// </summary>
    public class Mid : MonoBehaviour
    {
        
        public bool stop = false;

        Collider2D collider2D;
        // Start is called before the first frame update
        void Start()
        {
            collider2D = GetComponent<Collider2D>();
        }

        // Update is called once per frame
        void Update()
        {
            OnTriggerEnter2D(collider2D);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            print(other.name.ToString());
            if(other.name == "Finish")
            {
                stop = true;
            }
        }
    }
}
