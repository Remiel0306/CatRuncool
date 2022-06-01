using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Death : MonoBehaviour
{
    [SerializeField] GameObject deadPanel;
    [SerializeField] UnityEngine.UI.Button btnDeadReplay;

    public bool showDeadPanel = false;
    Collider2D collider2D;

    // Start is called before the first frame update
    void Start()
    {
        collider2D = GetComponent<Collider2D>();
        Replay();
    }

    // Update is called once per frame
    void Update()
    {
        OnTriggerEnter2D(collider2D);
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
