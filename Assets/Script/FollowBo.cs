using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBo : MonoBehaviour
{
    [SerializeField, Header("ªiªº¦ì¸m")] Transform traBo;
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
}
