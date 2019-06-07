using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helpButton : MonoBehaviour
{
    public GameObject stageUi;
    public GameObject helpUi;
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
        stageUi.SetActive(false);
        helpUi.SetActive(true);
    }
}
