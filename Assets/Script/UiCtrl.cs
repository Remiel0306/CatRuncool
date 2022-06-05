using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace remiel
{
    public class UiCtrl : MonoBehaviour
    {
        [SerializeField] Button btnPlay;
        [SerializeField] Button btnReplay;

        private void Start()
        {

        }
        private void Update()
        {
            
        }
           
        public void ButtonClick()
        {
            SceneManager.LoadScene("Game");
        }
    }
}
