using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x56576ecc;

public class _0x58a96848 : MonoBehaviour
{
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x58a96848>();
        this.RootGameObject = GameObject.FindWithTag(_0xb532b94b._0xe88b04e8(new byte[4] { 130, 191, 191, 164 }, 208));
        if (this._0x5653853e == _0x3578949a.SCENE_0)
            this._0x1784a8c9(true);
        else
            this._0x1784a8c9(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x6b4e97c9>(true).ToList();
    }

    public void _0x1784a8c9(bool _0x46b9e4c0)
    {
        this._0x42ac3830 = _0x46b9e4c0;
        this._0x27f6078e(!this._0x42ac3830);
        Physics2D.simulationMode = this._0x42ac3830 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xee15fdeb(this.EnvironmentWithTweensToToggle);
    }

    private static void MakeGrid(List<RectTransform> _0xcae17488, AspectRatioFitter _0x3c74f2c5, float _0x8c0ad89b, int _0x4b55f88d, int _0x4705b57c)
    {
        _0x3c74f2c5.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x3c74f2c5.aspectRatio = _0x8c0ad89b;
        foreach (RectTransform _0xdd436d3f in _0xcae17488)
        {
            int _0x1e67bf8d = _0xdd436d3f.transform.GetSiblingIndex();
            _0xdd436d3f.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x1e67bf8d % _0x4b55f88d) * (1f / _0x4b55f88d), (_0x4705b57c - (Mathf.FloorToInt((float)_0x1e67bf8d / _0x4b55f88d) % _0x4705b57c + 1f)) * (1f / _0x4705b57c));
            _0xdd436d3f.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x1e67bf8d % _0x4b55f88d + 1f) * (1f / _0x4b55f88d), (_0x4705b57c - Mathf.FloorToInt((float)_0x1e67bf8d / _0x4b55f88d) % _0x4705b57c) * (1f / _0x4705b57c));
            _0xdd436d3f.offsetMin = Vector2.zero;
            _0xdd436d3f.offsetMax = Vector2.zero;
        }
    }

    private static _0x21397b8a GAME_INDEX_SETTINGS(int _0x403682ed)
    {
        return _0x21397b8a.ALL_SCENES_SETTING_SINGLETONS[_0x403682ed];
    }

    public Button ShowResetTutorialButton;
    public Transform EnvironmentWithTweensToToggle;
    public Canvas MainCanvas;
    private static _0x21397b8a _0x28c3824b => _0x21397b8a.ALL_SCENES_SETTING_SINGLETONS[0];
    public static _0x21397b8a _0xba396e18 => _0x21397b8a.ALL_SCENES_SETTING_SINGLETONS[Instance._0x5653853e];

    private IEnumerator _0x3b0016d3(string _0xfa196643)
    {
        _0x5bd4077c.Instance._0x1c0e34af(_0x7463064a.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x5f69b8de = SceneManager.LoadSceneAsync(_0xfa196643);
        while (!_0x5f69b8de.isDone)
            yield return null;
    }

    public void _0xc5d3983e()
    {
        _0xba396e18._0x20496c73 = true;
    }

    public static bool IsAfterLevelFailed = false;
    public bool _0x42ac3830 { get; private set; }

    private IEnumerator _0xeea340c8(int _0xab7ee1c6)
    {
        _0x5bd4077c.Instance._0x1c0e34af(_0x7463064a.SPLASH);
        AsyncOperation _0x63a3fd37 = SceneManager.LoadSceneAsync(_0xab7ee1c6);
        while (!_0x63a3fd37.isDone)
            yield return null;
    }

    private void _0x27f6078e(bool _0x37a08b1d)
    {
        Rigidbody2D[] _0x71a8eee9 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0xe49f9de8 in _0x71a8eee9)
            if (_0x37a08b1d)
                _0xe49f9de8.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0xe49f9de8.constraints = RigidbodyConstraints2D.None;
    }

    public void _0x9134aeca()
    {
        this._0x1d00d384(SceneManager.GetActiveScene().buildIndex);
    }

    private void _0x5aa36de5()
    {
        IsAfterLevelComplete = true;
        Instance._0x1d00d384(_0x3578949a.SCENE_0);
    }

    public void _0x1d00d384(int _0x2acf46df)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xeea340c8(_0x2acf46df));
    }

    public void _0x6eed6489()
    {
        foreach (_0x6b4e97c9 _0x839491fe in this.MoneyCountContainers)
            _0x839491fe._0xecce7a85();
    }

    public Transform Environment;
    public static _0x58a96848 Instance;
    public Button DeleteProgressDataButton;
    private void _0xee15fdeb(Transform _0x449b2093)
    {
        Transform[] _0x8f19eda7 = _0x449b2093.GetComponentsInChildren<Transform>();
        foreach (Transform _0x5ad97541 in _0x8f19eda7)
            if (_0x5ad97541 != null && DOTween.IsTweening(_0x5ad97541))
            {
                if (this._0x42ac3830)
                    DOTween.Play(_0x5ad97541);
                else
                    DOTween.Pause(_0x5ad97541);
            }
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    public int _0x5653853e => SceneManager.GetActiveScene().buildIndex;

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public static bool IsAfterLevelComplete;
    [HideInInspector]
    public List<_0x6b4e97c9> MoneyCountContainers = new();
    private void Start()
    {
        if (this._0x5653853e != _0x3578949a.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0x1d00d384(_0x3578949a.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0xba396e18._0x20496c73 = false;
            _0x0067139d.Instance._0x66e2dc88();
            _0x5bd4077c.Instance._0x1c0e34af(_0x7463064a.TUTORIAL0);
        });
    }
}

internal static class _0xb532b94b
{
    internal static string _0xe88b04e8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}