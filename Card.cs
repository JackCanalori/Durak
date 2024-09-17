using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private string suit;
    private string type;
    private int value;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public Card()
    {
   
    }
    public string getName()
    {
        return type;
    }
    public string getSuit()
    {
        return suit;
    }
    public int getVal()
    {
        return value;
    }
    public void setCard(string t, string s, int v)
    {
        type = t;
        suit = s;
        value = v;
    }
    public string toString()
    {
        return type + " of " + suit; 
    }
}
