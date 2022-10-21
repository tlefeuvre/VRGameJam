using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OrdersManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> gameObjects = new List<GameObject>();
    [SerializeField] private List<GameObject> outlinedSnapZone = new List<GameObject>();
    [SerializeField] private GameObject orderSpawner;
    [SerializeField] private GameObject currentObject;
    [SerializeField] private int currentOrder = 0;
    //[SerializeField] private bool isOrderFinish = false;
    [SerializeField] private int score = 0;
    [SerializeField] private ParticleSystem chestParticle;
    [SerializeField] private AudioSource audioVictory;
    [SerializeField] private TMP_Text scoreUI;
    [SerializeField] private GameObject retry;
    [SerializeField] private GameObject retryUI;
    [SerializeField] private GameObject adminMenu;
    [SerializeField] private GameObject adminMenuUI;
    [SerializeField] private float gameTime = 10f;

    [SerializeField] private bool isFinish = false;
  void Start()
    {
        retry.SetActive(false);
        retryUI.SetActive(false);
        adminMenu.SetActive(false);
        adminMenuUI.SetActive(false);
        currentObject =  Instantiate(gameObjects[0], orderSpawner.transform.position, Quaternion.Euler(0,-90f,0));
        if(currentObject.GetComponent<Rigidbody>())
            currentObject.GetComponent<Rigidbody>().useGravity = false;
        if (currentObject.GetComponent<Outline>())
            currentObject.GetComponent<Outline>().OutlineWidth = 5;
       currentOrder = 0;
        StartCoroutine("Finish");

    }

    private void Update()
    {
        if (isFinish)
        {
            retry.SetActive(true);
            retryUI.SetActive(true);
            if (currentObject != null)
                Destroy(currentObject);
        }
       

        scoreUI.text = score.ToString();
        if (currentObject && !isFinish)
        {
            if (currentObject.tag == "Sword")
            {
                outlinedSnapZone[0].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[1].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineWidth = 0;

                outlinedSnapZone[3].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineColor = Color.yellow;
            }
            if (currentObject.tag == "Shield")
            {
                outlinedSnapZone[0].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[1].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineWidth = 0;

                outlinedSnapZone[1].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineColor =Color.red;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineColor = Color.gray;
            }
            if (currentObject.tag == "Helmet")
            {
                outlinedSnapZone[0].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[1].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineWidth = 0;
                
                outlinedSnapZone[0].GetComponent<Outline>().OutlineColor =Color.red;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineColor =Color.red;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineColor =Color.red;
                outlinedSnapZone[1].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineColor = Color.gray;
            }
            if (currentObject.tag == "Boots")
            {
                outlinedSnapZone[0].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[1].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineWidth = 8;


                outlinedSnapZone[1].GetComponent<Outline>().OutlineColor = Color.red;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineColor = Color.red;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineColor = Color.gray;
            }
            if (currentObject.tag == "Pants")
            {
                outlinedSnapZone[0].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[1].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineWidth = 8;

                outlinedSnapZone[1].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[0].GetComponent<Outline>().OutlineColor = Color.green;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineColor = Color.green;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineColor = Color.yellow;
            }
            if (currentObject.tag == "Chestplate")
            {
                outlinedSnapZone[0].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[1].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineWidth = 8;

                outlinedSnapZone[3].GetComponent<Outline>().OutlineColor =Color.red;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineColor = Color.blue;
                outlinedSnapZone[1].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineColor = Color.gray;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineColor = Color.gray;
            }
            if (currentObject.tag == "MagicStaff")
            {
                outlinedSnapZone[0].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[1].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[2].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[3].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineWidth = 8;
                outlinedSnapZone[7].GetComponent<Outline>().OutlineWidth = 0;
                outlinedSnapZone[8].GetComponent<Outline>().OutlineWidth = 0;

                outlinedSnapZone[3].GetComponent<Outline>().OutlineColor = Color.blue;
                outlinedSnapZone[4].GetComponent<Outline>().OutlineColor =Color.red;
                outlinedSnapZone[5].GetComponent<Outline>().OutlineColor =Color.red;
                outlinedSnapZone[0].GetComponent<Outline>().OutlineColor = Color.green;
                outlinedSnapZone[6].GetComponent<Outline>().OutlineColor = Color.green;
            }
        }
       
    }

    private IEnumerator Finish()
    {
        yield return new WaitForSeconds(gameTime);
        isFinish = true;
        Debug.Log("FIN PARTIE");
    }
    private void NewOrder()
    {
        int newOrder = Random.Range(0, gameObjects.Count);
        currentObject = Instantiate(gameObjects[newOrder], orderSpawner.transform.position, Quaternion.identity);
        if (currentObject.GetComponent<Rigidbody>())
            currentObject.GetComponent<Rigidbody>().useGravity = false;
        if (currentObject.GetComponent<Outline>())
            currentObject.GetComponent<Outline>().OutlineWidth = 5;

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Key")
        {
            adminMenu.SetActive(true);
            adminMenuUI.SetActive(true);
        }
        else if(other.tag == currentObject.tag && !isFinish)
        {
            audioVictory.Play();
            GetComponent<Tutorial>().TutorialFinished();
            score += 1;
            Destroy(other.gameObject    );
            Destroy(currentObject.gameObject) ;
            chestParticle.Play();
            NewOrder();
        }
        

    }
}
