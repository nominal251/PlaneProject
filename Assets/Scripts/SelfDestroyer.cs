using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<<< Updated upstream:Assets/Scripts/Explosion.cs
public class Explosion : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 2.5f);   
========
public class SelfDestroyer : MonoBehaviour
{

    public float destructionTime;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, destructionTime);   
>>>>>>>> Stashed changes:Assets/Scripts/SelfDestroyer.cs
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
