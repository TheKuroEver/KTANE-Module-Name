using System.Collections;
using UnityEngine;

public class GoodHoodModule : MonoBehaviour
{
    [SerializeField] private KMSelectable _button;
    [SerializeField] private CardBoss _boss;

    private string[] _names = new string[] {
        "GoodHood",
        "Bruh",
        "Play",
        "Bruhickle"
    };
    private string[] _departments = new string[] {
        "Hawker",
        "Senria",
        "Science",
        "Kuro"
    };
    private string[] _bosians = new string[] {
        "TheKuroEver",
        "PinklePurpleBossBoss",
        "Mar",
        "Hajnoodle"
    };

    private PersonInfo MakeRandomPerson() => new PersonInfo(_names.PickRandom(), _departments.PickRandom(), _bosians.PickRandom());


    private void Awake() {
        _button.OnInteract += () => { _boss.MakeCard(MakeRandomPerson()); return false; };
    }
}