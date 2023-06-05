using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealRoom : MonoBehaviour
{

    public GameObject doorway;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueManager.isDoorOpen)
        {
            doorway.SetActive(false);
        }
    }
}
