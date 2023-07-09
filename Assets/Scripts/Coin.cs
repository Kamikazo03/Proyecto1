using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    public int source;
    public int destination;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Moneda");

        gameObject.SetActive(false);
        //Destroy(gameObject);

        if (SceneManager.GetActiveScene().buildIndex == source) {
            SceneManager.LoadScene(destination);
        }
        else{
            SceneManager.LoadScene(source);
        }

    }
}
