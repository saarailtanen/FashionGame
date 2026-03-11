using UnityEngine;
using UnityEngine.SceneManagement;

public class CityCentre : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Get to scenes from citycentre
    public void TeleportHome()
    {
        SceneManager.LoadScene("Home");
    }

    public void TeleportArcade()
    {
        SceneManager.LoadScene("Arcade");
    }

    public void TeleportMall()
    {
        SceneManager.LoadScene("Mall");
    }
}
