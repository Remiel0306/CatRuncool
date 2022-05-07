using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCtrl2D : MonoBehaviour
{
    protected Character2D character;    
    // Start is called before the first frame update
    void Awake() {
        character = GetComponent<Character2D>();        
    }

    // Update is called once per frame
    void Update() {
        character.Move(Input.GetAxis("Horizontal"), Input.GetButtonDown("Jump"));
    }
}
