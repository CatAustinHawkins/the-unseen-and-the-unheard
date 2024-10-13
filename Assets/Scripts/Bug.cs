using UnityEngine;

public class Bug : MonoBehaviour
{
    public GameObject dialogue;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        dialogue.GetComponent<DialogueManager>().BugTalk();
    }
}
