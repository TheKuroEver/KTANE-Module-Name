using System.Collections;
using Assets.Scripts.Settings;
using UnityEngine;

public class VolumeTestModule : MonoBehaviour
{
    [SerializeField] private KMSelectable _button;
    // [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClip;
    [SerializeField] private TextMesh _display;

    private KMBombInfo _bombInfo;
    private KMBombModule _module;
    private KMAudio _audio;
    private MainMenu _menu;

    private static int s_moduleCount;
    private int _moduleId;

    private void Awake() {
        _moduleId = s_moduleCount++;

        _bombInfo = GetComponent<KMBombInfo>();
        _audio = GetComponent<KMAudio>();
        _module = GetComponent<KMBombModule>();

        // if (!Application.isEditor) {
        //     _menu = SceneManager.Instance.GameplayState.Room.MainMenu;
        //     _menu.SoundMenuPage.SfxEntryLeft.OnInteract += HandleButtonPress;
        //     _menu.SoundMenuPage.SfxEntryRight.OnInteract += HandleButtonPress;
        //     UpdateVolume();
        // }

        _button.OnInteract += () => { _audio.PlaySoundAtTransform(_audioClip.name, transform); return false; };
    }

    // private bool HandleButtonPress() {
    //     Invoke(nameof(UpdateVolume), .05f);
    //     return false;
    // }

    // private void UpdateVolume() {
    //     string sfxEntry = _menu.SoundMenuPage.SfxValue.text;
    //     _display.text = $"Current Volume:\n{sfxEntry}";
    //     _audioSource.volume = PlayerSettingsManager.Instance.PlayerSettings.SFXVolume / 100f;
    //     _display.text += " " + PlayerSettingsManager.Instance.PlayerSettings.SFXVolume;
    // }

    // private void OnDestroy() {
    //     if (!Application.isEditor) {
    //         _menu.SoundMenuPage.SfxEntryLeft.OnInteract -= HandleButtonPress;
    //         _menu.SoundMenuPage.SfxEntryRight.OnInteract -= HandleButtonPress;
    //     }
    // }

    public void Log(string message) => Debug.Log($"[{_module.ModuleType} #{_moduleId}] {message}");

#pragma warning disable 414
    private readonly string TwitchHelpMessage = @"Use '!{0} breh' to do things | '!{0} breh2' to do other things; extra information here.";
#pragma warning restore 414



    private bool TwitchPlaysActive;
    private bool TwitchShouldCancelCommand;

    private IEnumerator ProcessTwitchCommand(string command) {
        yield return "sendtochaterror TP has not yet been implemented.";
    }

    private IEnumerator TwitchHandleForcedSolve() {
        Debug.Log("TP autosolver has not yet been implemented. Calling KMBombModule.HandlePass.");
        _module.HandlePass();
        yield return null;
    }
}
