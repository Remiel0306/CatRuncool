using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 讓軌道偵測後克隆
/// </summary>
namespace remiel
{
    public class Right : MonoBehaviour
    {
        //[SerializeField] GameObject[] styles;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.name == "End")
            {
                Instantiate(other.transform.root.gameObject, other.transform.position, Quaternion.identity);

                //    if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
                //    {
                //        GameObject clone = Instantiate(styles[Random.Range(0, styles.Length)], other.transform.position, Quaternion.identity);
                //        //Score[] scores = clone.GetComponentsInChildren<Score>();
                //        List<int> indexArray = new List<int>();
                //        //while (true)
                //        //{

                //        //}
                //    }
                //}
                //else
            }
        }
    }
}
