using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x33419775 : MonoBehaviour
{
    private Vector3 _0xd08cfe6f { get; set; }
    //public bool executeInUpdate;
    private float _0x2f1acd04 { get; set; }
    private Vector3 _0xa80ce242 { get; set; }

    private Color _0x8c1b61fd = Color.white;
    private static _0x33419775 _0x189bc52d;
    private Vector3 _0x829f11b1 { get; set; }
    private Vector3 _0xf6fd66eb { get; set; }

    private _0xdc64e08f _0x7d4233be = _0xdc64e08f.Portrait;
    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x8c1b61fd;
        Matrix4x4 _0x3144e33a = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x75d2fafc.orthographic)
        {
            float _0x5c353803 = this._0x75d2fafc.farClipPlane - this._0x75d2fafc.nearClipPlane;
            float _0x5c0ae60e = (this._0x75d2fafc.farClipPlane + this._0x75d2fafc.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x5c0ae60e), new Vector3(this._0x75d2fafc.orthographicSize * 2 * this._0x75d2fafc.aspect, this._0x75d2fafc.orthographicSize * 2, _0x5c353803));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x75d2fafc.fieldOfView, this._0x75d2fafc.farClipPlane, this._0x75d2fafc.nearClipPlane, this._0x75d2fafc.aspect);
        }

        Gizmos.matrix = _0x3144e33a;
    }

    public enum _0xdc64e08f
    {
        Landscape,
        Portrait
    }

    private Vector3 _0x34d465a8 { get; set; }
    private Vector3 _0xc7bc0841 { get; set; }
    private float _0x59c26483 { get; set; }

    private void _0xc43b3583()
    {
        float _0xafad5dca, _0xa456ebcf, _0x6c9ba8b7, _0xb022910a;
        if (this._0x7d4233be == _0xdc64e08f.Landscape)
            this._0x75d2fafc.orthographicSize = 1f / this._0x75d2fafc.aspect * this._0xed792a05 / 2f;
        else
            this._0x75d2fafc.orthographicSize = this._0xed792a05 / 2f;
        this._0x59c26483 = 2f * this._0x75d2fafc.orthographicSize;
        this._0x2f1acd04 = this._0x59c26483 * this._0x75d2fafc.aspect;
        float _0xda4d8b70 = this._0x75d2fafc.transform.position.x;
        float _0xaf93a3aa = this._0x75d2fafc.transform.position.y;
        _0xafad5dca = _0xda4d8b70 - this._0x2f1acd04 / 2;
        _0xa456ebcf = _0xda4d8b70 + this._0x2f1acd04 / 2;
        _0x6c9ba8b7 = _0xaf93a3aa + this._0x59c26483 / 2;
        _0xb022910a = _0xaf93a3aa - this._0x59c26483 / 2;
        this._0xa80ce242 = new Vector3(_0xafad5dca, _0xb022910a, 0);
        this._0x09d2b256 = new Vector3(_0xda4d8b70, _0xb022910a, 0);
        this._0x34d465a8 = new Vector3(_0xa456ebcf, _0xb022910a, 0);
        this._0xc7bc0841 = new Vector3(_0xafad5dca, _0xaf93a3aa, 0);
        this._0xe6693229 = new Vector3(_0xda4d8b70, _0xaf93a3aa, 0);
        this._0x594c973e = new Vector3(_0xa456ebcf, _0xaf93a3aa, 0);
        this._0xd08cfe6f = new Vector3(_0xafad5dca, _0x6c9ba8b7, 0);
        this._0x829f11b1 = new Vector3(_0xda4d8b70, _0x6c9ba8b7, 0);
        this._0xf6fd66eb = new Vector3(_0xa456ebcf, _0x6c9ba8b7, 0);
    }

    private Vector3 _0xe6693229 { get; set; }
    private Vector3 _0x09d2b256 { get; set; }

    private float _0xed792a05 = 1;
    private new Camera _0x75d2fafc;
    private void Awake()
    {
        this._0x75d2fafc = this.GetComponent<Camera>();
        _0x189bc52d = this;
        this._0xc43b3583();
    }

    private Vector3 _0x594c973e { get; set; }
}