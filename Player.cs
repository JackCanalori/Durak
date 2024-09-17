using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string playerName;
    private List<Card> hand;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public Player(string n, List<Card> h)
    {
        playerName = n;
        hand = h;
    }
    public string getName()
    {
        return playerName; 
    }
    public List<Card> getHand()
    {
        return hand;
    }
    public void addCard(Card c)
    {
        hand.Add(c);
    }
    public void removeCard(Card c)
    {
        hand.Remove(c);
    }


}
