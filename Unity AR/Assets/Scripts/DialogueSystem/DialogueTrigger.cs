using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public virtual void TriggerDialogue()
    {
        DialogueManager.instance.StartDialogue(dialogue,this);
    }

    public virtual void OnEndConversation()
    {
    }
}
