using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x6ef8302c : MonoBehaviour
{
    private float _0xc61eb208;
    private TMP_Text _0x0e37c75d;
    private float _0x9f04409b = 4;
    private List<string> _0x9467e0e8 = new();
    private void Update()
    {
        int _0x38404472 = 1;
        if (this._0x9467e0e8.Count > 0)
        {
            string _0x227d757d = this._0x0e37c75d.text;
            foreach (string _0x6f36cc6d in this._0x9467e0e8)
                while (_0x227d757d.Contains(_0x6f36cc6d))
                    _0x227d757d = _0x227d757d.Replace(_0x6f36cc6d, "");
            _0x38404472 = _0x227d757d.Length;
        }
        else
        {
            _0x38404472 = this._0x0e37c75d.text.Length;
        }

        float _0xd5d016d9 = Mathf.Clamp(this._0xc61eb208 + this._0xba42b333 * _0x38404472, this._0xcd9ffa0d, this._0x9f04409b);
        if (!Mathf.Approximately(this._0x607dee9b.aspectRatio, _0xd5d016d9))
            this._0x607dee9b.aspectRatio = _0xd5d016d9;
    }

    private AspectRatioFitter _0x607dee9b;
    private float _0xba42b333 = 0.6f;
    private float _0xcd9ffa0d = 1.5f;
}