using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeCheckCrafting : MonoBehaviour
{
    [SerializeField] private GameObject gameManager;
    private int[] flag = new int[9];
    private void Start()
    {
       flag[0] = 0;
        flag[1] = 1;
        flag[2] = 2;
        flag[3] = 3;
        flag[4] = 4;
        flag[5] = 5;
        flag[6] = 6;
        flag[7] = 7;
        flag[8] = 8;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gold")
        {
            foreach (int value in flag)
            {
                if (this.name == "Case" + flag[value])
                    gameManager.GetComponent<Crafting>().TypeOfCase(value, "Gold");
            }
        }
        else if (other.tag == "Iron")
        {
            foreach (int value in flag)
            {
                if (this.name == "Case" + flag[value])
                    gameManager.GetComponent<Crafting>().TypeOfCase(value, "Iron");
            }
        }
        else if (other.tag == "Copper")
        {
            foreach (int value in flag)
            {
                if (this.name == "Case" + flag[value])
                    gameManager.GetComponent<Crafting>().TypeOfCase(value, "Copper");
            }
        }
        else if (other.tag == "Emerald")
        {
            foreach (int value in flag)
            {
                if (this.name == "Case" + flag[value])
                    gameManager.GetComponent<Crafting>().TypeOfCase(value, "Emerald");
            }
        }
        else if (other.tag == "BlueCrystal")
        {
            foreach (int value in flag)
            {
                if (this.name == "Case" + flag[value])
                    gameManager.GetComponent<Crafting>().TypeOfCase(value, "BlueCrystal");
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Gold")
        {
            foreach (int value in flag)
            {
                if (this.name == "Case" + flag[value])
                    gameManager.GetComponent<Crafting>().TypeOfCase(value, "Gold");
            }
        }
        else if (other.tag == "Iron")
        {
            foreach (int value in flag)
            {
                if (this.name == "Case" + flag[value])
                    gameManager.GetComponent<Crafting>().TypeOfCase(value, "Iron");
            }
        }
        else if (other.tag == "Copper")
        {
            foreach (int value in flag)
            {
                if (this.name == "Case" + flag[value])
                    gameManager.GetComponent<Crafting>().TypeOfCase(value, "Copper");
            }
        }
        else if (other.tag == "Emerald")
        {
            foreach (int value in flag)
            {
                if (this.name == "Case" + flag[value])
                    gameManager.GetComponent<Crafting>().TypeOfCase(value, "Emerald");
            }
        }
        else if (other.tag == "BlueCrystal")
        {
            foreach (int value in flag)
            {
                if (this.name == "Case" + flag[value])
                    gameManager.GetComponent<Crafting>().TypeOfCase(value, "BlueCrystal");
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        foreach (int value in flag)
        {
            if (this.name == "Case" + flag[value])
                gameManager.GetComponent<Crafting>().TypeOfCase(value, "");
        }
    }

}
