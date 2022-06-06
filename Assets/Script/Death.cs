using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Death : MonoBehaviour
{
    [SerializeField] GameObject deadPanel;

    public bool showDeadPanel = false;
    Collider2D collider2D;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        collider2D = GetComponent<Collider2D>();
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

            deadPanel.SetActive(true);
        }
    }

    public void Replay()
    {
        SceneManager.LoadScene("Game");
    }
}
