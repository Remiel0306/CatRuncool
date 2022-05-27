using System.Collections;
using System.Collections.Generic;
using rmeiel;
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
        [SerializeField] Mid mid;
        [SerializeField] CamMove camMove;

        // Start is called before the first frame update
        Vector3 lastPosition;
        public void SetLastPosition(Vector3 s)
        {
            lastPosition = s;
        }
        void Start()
        {
            lastPosition = traBo.position;
            //right = GetComponent<Collider2D>();
        }

        // Update is called once per frame
        void Update()
        {
            if (camMove.moveCam)
            {
                Vector3 delta = traBo.position - lastPosition;
                transform.Translate(delta.x * speedScale, 0, 0);
                lastPosition = traBo.position;
            }
            else
            {
                transform.Translate(0, 0, 0);
            }


            if (mid.stop)
            {
                transform.Translate(0, 0, 0);
            }
            else
            {
                  Vector3 delta = traBo.position - lastPosition;
                  transform.Translate(delta.x * speedScale, 0, 0);
                  lastPosition = traBo.position;
            }                 
        }
    }
}
