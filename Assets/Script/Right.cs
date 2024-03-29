using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using remiel;

/// <summary>
/// ���y�D������J��
/// </summary>
namespace remiel
{
    public class Right : MonoBehaviour
    {
        [SerializeField] GameObject[] styles;
        [SerializeField] GameObject mainCamera;


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
            if (other.name == "End")
            {
                Instantiate(other.transform.root.gameObject, other.transform.position, Quaternion.identity);
            }
        }
    }
}
