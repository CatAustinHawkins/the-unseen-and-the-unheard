using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestandItemsManager : MonoBehaviour
{
    public int quests;

    public GameObject questitem;
    public GameObject inventoryitem;
    public GameObject questbutton;
    public GameObject itembutton;

    public GameObject quest2;
    public GameObject quest3;

    public Text quest1ui;
    public Text quest2ui;
    public Text quest3ui;

    public Text angelcarrotcount1;
    public int angelcarrotcount2;

    public GameObject slug;

    public GameObject questionborder;

    void Update()
    {
        if(angelcarrotcount2 > 2)
        {
            slug.GetComponent<Slug>().questcompleted();
            quest2ui.text = "quest 3 - complete";
            quests++;
            questionborder.SetActive(false);
        }
    }

    public void questopen()
    {
        questitem.SetActive(true);
        inventoryitem.SetActive(false);
        itembutton.SetActive(true);
        questbutton.SetActive(false);
    }

    public void questsclose()
    {
        questitem.SetActive(false);
        questbutton.SetActive(true);
    }

    public void itemopen()
    {
        inventoryitem.SetActive(true);
        questitem.SetActive(false);
        questbutton.SetActive(true);
        itembutton.SetActive(false);
    }

    public void itemclose()
    {
        inventoryitem.SetActive(false);
        itembutton.SetActive(true);
    }

    public void angelcarrotquest()
    {
        angelcarrotcount2++;
        angelcarrotcount1.text = angelcarrotcount2.ToString();
    }

    public void slugrequest()
    {
        quest3.SetActive(true);
    }

    public void butterflyquest()
    {
        quest3.SetActive(true);
    }

    public void butterflyquestdone()
    {
        SceneManager.LoadScene("IgnoranceEnding");
    }

    public void talkquest()
    {
        quest1ui.text = "quest 1 - complete";
    }
}
