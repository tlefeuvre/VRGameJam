using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class Crafting : MonoBehaviour
{
    private int[] values = new int[9];
    [SerializeField] private string[] types = new string[9];
    public List<GameObject> listObject = new List<GameObject>();
    public List<GameObject> spawners = new List<GameObject>();
    public GameObject particleWeapon;
    public GameObject spawner;
    [SerializeField]private bool flag = false;
    private void Start()
    {
        foreach (int value in values)
        {
            values[value] = 0;
            types[value] = "";
        }
    }
    // Update is called once per frame
    void Update()
    {
       
        if (types[3] == "Iron")
        {
            if (types[4] == "Iron" && types[5] == "Gold")
            {
                Debug.Log("CraftSword");
                particleWeapon.SetActive(true);
                if (flag == false)
                {
                    Instantiate(listObject[4], spawner.transform);
                    Debug.Log("trst");
                    flag = true;
                }
            }
            else if (types[4] == "Copper" && types[1] == "Iron" && types[7] == "Iron" && types[5] == "Iron")
            {
                Debug.Log("CraftShield");
                particleWeapon.SetActive(true);
                if (flag == false)
                {
                    Instantiate(listObject[6], spawner.transform);
                    flag = true;
                }
            }
        }
        else if (types[3] == "Copper")
        {
            if (types[0] == "Copper" && types[6] == "Copper" && types[1] == "Iron" && types[7] == "Iron")
            {
                Debug.Log("CraftHelmet");
                particleWeapon.SetActive(true);
                if (flag == false)
                {
                    Instantiate(listObject[0], spawner.transform);
                    flag = true;
                }
            }
            else if (types[1] == "Iron" && types[4] == "BlueCrystal" && types[7] == "Iron" && types[2] == "Iron" && types[5] == "Iron" && types[8] == "Iron")
            {
                Debug.Log("CraftChestplate");
                particleWeapon.SetActive(true);
                if (flag == false)
                {
                    Instantiate(listObject[2], spawner.transform);
                    flag = true;

                }
            }
        }
        else if (types[2] == "Iron" && types[8] == "Iron")
        {
            if (types[1] == "Iron" && types[7] == "Iron" && types[0] == "Emerald" && types[6] == "Emerald" && types[3] == "Gold")
            {
                Debug.Log("CraftPants");
                particleWeapon.SetActive(true);
                if (flag == false)
                {
                    Instantiate(listObject[3], spawner.transform);
                    flag = true;
                 }
             }
            else if (types[1] == "Copper" && types[7] == "Copper")
            {
                Debug.Log("CraftBoots");
                particleWeapon.SetActive(true);
                if (flag == false)
                {
                    Instantiate(listObject[1], spawner.transform);
                    flag = true;
                }
            }
        }
        else if (types[0] == "Emerald" && types[6] == "Emerald" && types[3] == "BlueCrystal" && types[4] == "Copper" && types[5] == "Copper")
        {
            Debug.Log("CraftMagicStaff");
            particleWeapon.SetActive(true);
            if (flag == false)
            {
                Instantiate(listObject[5], spawner.transform);
                flag = true;
            }
        }
        else
        {
            particleWeapon.SetActive(false);
            flag = false;
        }
        /*
        if (values[5] == 1)
        {
            if (values[4] == 1 && values[3] == 1)
            {
                Debug.Log("CraftSword");
            }
            if (values[1] == 1 && values[3] == 1 && values[7] == 1)
            {
                Debug.Log("CraftShield");
            }
        }*/
    }


    public void TypeOfCase(int num, string type)
    {
        types[num] = type;
    }
}
 /*
    public void Case0IsUsed()
    {
        values[0] = 1;
    }
    public void Case1IsUsed()
    {
        values[1] = 1;
    }
    public void Case2IsUsed()
    {
        values[2] = 1;
    }
    public void Case3IsUsed()
    {
        values[3] = 1;
    }
    public void Case4IsUsed()
    {
        values[4] = 1;
    }
    public void Case5IsUsed()
    {
        values[5] = 1;
    }
    public void Case6IsUsed()
    {
        values[6] = 1;
    }
    public void Case7IsUsed()
    {
        values[7] = 1;
    }
    public void Case8IsUsed()
    {
        values[8] = 1;
    }
    public void Case0IsLeaved()
    {
        values[0] = 0;
    }
    public void Case1IsLeaved()
    {
        values[1] = 0;
    }
    public void Case2IsLeaved()
    {
        values[2] = 0;
    }
    public void Case3IsLeaved()
    {
        values[3] = 0;
    }
    public void Case4IsLeaved()
    {
        values[4] = 0;
    }
    public void Case5IsLeaved()
    {
        values[5] = 0;
    }
    public void Case6IsLeaved()
    {
        values[6] = 0;
    }
    public void Case7IsLeaved()
    {
        values[7] = 0;
    }
    public void Case8IsLeaved()
    {
        values[8] = 0;
    }*/

