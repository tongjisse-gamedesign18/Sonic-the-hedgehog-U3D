using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingButton : MonoBehaviour
{
    public GameObject stageui;
    public GameObject settingui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void click()
    {
        stageui.SetActive(false);
        settingui.SetActive(true);
    }
}
