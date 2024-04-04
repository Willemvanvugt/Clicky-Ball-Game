using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private GameManager gameManager;
    public int value;

    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    private void OnMouseDown()
    {
        gameManager.UpdateScore(value);
        Debug.Log("Score added = " + value);
        Destroy(gameObject);
    }
}
