using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coding : MonoBehaviour
{
    Rigidbody rb;
    public GameObject WinText;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.R))
       {
        SceneManager.LoadScene("Level-2");
       } 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Cube")
        {
            Destroy(other.gameObject);
            WinText.SetActive(true);
        }
    }
}
