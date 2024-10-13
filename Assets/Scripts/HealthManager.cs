using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public GameObject eye1;
    public GameObject eye2;
    public GameObject eye3;

    public GameObject openeye1;
    public GameObject openeye2;
    public GameObject openeye3;

    public int eyes;

    void Update()
    {
        if(eyes == 3)
        {
            SceneManager.LoadScene("TruthEnding");
        }
    }

    public void deadkittyspotted()
    {
        eye1.SetActive(false);
        openeye1.SetActive(true);
        eyes++;
    }

    public void Spiderspokento()
    {
        eye2.SetActive(false);
        openeye2.SetActive(true);
        eyes++;
    }

    public void dyingkitty()
    {
        eye3.SetActive(false);
        openeye3.SetActive(true);
        eyes++;
    }
}
