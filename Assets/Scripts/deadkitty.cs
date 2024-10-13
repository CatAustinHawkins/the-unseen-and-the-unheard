using UnityEngine;
public class deadkitty : MonoBehaviour
{
    public GameObject dialoguemanager;
    public GameObject healthmanager;

    public bool interacted;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(interacted == false)
        {
            dialoguemanager.GetComponent<DialogueManager>().DeadKitty1();
            healthmanager.GetComponent<HealthManager>().deadkittyspotted();
            interacted = true;
        }
    }
}
