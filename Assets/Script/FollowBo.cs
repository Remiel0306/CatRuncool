using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 讓攝影機跟隨玩家
/// </summary>
namespace remiel 
{
    public class FollowBo : MonoBehaviour
    {
        [SerializeField, Header("波的位置")] Transform traBo;
        [SerializeField] float speedScale = 1;


        // Start is called before the first frame update
        Vector3 lastPosition;
        void Start()
        {
            lastPosition = traBo.position;        
        }

        // Update is called once per frame
        void Update()
        {      
            Vector3 delta = traBo.position - lastPosition;
            transform.Translate(delta.x * speedScale, 0, 0);
            lastPosition = traBo.position;
            
        }

        //private void OnTriggerEnter2D(Collider2D other)
        //{
        //    if (other.name == ("BO"))
        //    {
        //        bCamMove = true;
        //        print("444");
        //    }
        //}
    }
}
