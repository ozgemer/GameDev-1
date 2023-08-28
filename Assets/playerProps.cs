using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerProps : MonoBehaviour
{

    [SerializeField] private int healthPoints = 50;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Dummie")
        {
            healthPoints -= 10;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthPoints <= 0)
        {
            Debug.Log("DIED");
            //SceneManager.LoadScene("EndScene"); // END SCENE
        }
    }
}
