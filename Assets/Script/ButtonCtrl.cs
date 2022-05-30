using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

namespace remiel
{
    public class ButtonCtrl : MonoBehaviour
    {
        [SerializeField] Death death;

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
    }
}
