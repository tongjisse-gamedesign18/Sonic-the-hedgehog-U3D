using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helpReturnButton : MonoBehaviour
{
    public GameObject stageui;
    public GameObject helpui;
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
        helpui.SetActive(false);
    }
}
