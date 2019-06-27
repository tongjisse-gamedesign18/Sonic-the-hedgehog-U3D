using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gensuiTrigger : MonoBehaviour
{
    public GameObject gensuizhe;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        gensuizhe.AddComponent< TailsController>();
        Debug.Log(" ia m here");
    }
}
