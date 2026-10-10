using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x0cc9cf21 : MonoBehaviour
{
    public bool IsLoadCurrentScene;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x58a96848.Instance._0x1d00d384(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x58a96848.Instance._0x1d00d384(this.LoadSceneId));
    }

    public int LoadSceneId;
    public Button Button;
}