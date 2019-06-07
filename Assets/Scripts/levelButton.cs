using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class levelButton : MonoBehaviour
{
    public Dropdown dropdown;
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
        if (dropdown.gameObject.activeInHierarchy)
        {
            dropdown.gameObject.SetActive(false);
        }
        else
        {
            dropdown.gameObject.SetActive(true);
        }
            

        
    }
}
