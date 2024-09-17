using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class GameManager : MonoBehaviour
{
    public List<Card> gameDeck = new List<Card>();
    public List<Player> players = new List<Player>();
    public int numOfPlayers;
    public Card trump;
    private int playerIndex = 0;
    public List<Card> attackList = new List<Card>();
    public List<Card> defendList = new List<Card>();
    public List<int> turnValues = new List<int>();
    int def = 0;
    public Card playedCard;
    public Text buttonText;
    public Card tempCard;
    public GameObject newCard;
    public bool attacking;
    public Text text;
    public bool firstCard;
    public Text randomText;
    public Text cardsRemaining;
    public int endOfDeck;
    public Image giveUpImage;
    public Text giveUpText;
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject card4;
    public GameObject card5;
    public GameObject card6;
    public GameObject card7;
    public GameObject card8;
    public GameObject card9;
    public GameObject card10;
    public GameObject card11;
    public GameObject card12;
    public GameObject card13;
    public GameObject card14;
    public GameObject card15;
    public GameObject card16;
    public GameObject card17;
    public GameObject card18;
    public GameObject card19;
    public GameObject card20;
    public GameObject card21;
    public GameObject atk1;
    public GameObject atk2;
    public GameObject atk3;
    public GameObject atk4;
    public GameObject atk5;
    public GameObject atk6;
    public GameObject current1;
    public GameObject current2;
    public GameObject current3;
    public GameObject current4;
    public GameObject current5;
    public GameObject current6;
    public GameObject[] gamePlayerCards = new GameObject[21];
    public int endofDeck;
    int winIndex;
    public bool gameOver = false;
    public bool gameStarted = false;
    public SpriteRenderer sprite;
    public Text trumpText;
    public GameObject trumpImage;
    public GameObject endTurnButton;
    public GameObject rulesButton;
    public bool rules;
    public Text rulesText;
    public Text theRules1;
    public Text theRules2;
    public Text theRules3;
    public Text theRules4;
    public Text theRules5;
    void Start()
    {

        startGame();  
        playedCard = null;
        text.text = "nothing";
        randomText.text = "";
        firstCard = true;
        attacking = true;
        endOfDeck = 0;
        giveUpText.text = "";
        giveUpImage.enabled = false;
        numOfPlayers = 2;
        rules = true;
    }


    // Update is called once per frame
    void Update()
    {
        cardsRemaining.text = "Cards Remaining: " + gameDeck.Count;
        if (attacking)
        {
            text.text = players[playerIndex].getName() + " Attacking";
        }
        else
        {
            text.text = players[playerIndex].getName() + " Defending";
        }

        
    }
    public void goRules()
    {        
        int random = 999999;
        int random2 = 10000;
        rulesText.text = "Back to Game";
        if(!rules)
        {
            random = -999999;
            random2 = -10000;
            rulesText.text = "See Rules";
        }
        card1.transform.Translate(random, 0, 0);
        card2.transform.Translate(random, 0, 0);
        card3.transform.Translate(random, 0, 0);
        card4.transform.Translate(random, 0, 0);
        card5.transform.Translate(random, 0, 0);
        card6.transform.Translate(random, 0, 0);
        card7.transform.Translate(random, 0, 0);
        card8.transform.Translate(random, 0, 0);
        card9.transform.Translate(random, 0, 0);
        card10.transform.Translate(random, 0, 0);
        card11.transform.Translate(random, 0, 0);
        card12.transform.Translate(random, 0, 0);
        card13.transform.Translate(random, 0, 0);
        card14.transform.Translate(random, 0, 0);
        card15.transform.Translate(random, 0, 0);
        card16.transform.Translate(random, 0, 0);
        card17.transform.Translate(random, 0, 0);
        card18.transform.Translate(random, 0, 0);
        card19.transform.Translate(random, 0, 0);
        card20.transform.Translate(random, 0, 0);
        atk1.transform.Translate(random, 0, 0);
        atk2.transform.Translate(random, 0, 0);
        atk3.transform.Translate(random, 0, 0);
        atk4.transform.Translate(random, 0, 0);
        atk5.transform.Translate(random, 0, 0);
        atk6.transform.Translate(random, 0, 0);
        current1.transform.Translate(random, 0, 0);
        current2.transform.Translate(random, 0, 0);
        current3.transform.Translate(random, 0, 0);
        current4.transform.Translate(random, 0, 0);
        current5.transform.Translate(random, 0, 0);
        current6.transform.Translate(random, 0, 0);
        text.transform.Translate(random, 0, 0);
        randomText.transform.Translate(random, 0, 0);
        cardsRemaining.transform.Translate(random, 0, 0);
        trumpText.transform.Translate(random, 0, 0);
        trumpImage.transform.Translate(random, 0, 0);
        endTurnButton.transform.Translate(random, 0, 0);
        rulesButton.transform.Translate(random, 0, 0);
        theRules1.transform.Translate(random2, 0, 0);
        theRules2.transform.Translate(random2, 0, 0);
        theRules3.transform.Translate(random2, 0, 0);
        theRules4.transform.Translate(random2, 0, 0);
        theRules5.transform.Translate(random2, 0, 0);
        rules = !rules;
        
    }
    public void backToGame()
    {
        sprite.sortingOrder = 0;
    }
    public List<Card> getCurrentPlayerHand()
    {
        List<Card> temp = players[playerIndex].getHand();
        return temp;
    }
    public List<Card> getAttackList()
        {
            return attackList;
        }
    public List<Card> getDefendList()
    {
        return defendList;
    }
    public bool getTurnType()
    {
        return attacking;
    }
    public Card getTrump()
    {
        return trump;
    }
    public void fillDeck()
    {
        string[] suits = { "Spades", "Hearts", "Clubs", "Diamonds" };
        string[] types = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        int[] vals = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        for (int j = 0; j < suits.Length; j++)
        {
            for (int k = 0; k < types.Length; k++)
            {
                Instantiate(newCard);
                Card c = newCard.AddComponent<Card>();
                c.setCard(types[k], suits[j], vals[k]);
                c.name = c.toString();
                gameDeck.Add(c);
            }
        }
        
    }


    public Card greaterCard(Card card1, Card card2)
    {
        if (card1.getSuit() == card2.getSuit())
        {
            if (card1.getVal() > card2.getVal())
            {
                return card1;
            }
            else if (card1.getVal() < card2.getVal())
            {
                return card2;
            }
            else
            {
                return card1;
            }
        }
        else if (card1.getSuit() == trump.getSuit())
        {
            return card1;
        }
        else if (card2.getSuit() == trump.getSuit())
        {
            return card2;
        }
        else
        {
            if (card1.getVal() > card2.getVal())
            {
                return card1;
            }
            else if (card1.getVal() < card2.getVal())
            {
                return card2;
            }
            else
            {
                return card1;
            }
        }
    }


    public void addPlayers()
    {
        for (int i = 0; i < numOfPlayers; i++)
        {
            Player p = new Player("Player " + (i + 1), new List<Card>());
            players.Add(p);
            Debug.Log(players[i].getName());
           
        }
    }
    public Card drawCardStart()
    {
        Random rnd = new Random(System.Guid.NewGuid().GetHashCode());
        int num = rnd.Next(0, gameDeck.Count - 1);
        Card c = gameDeck[num];
        gameDeck.RemoveAt(num);
        return c;
    }
    public Card drawCard()
    {
        if (gameDeck.Count > 0)
        {
            Random rnd = new Random(System.Guid.NewGuid().GetHashCode());
            int num = rnd.Next(0, gameDeck.Count - 1);
            Card c = gameDeck[num];
            gameDeck.RemoveAt(num);
            return c;
        }
        else if (endOfDeck == 0)
        {
            endOfDeck = 1;
            return trump;
        }
        return null;
    }



    public void drawTrump()
    {
        Random rnd = new Random(System.Guid.NewGuid().GetHashCode());
        int num = rnd.Next(0, gameDeck.Count - 1);
        Card trumpCard = gameDeck[num];
        gameDeck.RemoveAt(num);
        trump = trumpCard;
       
    }

    public void playCard(Card card, Player player, int i)
    {
        if (i == 1)
        {
            player.removeCard(card);
            attackList.Add(card);
        }
        else
        {
            player.removeCard(card);
            defendList.Add(card);
        }
    }


    public void startGame()
    {
        addPlayers();
        fillDeck();
        drawTrump();
        Debug.Log(trump.toString());
        for (int j = 0; j < players.Count; j++)
        {
            for (int i = 0; i < 6; i++)
            {
                players[j].addCard(drawCardStart());
                tempCard = players[j].getHand()[i];
            }
        }
        
    }
   
    public void useCard(int i)
    {
        randomText.text = "";
        playedCard = players[playerIndex].getHand()[i];
        Debug.Log(playedCard.toString());
        if (firstCard)
        {
            if (attacking)
            {
                turnValues.Add(playedCard.getVal());
                firstCard = false;
                playCard(playedCard, players[playerIndex], 1);
            }
            else
            {
                turnValues.Add(playedCard.getVal());
                playCard(playedCard, players[playerIndex], 0);
            }
        }
        else
        {

            if (attacking)
            {
                bool temp = false;
                for (int j = 0; j < turnValues.Count; j++)
                {
                    if (playedCard.getVal() == turnValues[j])
                    {
                        temp = true;
                    }
                    else
                    {

                    }
                }
                if (temp)
                {
                    playCard(playedCard, players[playerIndex], 1);
                }
            }
            else
            {
                playCard(playedCard, players[playerIndex], 0);
            }
        }
        

    }
    

    public void emptyCardList(List<Card> list)
    {
        for(int i = 0; i < list.Count;)
        {
            list.RemoveAt(i);
        }
    }

    public bool validTurn()
    {
        for (int i = 0; i < attackList.Count; i++)
        {
            if (greaterCard(attackList[i], defendList[i]) == attackList[i])
            {
                return false;
            }
        }
        return true;
    }

 
    public void endTurn()
    {
        if (players[playerIndex].getHand().Count <= 6)
        {
            for (int i = 6; i < gamePlayerCards.Length; i++)
            {
               
            }
        }
        if (attacking && attackList.Count > 0)
        {
            if (gameDeck.Count > 6 - players[playerIndex].getHand().Count)
            {
                while (players[playerIndex].getHand().Count < 6)
                {
                    if (gameDeck.Count > 0 && endOfDeck == 0)
                    {
                        players[playerIndex].getHand().Add(drawCard());
                    }
                }
            }

            if (playerIndex == players.Count - 1)
            {
                playerIndex = 0;
            }
            else
            {
                playerIndex++;
            }
            attacking = !attacking;
            for (int i = 0; i < players[playerIndex].getHand().Count; i++)
            {
                
            }
        }
        else if (defendList.Count > 0 && validTurn() && attackList.Count == defendList.Count)
        {
            if (gameDeck.Count > 6 - players[playerIndex].getHand().Count) //FIGURE OUT DEFEND PLAYER INDEX??? DONT KNOW
            { 
            while (players[playerIndex].getHand().Count < 6)
            {
                if (gameDeck.Count > 0 && endOfDeck == 0)
                {
                    players[playerIndex].getHand().Add(drawCard());
                }
            }
            }
            for (int i = 0; i < turnValues.Count;)
            {
                turnValues.RemoveAt(i);
            }
            
            for (int i = 0; i < players[playerIndex].getHand().Count; i++)
            {
                float temp = 655 + i * (1180 / players[playerIndex].getHand().Count);
                //gamePlayerCards[i].transform.position = new Vector3(temp, -384.0f, 0);
                gamePlayerCards[i].transform.position = new Vector3(temp, 153, 0);
            }
            attacking = !attacking;
            emptyCardList(attackList);
            emptyCardList(defendList);
        }
        else
        {
            giveUpImage.enabled = true;
            giveUpText.text = "Give Up";
            randomText.text = "Sorry, you can't do this! Give up or try another combination of cards!";
            for (int i = 0; i < defendList.Count; i++)
            {

            }
        }

        firstCard = true;
    }
    public void giveUp()
    {
        if (players[playerIndex].getHand().Count <= 6)
        {
            
        }
        if (defendList.Count != 0)
        {
            randomText.text = "Sorry, you can't give up while you still have cards on the table!";
            return;
        }
        for (int i = 0; i < attackList.Count; i++)
        {
            players[playerIndex].addCard(attackList[i]);
        }
        for (int i = 0; i < turnValues.Count;)
        {
            turnValues.RemoveAt(i);
        }
        attacking = !attacking;
        emptyCardList(attackList);
        emptyCardList(defendList);
        giveUpImage.enabled = false;
        giveUpText.text = "";
       
    }
    public void checkWin()
    {
        if (players[playerIndex].getHand().Count == 0 && gameDeck.Count == 0 && endOfDeck == 1)
        {
            players.Remove(players[playerIndex]);
        }
    }
    public void checkLose()
    {
        if (players.Count == 1)
        {
            gameOver = true;
            SceneManager.LoadScene("Lose");
        }
    }


}
