using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class startButton : MonoBehaviour
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
    public void Onclick()
    {
        StageManager.Instance.current_level = dropdown.value + 1;
        SceneManager.LoadScene(StageManager.Instance.current_level);
    }
}
