using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class dropDown : MonoBehaviour,ISelectHandler
{
    public Dropdown drop;
    public  Button start;
    public UIBehaviour a;

    public void OnSelect(BaseEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        drop = this.GetComponent<Dropdown>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
