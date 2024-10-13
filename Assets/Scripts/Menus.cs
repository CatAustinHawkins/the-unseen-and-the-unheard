using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{

    public GameObject aboutmenu;
    public GameObject mainmenu1;

    public void AboutMenu()
    {
        aboutmenu.SetActive(true);
        mainmenu1.SetActive(false);
    }

    public void AboutMenuClose()
    {
        aboutmenu.SetActive(false);
        mainmenu1.SetActive(true);
    }

    public void gamebegin()
    {
        SceneManager.LoadScene("Area");
    }
}
