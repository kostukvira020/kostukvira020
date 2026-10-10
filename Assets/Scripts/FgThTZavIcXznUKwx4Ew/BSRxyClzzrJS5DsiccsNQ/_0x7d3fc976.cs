using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x7d3fc976 : MonoBehaviour
{
    private void Update()
    {
        this._0xfab6676b();
    }

    private Image _0x6fe06245;
    private TMP_Text _0x3f26e986;
    private void _0xfab6676b()
    {
        if (this._0x6fe06245.canvasRenderer.GetColor() != this._0x3f26e986.canvasRenderer.GetColor())
            this._0x3f26e986.canvasRenderer.SetColor(this._0x6fe06245.canvasRenderer.GetColor());
    }
}