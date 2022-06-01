using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    [SerializeField] GameObject finishPanel;

    Collider2D collider2D;

    // Start is called before the first frame update
    void Start()
    {
        collider2D = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.name == "BO")
        {
            finishPanel.SetActive(true);
        }
    }

    public void Replay()
    {
        SceneManager.LoadScene("Game");
    }
}
