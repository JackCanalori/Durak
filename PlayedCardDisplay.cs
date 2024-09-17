using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayedCardDisplay : MonoBehaviour
{
    public GameManager gM;
    public List<Card> currentList;
    public Card currentCard;
    public int index;
    public Sprite aceSpades;
    public Sprite twoSpades;
    public Sprite threeSpades;
    public Sprite fourSpades;
    public Sprite fiveSpades;
    public Sprite sixSpades;
    public Sprite sevenSpades;
    public Sprite eightSpades;
    public Sprite nineSpades;
    public Sprite tenSpades;
    public Sprite jackSpades;
    public Sprite queenSpades;
    public Sprite kingSpades;
    public Sprite aceClubs;
    public Sprite twoClubs;
    public Sprite threeClubs;
    public Sprite fourClubs;
    public Sprite fiveClubs;
    public Sprite sixClubs;
    public Sprite sevenClubs;
    public Sprite eightClubs;
    public Sprite nineClubs;
    public Sprite tenClubs;
    public Sprite jackClubs;
    public Sprite queenClubs;
    public Sprite kingClubs;
    public Sprite aceHearts;
    public Sprite twoHearts;
    public Sprite threeHearts;
    public Sprite fourHearts;
    public Sprite fiveHearts;
    public Sprite sixHearts;
    public Sprite sevenHearts;
    public Sprite eightHearts;
    public Sprite nineHearts;
    public Sprite tenHearts;
    public Sprite jackHearts;
    public Sprite queenHearts;
    public Sprite kingHearts;
    public Sprite aceDiamonds;
    public Sprite twoDiamonds;
    public Sprite threeDiamonds;
    public Sprite fourDiamonds;
    public Sprite fiveDiamonds;
    public Sprite sixDiamonds;
    public Sprite sevenDiamonds;
    public Sprite eightDiamonds;
    public Sprite nineDiamonds;
    public Sprite tenDiamonds;
    public Sprite jackDiamonds;
    public Sprite queenDiamonds;
    public Sprite kingDiamonds;
    public Sprite[,] spritesArray = new Sprite[4, 13];
    public Image cardImage;
    public bool attack;
    // Start is called before the first frame update
    void Start()
    {



        spritesArray[0, 0] = aceSpades;
        spritesArray[0, 1] = twoSpades;
        spritesArray[0, 2] = threeSpades;
        spritesArray[0, 3] = fourSpades;
        spritesArray[0, 4] = fiveSpades;
        spritesArray[0, 5] = sixSpades;
        spritesArray[0, 6] = sevenSpades;
        spritesArray[0, 7] = eightSpades;
        spritesArray[0, 8] = nineSpades;
        spritesArray[0, 9] = tenSpades;
        spritesArray[0, 10] = jackSpades;
        spritesArray[0, 11] = queenSpades;
        spritesArray[0, 12] = kingSpades;

        spritesArray[1, 0] = aceClubs;
        spritesArray[1, 1] = twoClubs;
        spritesArray[1, 2] = threeClubs;
        spritesArray[1, 3] = fourClubs;
        spritesArray[1, 4] = fiveClubs;
        spritesArray[1, 5] = sixClubs;
        spritesArray[1, 6] = sevenClubs;
        spritesArray[1, 7] = eightClubs;
        spritesArray[1, 8] = nineClubs;
        spritesArray[1, 9] = tenClubs;
        spritesArray[1, 10] = jackClubs;
        spritesArray[1, 11] = queenClubs;
        spritesArray[1, 12] = kingClubs;

        spritesArray[2, 0] = aceHearts;
        spritesArray[2, 1] = twoHearts;
        spritesArray[2, 2] = threeHearts;
        spritesArray[2, 3] = fourHearts;
        spritesArray[2, 4] = fiveHearts;
        spritesArray[2, 5] = sixHearts;
        spritesArray[2, 6] = sevenHearts;
        spritesArray[2, 7] = eightHearts;
        spritesArray[2, 8] = nineHearts;
        spritesArray[2, 9] = tenHearts;
        spritesArray[2, 10] = jackHearts;
        spritesArray[2, 11] = queenHearts;
        spritesArray[2, 12] = kingHearts;

        spritesArray[3, 0] = aceDiamonds;
        spritesArray[3, 1] = twoDiamonds;
        spritesArray[3, 2] = threeDiamonds;
        spritesArray[3, 3] = fourDiamonds;
        spritesArray[3, 4] = fiveDiamonds;
        spritesArray[3, 5] = sixDiamonds;
        spritesArray[3, 6] = sevenDiamonds;
        spritesArray[3, 7] = eightDiamonds;
        spritesArray[3, 8] = nineDiamonds;
        spritesArray[3, 9] = tenDiamonds;
        spritesArray[3, 10] = jackDiamonds;
        spritesArray[3, 11] = queenDiamonds;
        spritesArray[3, 12] = kingDiamonds;
        cardImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (attack)
        {
            
            currentList = gM.getAttackList();
           
        }
        else
        {
            if (!gM.getTurnType())
            {
                currentList = gM.getDefendList();
            }
            else
            {
                currentList = gM.getAttackList(); 
            }
        }

        if (index < currentList.Count)
        {
            cardImage.enabled = true;
            currentCard = currentList[index];
            string temp = currentCard.getSuit();
            if (temp.Equals("Spades"))
            {
                if (currentCard.getName().Equals("Ace"))
                {
                    cardImage.sprite = spritesArray[0, 0];
                }
                else if (currentCard.getName().Equals("2"))
                {
                    cardImage.sprite = spritesArray[0, 1];
                }
                else if (currentCard.getName().Equals("3"))
                {
                    cardImage.sprite = spritesArray[0, 2];
                }
                else if (currentCard.getName().Equals("4"))
                {
                    cardImage.sprite = spritesArray[0, 3];
                }
                else if (currentCard.getName().Equals("5"))
                {
                    cardImage.sprite = spritesArray[0, 4];
                }
                else if (currentCard.getName().Equals("6"))
                {
                    cardImage.sprite = spritesArray[0, 5];
                }
                else if (currentCard.getName().Equals("7"))
                {
                    cardImage.sprite = spritesArray[0, 6];
                }
                else if (currentCard.getName().Equals("8"))
                {
                    cardImage.sprite = spritesArray[0, 7];
                }
                else if (currentCard.getName().Equals("9"))
                {
                    cardImage.sprite = spritesArray[0, 8];
                }
                else if (currentCard.getName().Equals("10"))
                {
                    cardImage.sprite = spritesArray[0, 9];
                }
                else if (currentCard.getName().Equals("Jack"))
                {
                    cardImage.sprite = spritesArray[0, 10];
                }
                else if (currentCard.getName().Equals("Queen"))
                {
                    cardImage.sprite = spritesArray[0, 11];
                }
                else if (currentCard.getName().Equals("King"))
                {
                    cardImage.sprite = spritesArray[0, 12];
                }
            }
            else if (temp.Equals("Clubs"))
            {

                if (currentCard.getName().Equals("Ace"))
                {
                    cardImage.sprite = spritesArray[1, 0];
                }
                else if (currentCard.getName().Equals("2"))
                {
                    cardImage.sprite = spritesArray[1, 1];
                }
                else if (currentCard.getName().Equals("3"))
                {
                    cardImage.sprite = spritesArray[1, 2];
                }
                else if (currentCard.getName().Equals("4"))
                {
                    cardImage.sprite = spritesArray[1, 3];
                }
                else if (currentCard.getName().Equals("5"))
                {
                    cardImage.sprite = spritesArray[1, 4];
                }
                else if (currentCard.getName().Equals("6"))
                {
                    cardImage.sprite = spritesArray[1, 5];
                }
                else if (currentCard.getName().Equals("7"))
                {
                    cardImage.sprite = spritesArray[1, 6];
                }
                else if (currentCard.getName().Equals("8"))
                {
                    cardImage.sprite = spritesArray[1, 7];
                }
                else if (currentCard.getName().Equals("9"))
                {
                    cardImage.sprite = spritesArray[1, 8];
                }
                else if (currentCard.getName().Equals("10"))
                {
                    cardImage.sprite = spritesArray[1, 9];
                }
                else if (currentCard.getName().Equals("Jack"))
                {
                    cardImage.sprite = spritesArray[1, 10];
                }
                else if (currentCard.getName().Equals("Queen"))
                {
                    cardImage.sprite = spritesArray[1, 11];
                }
                else if (currentCard.getName().Equals("King"))
                {
                    cardImage.sprite = spritesArray[1, 12];
                }
            }
            else if (temp.Equals("Hearts"))
            {

                if (currentCard.getName().Equals("Ace"))
                {
                    cardImage.sprite = spritesArray[2, 0];
                }
                else if (currentCard.getName().Equals("2"))
                {
                    cardImage.sprite = spritesArray[2, 1];
                }
                else if (currentCard.getName().Equals("3"))
                {
                    cardImage.sprite = spritesArray[2, 2];
                }
                else if (currentCard.getName().Equals("4"))
                {
                    cardImage.sprite = spritesArray[2, 3];
                }
                else if (currentCard.getName().Equals("5"))
                {
                    cardImage.sprite = spritesArray[2, 4];
                }
                else if (currentCard.getName().Equals("6"))
                {
                    cardImage.sprite = spritesArray[2, 5];
                }
                else if (currentCard.getName().Equals("7"))
                {
                    cardImage.sprite = spritesArray[2, 6];
                }
                else if (currentCard.getName().Equals("8"))
                {
                    cardImage.sprite = spritesArray[2, 7];
                }
                else if (currentCard.getName().Equals("9"))
                {
                    cardImage.sprite = spritesArray[2, 8];
                }
                else if (currentCard.getName().Equals("10"))
                {
                    cardImage.sprite = spritesArray[2, 9];
                }
                else if (currentCard.getName().Equals("Jack"))
                {
                    cardImage.sprite = spritesArray[2, 10];
                }
                else if (currentCard.getName().Equals("Queen"))
                {
                    cardImage.sprite = spritesArray[2, 11];
                }
                else if (currentCard.getName().Equals("King"))
                {
                    cardImage.sprite = spritesArray[2, 12];
                }
            }
            else
            {

                if (currentCard.getName().Equals("Ace"))
                {
                    cardImage.sprite = spritesArray[3, 0];
                }
                else if (currentCard.getName().Equals("2"))
                {
                    cardImage.sprite = spritesArray[3, 1];
                }
                else if (currentCard.getName().Equals("3"))
                {
                    cardImage.sprite = spritesArray[3, 2];
                }
                else if (currentCard.getName().Equals("4"))
                {
                    cardImage.sprite = spritesArray[3, 3];
                }
                else if (currentCard.getName().Equals("5"))
                {
                    cardImage.sprite = spritesArray[3, 4];
                }
                else if (currentCard.getName().Equals("6"))
                {
                    cardImage.sprite = spritesArray[3, 5];
                }
                else if (currentCard.getName().Equals("7"))
                {
                    cardImage.sprite = spritesArray[3, 6];
                }
                else if (currentCard.getName().Equals("8"))
                {
                    cardImage.sprite = spritesArray[3, 7];
                }
                else if (currentCard.getName().Equals("9"))
                {
                    cardImage.sprite = spritesArray[3, 8];
                }
                else if (currentCard.getName().Equals("10"))
                {
                    cardImage.sprite = spritesArray[3, 9];
                }
                else if (currentCard.getName().Equals("Jack"))
                {
                    cardImage.sprite = spritesArray[3, 10];
                }
                else if (currentCard.getName().Equals("Queen"))
                {
                    cardImage.sprite = spritesArray[3, 11];
                }
                else if (currentCard.getName().Equals("King"))
                {
                    cardImage.sprite = spritesArray[3, 12];
                }

            }
        }
        else
        {
            cardImage.enabled = false;
        }

    }
}
