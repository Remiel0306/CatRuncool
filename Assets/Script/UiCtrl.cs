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
        [SerializeField] Button btnExit;
        [SerializeField] Button btnSetting;
        [SerializeField] GameObject settingPanel;
        [SerializeField] GameObject firstPanel;
        [SerializeField] Button btnSettingPanelBack;
        [SerializeField] Button btnFinBackLobby;
        [SerializeField] Button btnDeadBackLobby;

        private void Start()
        {

        }
        private void Update()
        {
            
        }
           
        public void BtnPlayClick()
        {
            SceneManager.LoadScene("Game");
        }

        public void BtnExitClick()
        {
            Application.Quit();
        }

        public void BtnSettingClick()
        {
            settingPanel.SetActive(true);
            firstPanel.SetActive(false);
        }

        public void BtnSettingPanelBackClick()
        {
            settingPanel.SetActive(false);
            firstPanel.SetActive(true);
        }

        public void BtnBackLobbyClick()
        {
            SceneManager.LoadScene("Lobby");
        }

        public void BtnDeadBackLobbyClick()
        {
            SceneManager.LoadScene("Lobby");
        }
    }
}
