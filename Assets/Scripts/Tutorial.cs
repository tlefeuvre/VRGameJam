using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] private List<GameObject> gameObjects = new List<GameObject>();
    private bool firstCall = false;
    private bool secondCall = false;
    void Start()
    {
        if( gameObjects.Count >= 3)
        {
            gameObjects[1].SetActive(true);

            gameObjects[1].SetActive(false);
            gameObjects[2].SetActive(false);
        }
      
    }
  
    public void FirstStepFinished()
    {
        gameObjects[0].SetActive(false);
        gameObjects[1].SetActive(true);
    }
    public void SecondStepFinished()
    {
        if(secondCall == false)
        {
            gameObjects[1].SetActive(false);
            gameObjects[2].SetActive(true);
            secondCall = true;

        }

    }
    public void TutorialFinished()
    {
        gameObjects[2].SetActive(false);

    }
}
