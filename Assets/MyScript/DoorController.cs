using UnityEngine;
public class DoorController : MonoBehaviour
{
    public GameObject otelKapi;
    public Canvas canvas1;

    private void Start()
    {
        if (canvas1 == null)
        {
            otelKapi.SetActive(false);
        }
    }
}
