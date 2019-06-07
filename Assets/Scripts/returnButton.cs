using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnButton : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            click();
        }
    }

    public void click()
    {
        stageui.SetActive(true);
        settingui.SetActive(false);
        
    }
}
