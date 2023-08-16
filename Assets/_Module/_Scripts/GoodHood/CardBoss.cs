using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBoss : MonoBehaviour {

    private const float _cardYValue = 0.365f;

    [SerializeField] Card _cardPrefab;

    private List<Card> _activeCards = new List<Card>();

    public void MakeCard(PersonInfo person) {
        foreach (Card c in _activeCards)
            c.transform.localPosition += Vector3.forward;

        var card = Instantiate(_cardPrefab, transform);
        card.transform.localPosition = Vector3.up * _cardYValue;
        card.NameValue = person.Name;
        card.DepartmentValue = person.Department;
        card.BosianValue = person.Bosian;
        _activeCards.Add(card);
    }
}
