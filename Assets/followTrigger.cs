using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followTrigger : MonoBehaviour
{
    public GameObject follower;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        if (!follower.GetComponent("TailsController"))
        {
            Debug.Log("Fuck!");
            Destroy(follower.GetComponent("TailsController"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        follower.AddComponent<TailsController>();
       
    }

}