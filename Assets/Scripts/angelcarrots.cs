using UnityEngine;

public class angelcarrots : MonoBehaviour
{
    public bool angelcarrotsquest;
    public GameObject questmanager;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(angelcarrotsquest)
        {
            questmanager.GetComponent<QuestandItemsManager>().angelcarrotquest();
            Destroy(gameObject);
        }
    }

    public void questbegin()
    {
        angelcarrotsquest = true;
    }
}
