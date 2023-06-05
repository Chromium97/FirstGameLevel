using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonlithDialogue : MonoBehaviour
{
    public GameObject startDialogue;
    public DialogueTrigger trigger;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") 
        {
            startDialogue.SetActive(true);
            trigger.StartDialogue();
        }
        
    }
}
