using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeCardBack : MonoBehaviour
{
    public GameManager gM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeBack(int i)
    {
        if(gM.getTurnType())
        {
            Card c = gM.getAttackList()[i];
            gM.turnValues.Remove(c.getVal());
            gM.getCurrentPlayerHand().Add(c);
            gM.getAttackList().Remove(c);
            gM.firstCard = true;
            gM.turnValues.Remove(c.getVal());
        }
        else
        {
            Card c = gM.getDefendList()[i];
            gM.getCurrentPlayerHand().Add(c);
            gM.getDefendList().Remove(c);
            gM.firstCard = true;
        }
        gM.randomText.text = "";
    }
}
