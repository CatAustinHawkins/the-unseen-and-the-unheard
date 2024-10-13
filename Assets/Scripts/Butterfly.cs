using UnityEngine;

public class Butterfly : MonoBehaviour
{
    public GameObject dialogue;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        dialogue.GetComponent<DialogueManager>().ButterflyTalk();
    }
}
