using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class musicVolume : MonoBehaviour
{
    public AudioSource audioSource;
    public Text volumeText;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeVolume()
    {
        float sliderValue = slider.value;
        int i = (int)(sliderValue * 100);
        sliderValue = (float)(i * 1.0) / 100;
        audioSource.volume = sliderValue;
        string text = (sliderValue * 100).ToString();
        volumeText.text = text;
    }
}
