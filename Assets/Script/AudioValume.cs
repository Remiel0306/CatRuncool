using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace remiel
{
    public class AudioValume : MonoBehaviour
    {
        [SerializeField] AudioMixer audioMixer;
        [SerializeField] Slider musicSlider, effectSlider;

        // Start is called before the first frame update
        void Start()
        {
            if(PlayerPrefs.HasKey("Music Volume"))
            {
                musicSlider.value = PlayerPrefs.GetFloat("Music Volume");
            }

            if(PlayerPrefs.HasKey("Effect Volume"))
            {
                effectSlider.value = PlayerPrefs.GetFloat("Effect Volume");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnMusicVolumeChanged()
        {
            audioMixer.SetFloat("MusicVolume", musicSlider.value);
        }

        public void OnEffectVolumeChanged()
        {
            audioMixer.SetFloat("EffectVolume", effectSlider.value);
        }

        public void SaveVolumeChanged()
        {
            PlayerPrefs.SetFloat("Music Volume", musicSlider.value);
            PlayerPrefs.SetFloat("Effect Volume", effectSlider.value);
        }
    }
}
