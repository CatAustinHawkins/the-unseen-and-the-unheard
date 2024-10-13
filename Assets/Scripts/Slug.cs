using UnityEngine;

public class Slug : MonoBehaviour
{
    public bool questcomplete;

    public GameObject questmanager;

    public GameObject dialoguemanager;
    public GameObject angelcarrot1;
    public GameObject angelcarrot2;
    public GameObject angelcarrot3;
    public GameObject angelcarrot4;
    public GameObject angelcarrot5;
    public GameObject angelcarrot6;
    public GameObject angelcarrot7;
    public GameObject angelcarrot8;
    public GameObject angelcarrot9;
    public GameObject angelcarrot10;
    public GameObject angelcarrot11;
    public GameObject angelcarrot12;

    public void questcompleted()
    {
        questcomplete = true;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(questcomplete == true)
        {
            questmanager.GetComponent<QuestandItemsManager>().slugrequest();
            dialoguemanager.GetComponent<DialogueManager>().SlugRequestComplete();
        }
        else
        {
            dialoguemanager.GetComponent<DialogueManager>().SlugRequest();
            angelcarrot1.GetComponent<angelcarrots>().questbegin();
            angelcarrot2.GetComponent<angelcarrots>().questbegin();
            angelcarrot3.GetComponent<angelcarrots>().questbegin();
            angelcarrot4.GetComponent<angelcarrots>().questbegin();
            angelcarrot5.GetComponent<angelcarrots>().questbegin();
            angelcarrot6.GetComponent<angelcarrots>().questbegin();
            angelcarrot7.GetComponent<angelcarrots>().questbegin();
            angelcarrot8.GetComponent<angelcarrots>().questbegin();
            angelcarrot9.GetComponent<angelcarrots>().questbegin();
            angelcarrot10.GetComponent<angelcarrots>().questbegin();
            angelcarrot11.GetComponent<angelcarrots>().questbegin();
            angelcarrot12.GetComponent<angelcarrots>().questbegin();
        }
    }
}
