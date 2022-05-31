using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

namespace remiel
{
    public class UiCtrl : MonoBehaviour
    {
        [SerializeField] Death death;

        CanvasGroup canvas;

        private void Start()
        {
            canvas = GetComponent<CanvasGroup>();
        }
        private void Update()
        {
            
        }
           
        public void ShowPanel()
        {
            if (death.showDeadPanel)
            {
                gameObject.SetActive(true);
            }
            else
            {
                gameObject.SetActive(false);
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (death.showDeadPanel)
            {
                GetComponent<CanvasGroup>().interactable = false;
            }
        }
    }
}
