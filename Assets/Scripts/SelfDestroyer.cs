using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< Updated upstream

<<<<<<<< Updated upstream:Assets/Scripts/Explosion.cs
public class Explosion : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 2.5f);   
========
public class SelfDestroyer : MonoBehaviour
=======
using UnityEngine.SceneManagement;

<<<<<<<< Updated upstream:Assets/Scripts/MainMenu.cs
public class MainMenu : MonoBehaviour
========
public class SelfDestroyer : MonoBehaviour
>>>>>>>> Stashed changes:Assets/Scripts/SelfDestroyer.cs
>>>>>>> Stashed changes
{

    public float destructionTime;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, destructionTime);   
<<<<<<< Updated upstream
>>>>>>>> Stashed changes:Assets/Scripts/SelfDestroyer.cs
=======
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        
=======
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
>>>>>>> Stashed changes
    }
}
