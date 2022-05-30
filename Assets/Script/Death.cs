using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Death : MonoBehaviour
{
    [SerializeField] Canvas finishPanel, deadPanel;

    public bool showDeadPanel = false;
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
        if(other.name == ("BO"))
        {
            Time.timeScale = 0;
        }

        if (other.name == ("Down"))
        {
            print(other.name.ToString());
            showDeadPanel = true;
            
        }
    }
}
