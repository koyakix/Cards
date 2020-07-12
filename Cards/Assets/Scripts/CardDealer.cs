using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDealer : MonoBehaviour
{

    private List<Card> deck = new List<Card>();
    private List<Card> playerHand = new List<Card>();

    // Start is called before the first frame update
    void Start()
    {
        deck = Deck.ShuffleDeck(Deck.GEtDeck());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CardDeal();
        }
    }

    public void CardDeal()
    {
        playerHand.Clear();

        if (deck.Count < 5)
        {
            deck.Clear();
            deck = Deck.ShuffleDeck(Deck.GEtDeck());
        }

        for (int i = 0; i<5; i++)
        {
            playerHand.Add(Deck.GetCard(deck));
        }

        foreach (var card in playerHand)
        {
            Debug.Log($"{ card.CardSuit}:{card.Number}");
        }
        Debug.Log(PokerHand.CardHand(playerHand));
    }
}
