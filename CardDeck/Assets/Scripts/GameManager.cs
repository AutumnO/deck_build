using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject CardPrefab;

    public Button addToTopButton;
    public Button removeFromTopButton;
    public Button addToBottomButton;
    public Button removeFromBottomButton;

    private Deck _deck;

    public void addToTopTrigger()
    {
        Debug.Log("Add to Top Triggered");
        Card new_card = new Card();
        _deck.AddToTop(new_card);
    }

    public void addToBottomTrigger()
    {
        Debug.Log("Add to Bottom Triggered");
        Card new_card = new Card();
        _deck.AddToBottom(new_card);
    }

    public void removeFromTopTrigger()
    {
        Debug.Log("Draw From Top Triggered");
        _deck.DrawFromTop();
    }

    public void removeFromBottomTrigger()
    {
        Debug.Log("Draw From Bottom Triggered");
        _deck.DrawFromBottom();
    }

    // Start is called before the first frame update
    void Start()
    {
        _deck = new Deck();
        DrawTopCard();

    }

    //Draws top card from deck and displays it on the screen
    void DrawTopCard()
    {
        if (CardPrefab != null)
        {
            var card = GameObject.Instantiate<GameObject>(CardPrefab, Vector3.zero, Quaternion.identity);
            var controller = card.GetComponent<CardController>();

            //attach card C# object to card Unity object
            controller.Card = _deck.DrawFromTop();

            if (controller != null)
            {
                controller.FaceMaterial = PokerCardFactory.GetInstance().Materials[controller.Card.Name];
                controller.UpdateFaceMaterial();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}