using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogue;
    public GameObject nextdialogue;

    public Text nameui;
    public Text dialogueui;

    public int dialoguecount = 0;

    public bool dialogue1;
    public bool dialogue2;
    public bool dialogue3;

    public bool dialogue4;
    public bool dialogue5;
    public bool dialogue6;

    public bool dialogue7;
    public bool dialogue8;
    public bool dialogue9;
    public bool dialogue10;
    public bool dialogue11;


    public bool deadkitty1;

    public GameObject questmanager;

    public GameObject border;
    public int bordercount;

    void Start()
    {
        dialogue.SetActive(true);
        nextdialogue.SetActive(true);
        nameui.text = "KittyCat";
        dialogueui.text = "Where am I?... I see creatures, maybe I should talk to them?";
        dialogue1 = true;
    }

    void Update()
    {
        if(dialoguecount == 1)
        {
            nameui.text = "Quest Unlocked";
            dialogueui.text = "meet every neighbour";
            dialogue2 = true;
        }

        if(dialoguecount == 2)
        {
            dialogue3 = true;
        }
        
        if(dialogue6)
        {
            dialogueui.text = "Talk to Butterfly about ingreidents.";
            nameui.text = "Slug";
        }

        if(bordercount > 2)
        {
            border.SetActive(false);
            questmanager.GetComponent<QuestandItemsManager>().talkquest();
        }
    }

    public void NextDialogue()
    {
        if (dialogue1)
        {
            dialoguecount++;
            dialogue1 = false;
        }

        if (dialogue2)
        {
            dialogue.SetActive(false);
            nextdialogue.SetActive(false);
            dialoguecount++;
            dialogue2 = false;
        }

        if(deadkitty1)
        {
            dialogue.SetActive(false);
            nextdialogue.SetActive(false);

        }

        if (dialogue4)
        {
            dialogue.SetActive(false);
            nextdialogue.SetActive(false);
            dialogue4 = false;
        }

        if (dialogue5)
        {
            dialogue6 = true;
            dialogue5 = false;
        }

        if(dialogue6)
        {
            questmanager.GetComponent<QuestandItemsManager>().butterflyquest();
            dialogue6 = false;
            dialogue.SetActive(false);
            nextdialogue.SetActive(false);
        }

        if (dialogue7)
        {
            dialogue.SetActive(false);
            nextdialogue.SetActive(false);
            dialogue7 = false;
        }

        if (dialogue8)
        {
            dialogue.SetActive(false);
            nextdialogue.SetActive(false);
            questmanager.GetComponent<QuestandItemsManager>().butterflyquestdone();
            dialogue8 = false;
        }

        if (dialogue9)
        {
            dialogue.SetActive(false);
            nextdialogue.SetActive(false);
            dialogue9 = false;
        }


        if (dialogue10)
        {
            dialogue.SetActive(false);
            nextdialogue.SetActive(false);
            dialogue10 = false;
        }

        if (dialogue11)
        {
            dialogue.SetActive(false);
            nextdialogue.SetActive(false);
            dialogue11 = false;
        }
    }

    public void DeadKitty1()
    {
        if(deadkitty1 == false)
        {
            nextdialogue.SetActive(true);

            dialogue.SetActive(true);
            deadkitty1 = true;
            nameui.text = "KittyCat";
            dialogueui.text = "What is that!!!...";
        }
    }

    public void SlugRequest()
    {
        nextdialogue.SetActive(true);

        dialogue.SetActive(true);
        dialogueui.text = "a Cat! Perfect... can you collect 3 angel carrots for me?";
        nameui.text = "Slug";
        dialogue4 = true;
    }

    public void SlugRequestComplete()
    {
        nextdialogue.SetActive(true);

        dialogue.SetActive(true);
        dialogueui.text = "... you brought all the carrots. these will come in handy. now, talk to butterfly.";
        nameui.text = "Slug";
        dialogue5 = true;
    }

    public void WoodliceTalk()
    {
        nextdialogue.SetActive(true);
        dialogue7 = true;

        nameui.text = "Woodlice";
        dialogueui.text = "....";
        dialogue.SetActive(true);
        bordercount++;
    }

    public void ButterflyTalk()
    {
        nextdialogue.SetActive(true);
        dialogue8 = true;

        dialogue.SetActive(true);
        nameui.text = "Butterfly";
        dialogueui.text = "You came to talk to me about ingredients? Heh. Just close your eyes.";
    }

    public void BugTalk()
    {
        nextdialogue.SetActive(true);
        dialogue9 = true;

        dialogue.SetActive(true);
        nameui.text = "Bug";
        dialogueui.text = "Hi! You must be new here!!";
        bordercount++;

    }

    public void SpiderTalk()
    {
        nextdialogue.SetActive(true);
        dialogue10 = true;

        dialogue.SetActive(true);

        nameui.text = "Spider";
        dialogueui.text = "Another meal I see...";
        bordercount++;

    }

    public void DyingKittyTalk()
    {
        nextdialogue.SetActive(true);
        dialogue11 = true;

        dialogue.SetActive(true);

        nameui.text = "Dying Kitty";
        dialogueui.text = "Get out of here NOW!";
    }
}
