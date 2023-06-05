using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialogue : MonoBehaviour
{

    public GameObject startDialogue;

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

        DialogueTrigger dt = new DialogueTrigger();
        Debug.Log("Entered");

        if (other.tag == "Player")
        {
            startDialogue.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
