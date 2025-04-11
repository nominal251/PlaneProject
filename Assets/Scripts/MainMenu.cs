using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

<<<<<<<< Updated upstream:Assets/Scripts/MainMenu.cs
public class MainMenu : MonoBehaviour
========
public class SelfDestroyer : MonoBehaviour
>>>>>>>> Stashed changes:Assets/Scripts/SelfDestroyer.cs
{

    public float destructionTime;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, destructionTime);   
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<<< Updated upstream:Assets/Scripts/MainMenu.cs
        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Game");
        }*/
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
========
        
>>>>>>>> Stashed changes:Assets/Scripts/SelfDestroyer.cs
    }
}
