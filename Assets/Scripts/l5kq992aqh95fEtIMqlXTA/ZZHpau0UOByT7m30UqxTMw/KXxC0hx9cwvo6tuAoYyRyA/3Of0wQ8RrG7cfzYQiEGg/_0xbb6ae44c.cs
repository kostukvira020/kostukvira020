using UnityEngine;
using UnityEngine.UI;

public class _0xbb6ae44c : MonoBehaviour
{
    private void Start()
    {
        if (this._0x8de60dc1)
            this._0x2f657e85.onClick.AddListener(() => _0x5bd4077c.Instance._0x2572bc2d());
        else
            this._0x2f657e85.onClick.AddListener(() => _0x5bd4077c.Instance._0x1c0e34af(this._0x46f289b8));
    }

    private void Awake()
    {
        if (this._0x2f657e85 == null)
            if (!this.TryGetComponent(out this._0x2f657e85))
                this._0x2f657e85 = this.GetComponentInChildren<Button>();
    }

    private Button _0x2f657e85;
    private int _0x46f289b8;
    private bool _0x8de60dc1;
}