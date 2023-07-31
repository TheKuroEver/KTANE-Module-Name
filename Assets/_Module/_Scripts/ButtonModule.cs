using System.Collections;
using UnityEngine;

public class ButtonModule : MonoBehaviour
{
    [SerializeField] private KMSelectable _button;

    private void Awake() {
        _button.OnInteract += DoSomething;
        _button.OnInteractEnded += DoSomethingElse;
    }

    private bool DoSomething() {
        Debug.Log("Press!");
        return false;
    }
    private void DoSomethingElse() => Debug.Log("Release!");
}
