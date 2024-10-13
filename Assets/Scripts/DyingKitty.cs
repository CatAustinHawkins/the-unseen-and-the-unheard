using UnityEngine;

public class DyingKitty : MonoBehaviour
{
    public GameObject dialogue;
    public GameObject HealthManager;
    public bool interacted;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(interacted == false)
        {
            dialogue.GetComponent<DialogueManager>().DyingKittyTalk();
            HealthManager.GetComponent<HealthManager>().dyingkitty();
        }
    }
}
