using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Deck
{

    public Button addToTopButton;
    public Button removeFromTopButton;
    public Button addToBottomButton;
    public Button removeFromBottomButton;

    #region Public methods

    public void AddToTop(Card card)
    {
        Cards.AddLast(card);
    }

    public Card RemoveFromTop()
    {
        Card topCard = Cards.Last();
        Cards.RemoveLast();
        return topCard;

    }

    public void AddToBottom(Card card)
    {
        Cards.AddFirst(card);
    }

    public Card RemoveFromBottom()
    {
        Card bottomCard = Cards.First();
        Cards.RemoveFirst();
        return bottomCard;
    }

    #endregion



    protected LinkedList<Card> Cards { get; set; }

    public Deck()
    {
        Cards = new LinkedList<Card>();
    }



    public void Shuffle()
    {
         // private Vector2 card_vect = Cards.ToArray<Card>;
         // need to add Adam's new code to all 
    }

}
