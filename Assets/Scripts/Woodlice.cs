using UnityEngine;

public class Woodlice : MonoBehaviour
{
    public GameObject dialogue;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        dialogue.GetComponent<DialogueManager>().WoodliceTalk();
    }
}
