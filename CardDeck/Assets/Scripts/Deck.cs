using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        Debug.Log("Add to Top Completed");
    }

    public Card DrawFromTop()
    {
        Debug.Log("Draw From Top Completed");
        Card topCard = Cards.Last();
        Cards.RemoveLast();
        return topCard;

    }

    public void AddToBottom(Card card)
    {
        Cards.AddFirst(card);
        Debug.Log("Add to Bottom Completed");
    }

    public Card DrawFromBottom()
    {
        Debug.Log("Draw From Bottom Completed");
        Card bottomCard = Cards.First();
        Cards.RemoveFirst();
        return bottomCard;
    }

    #endregion


    protected LinkedList<Card> Cards { get; set; }

    public Deck()
    {
        Cards = new LinkedList<Card>();
        for (var i = 0; i < 52; i++)
        {
            Card new_card = new Card();
            Cards.AddLast(new_card);
        }
    }



    public void Shuffle()
    {

        Card[] deck_vect = new Card[Cards.Count];
        int index = 0;
        int random = Random.Range(0, Cards.Count);

        foreach(Card card_i in Cards)
        {
            deck_vect[index] = card_i;
            index++;
        }


        for(var i = 0; i < deck_vect.Length; i++)
        {
            random = Random.Range(0, deck_vect.Length);

            Card temp = deck_vect[i];
            deck_vect[i] = deck_vect[random];
            deck_vect[random] = temp;
        }
        
        Cards = new LinkedList<Card>();

        for(var i = 0; i < deck_vect.Length; i++)
        {
            //convert deck into Linked List
            Cards.AddLast(deck_vect[i]);
        }
    }

    public void Merge(Deck new_deck)
    {
        LinkedListNode<Card> current = new_deck.Cards.First;

        foreach(Card card_i in new_deck.Cards)
        {
            Cards.AddLast(current.Value);
            current = current.Next;
        }

        // ???      do I want to shuffle after merge?        ???
    }

}
