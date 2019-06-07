using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class musicSwitch : MonoBehaviour
{

    public AudioSource audioSource;
    //Play the music
    bool m_Play;
    public Text musicVolume;
    public Slider slider;

    void Start()
    {
        m_Play = true;
    }

    // Update is called once per frame
    void Update()
    {
      
    }


    public void click()
    {
        if (m_Play)
        {
            m_Play = false;
            audioSource.Stop();
        }
        else
        {
            m_Play = true;
            audioSource.Play();
        }
    }
}
