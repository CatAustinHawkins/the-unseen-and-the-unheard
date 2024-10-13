using UnityEngine;

public class Spider : MonoBehaviour
{
    public GameObject dialogue;
    public GameObject HealthManager;
    public bool interacted;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(interacted == false)
        {
            dialogue.GetComponent<DialogueManager>().SpiderTalk();
            HealthManager.GetComponent<HealthManager>().Spiderspokento();
            interacted = true;
        }
    }
}
