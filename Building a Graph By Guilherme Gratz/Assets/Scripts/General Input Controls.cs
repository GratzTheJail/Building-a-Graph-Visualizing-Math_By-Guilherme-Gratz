using UnityEngine;

public class GeneralInputControls : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            print("Application quit");
            Application.Quit();
        }
    }
}
