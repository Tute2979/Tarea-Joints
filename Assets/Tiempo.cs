using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour
{
    public Image tiempo;
    public float x = 180;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        x -= Time.deltaTime;
        if (x > 0)
        {
            tiempo.fillAmount = x / 180;
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }
}