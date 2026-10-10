using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0xbd87a78f : MonoBehaviour
{
    private bool _0x22fbc21c = false;
    private string _0x6c0f2beb = "";
    private string _0x1b5664f0 = "";
    private void _0xd004ac0f(string _0xdb64799f)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x17dc8940._0x3fe00c49(new byte[34] { 238, 225, 208, 198, 193, 232, 149, 243, 208, 193, 214, 221, 149, 240, 205, 193, 199, 212, 149, 229, 192, 198, 221, 149, 241, 212, 193, 212, 149, 231, 212, 194, 143, 149 }, 181) + _0xdb64799f);
#endif
            }
        }

        var _0x095323a3 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xdb64799f);
        StartCoroutine(_0x24df196d(_0x095323a3));
    }

    internal bool ContainsIgnoreCase(string _0x01c14c57, string _0xd9b5ebf1)
    {
        if (string.IsNullOrEmpty(_0x01c14c57) || string.IsNullOrEmpty(_0xd9b5ebf1))
            return false;
        return _0x01c14c57.IndexOf(_0xd9b5ebf1, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private void _0x6d65c73b()
    {
        if (_0x3c6938f5 != null)
            return;
        var _0xb3b5b98a = _0xa3d41345();
        _0x3c6938f5 = new GameObject(_0x17dc8940._0x3fe00c49(new byte[14] { 255, 205, 202, 254, 193, 205, 223, 251, 216, 193, 198, 198, 205, 218 }, 168), typeof(RectTransform), typeof(Text));
        _0x7c830429 = _0x3c6938f5.GetComponent<RectTransform>();
        _0x7c830429.SetParent(_0xb3b5b98a.transform, false);
        _0x7c830429.anchorMin = new Vector2(0.5f, 0.5f);
        _0x7c830429.anchorMax = new Vector2(0.5f, 0.5f);
        _0x7c830429.pivot = new Vector2(0.5f, 0.5f);
        _0x7c830429.sizeDelta = new Vector2(600f, 600f);
        _0x7c830429.anchoredPosition = Vector2.zero;
        _0xb637470a = _0x3c6938f5.GetComponent<Text>();
        _0xb637470a.text = _0x17dc8940._0x3fe00c49(new byte[1] { 156 }, 179);
        _0xb637470a.font = Resources.GetBuiltinResource<Font>(_0x17dc8940._0x3fe00c49(new byte[17] { 66, 107, 105, 111, 109, 119, 92, 123, 96, 122, 103, 99, 107, 32, 122, 122, 104 }, 14));
        _0xb637470a.fontSize = 200;
        _0xb637470a.alignment = TextAnchor.MiddleCenter;
        _0xb637470a.color = Color.white;
        _0xb637470a.raycastTarget = false;
        _0x3c6938f5.SetActive(false);
    }

    private JObject _0x62bd6d4b(params string[] _0x7e1c9dea)
    {
        JObject _0x5a7b3627 = new JObject();
        foreach (var _0x423ac05e in _0x7e1c9dea)
        {
            string _0x0b4cbead = _0x4f7be0ff();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x0b4cbead} val={_0x423ac05e}");
#endif
            }

            _0x5a7b3627.Add(_0x0b4cbead, _0x423ac05e == null ? "" : _0x423ac05e);
        }

        return _0x5a7b3627;
    }

    private float _0x6f0216df = 0f;
    private async Task<string> _0x83ba6443(int _0x293778d3 = 5, int _0xd056094d = 500)
    {
        try
        {
            List<EntityData> _0xc7fdca63 = new List<EntityData>();
            int _0xa48c26bd = 0;
            do
            {
                _0xc7fdca63 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x17dc8940._0x3fe00c49(new byte[8] { 248, 228, 233, 241, 237, 250, 193, 236 }, 136), _0x09689c98, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x09689c98 }), new QueryOptions())).ToList();
                await Task.Delay(_0xd056094d);
            }
            while (_0xc7fdca63.Count == 0 && _0xa48c26bd++ < _0x293778d3);
            {
#if B_LOGS
                {
                    Debug.Log(_0x17dc8940._0x3fe00c49(new byte[33] { 95, 80, 97, 119, 112, 89, 36, 87, 101, 114, 97, 96, 36, 72, 109, 106, 111, 36, 85, 113, 97, 118, 125, 36, 118, 97, 119, 113, 104, 112, 119, 62, 36 }, 4) + JsonConvert.SerializeObject(_0xc7fdca63, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x17dc8940._0x3fe00c49(new byte[39] { 148, 155, 170, 188, 187, 146, 239, 156, 174, 185, 170, 171, 239, 131, 166, 161, 164, 239, 158, 186, 170, 189, 182, 239, 189, 170, 188, 186, 163, 187, 188, 239, 172, 160, 186, 161, 187, 245, 239 }, 207) + _0xc7fdca63.Count);
                }
#endif
            }

            var _0x212dab17 = _0xc7fdca63.SelectMany(_0x30b0f0c8 => _0x30b0f0c8.Data).FirstOrDefault(_0x8788df11 => _0x8788df11.Key == _0x09689c98)?.Value.GetAs<string>() ?? string.Empty;
            _0x212dab17 = Decrypt(_0x212dab17, _0x09689c98);
            {
#if B_LOGS
                {
                    Debug.Log(_0x17dc8940._0x3fe00c49(new byte[24] { 115, 124, 77, 91, 92, 117, 8, 100, 71, 73, 76, 8, 91, 73, 94, 77, 76, 8, 68, 65, 70, 67, 18, 8 }, 40) + _0x212dab17);
                }
#endif
            }

            return _0x212dab17;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x17dc8940._0x3fe00c49(new byte[39] { 249, 246, 199, 209, 214, 255, 130, 229, 199, 214, 130, 205, 208, 130, 210, 195, 208, 209, 199, 130, 209, 195, 212, 199, 198, 130, 206, 203, 204, 201, 130, 196, 195, 203, 206, 199, 198, 152, 130 }, 162) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private bool _0xe2c63157 = false;
    private async Task _0xa0aa2c2d()
    {
        if (await _0x37364526())
            return;
        if (await _0x5e1ffe1d())
            return;
        if (await _0xe97cacb1())
            return;
        _0x9cbbe39f();
        await _0x9f719cfd(_0x924497c6());
        _0xbf9463a7 = await _0xcf33aa56();
        await _0xd6a7d778();
    }

    private bool _0xb65da46b = false;
    private AndroidJavaObject _0x6cecd75a { get; set; }

    private readonly List<UniWebViewPopup> _0xfbf86806 = new List<UniWebViewPopup>();
    public void _0xd88aa1c9()
    {
        if (_0xd1cbb3db)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x17dc8940._0x3fe00c49(new byte[33] { 171, 164, 149, 131, 132, 173, 208, 164, 153, 157, 149, 130, 208, 159, 133, 132, 208, 221, 206, 208, 157, 159, 134, 149, 208, 132, 159, 208, 131, 147, 149, 158, 149 }, 240));
            }
#endif
        }

        _0x57af6bc3();
    }

    private string _0xc4c119be = "";
    internal void _0x5fd33bef()
    {
        Rect _0x86abc12a = Screen.safeArea;
        Vector2 _0xce1d0ac4 = new Vector2(Screen.width, Screen.height);
        if (_0x86abc12a == lastSafe && _0xce1d0ac4 == lastSize)
            return;
        // Apply manual padding
        _0x86abc12a.xMin += _0x98dfedd8;
        _0x86abc12a.xMax -= _0x26f82651;
        _0x86abc12a.yMin += _0x8edc16f9;
        _0x86abc12a.yMax -= _0x86077119;
        // Convert Unity safe area -> native WebView frame
        Rect _0x0e334c5f = new Rect(_0x86abc12a.x, _0xce1d0ac4.y - _0x86abc12a.y - _0x86abc12a.height, // Y flip for native coordinate system
 _0x86abc12a.width, _0x86abc12a.height);
        _0x3b4eca97.Frame = _0x0e334c5f;
        lastSafe = Screen.safeArea;
        lastSize = _0xce1d0ac4;
    }

    private string _0xbf9463a7 = "";
    private string _0x9d5b3ee4()
    {
        if (string.IsNullOrEmpty(_0x17bd0834) && _0x3b4eca97 != null)
            _0x17bd0834 = _0x3b4eca97.GetUserAgent();
        if (string.IsNullOrEmpty(_0x17bd0834))
            return string.Empty;
        string _0xc92bff2f = Regex.Replace(_0x17bd0834, _0x17dc8940._0x3fe00c49(new byte[11] { 244, 219, 130, 147, 244, 219, 130, 223, 222, 244, 202 }, 168), string.Empty);
        _0xc92bff2f = Regex.Replace(_0xc92bff2f, _0x17dc8940._0x3fe00c49(new byte[15] { 51, 28, 68, 45, 26, 6, 3, 11, 64, 52, 49, 84, 70, 50, 68 }, 111), string.Empty);
        _0xc92bff2f = Regex.Replace(_0xc92bff2f, _0x17dc8940._0x3fe00c49(new byte[15] { 186, 137, 158, 159, 133, 131, 130, 195, 216, 176, 194, 220, 176, 159, 198 }, 236), string.Empty);
        return Regex.Replace(_0xc92bff2f, _0x17dc8940._0x3fe00c49(new byte[6] { 154, 181, 189, 244, 234, 187 }, 198), _0x17dc8940._0x3fe00c49(new byte[1] { 203 }, 235)).Trim();
    }

    private void _0x43354825(string _0x6dba9a42)
    {
        if (string.IsNullOrEmpty(_0x6dba9a42))
            return;
        if (TryOpenExternalLikeChrome(_0x6dba9a42))
            return;
        OpenUrlExternally(_0x6dba9a42);
    }

    private string _0x19e58c9c(string _0xaabadf61, string _0xd3a9ce12)
    {
        if (string.IsNullOrEmpty(_0xd3a9ce12))
            return _0xaabadf61;
        if (_0xaabadf61.Contains(_0x17dc8940._0x3fe00c49(new byte[1] { 2 }, 61)))
            return _0xaabadf61 + _0x17dc8940._0x3fe00c49(new byte[8] { 24, 77, 91, 80, 90, 87, 90, 3 }, 62) + UnityWebRequest.EscapeURL(_0xd3a9ce12);
        else
            return _0xaabadf61 + _0x17dc8940._0x3fe00c49(new byte[8] { 18, 94, 72, 67, 73, 68, 73, 16 }, 45) + UnityWebRequest.EscapeURL(_0xd3a9ce12);
    }

    private void _0x260890d7()
    {
        WLog(_0x17dc8940._0x3fe00c49(new byte[21] { 145, 184, 171, 189, 174, 184, 171, 188, 249, 187, 184, 186, 178, 249, 169, 171, 188, 170, 170, 188, 189 }, 217));
        if (Time.frameCount == _0x06b5d64e)
            return;
        _0x06b5d64e = Time.frameCount;
        if (_0x83a1b7ba())
            return;
        _0xd069d43d();
    }

    private void _0x1dea5538(string _0xa73ad9e0)
    {
        Dictionary<string, object> _0xb3a1ec13;
        try
        {
            _0xb3a1ec13 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xa73ad9e0);
        }
        catch
        {
            return;
        }

        var _0x602ed23e = ReadPushField(_0xb3a1ec13, _0x17dc8940._0x3fe00c49(new byte[3] { 4, 3, 29 }, 113));
        if (string.IsNullOrWhiteSpace(_0x602ed23e))
            return;
        _0x602ed23e = _0x602ed23e.Trim();
        if (!IsHttpUrl(_0x602ed23e))
            return;
        if (string.Equals(_0x602ed23e, _0xadb376dc, StringComparison.Ordinal))
            return;
        _0xadb376dc = _0x602ed23e;
        OpenUrlExternally(_0x602ed23e);
    }

    private IEnumerator _0x924497c6()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x17dc8940._0x3fe00c49(new byte[26] { 119, 120, 73, 95, 88, 113, 12, 101, 66, 69, 88, 69, 77, 64, 69, 86, 73, 126, 73, 74, 74, 73, 94, 73, 94, 12 }, 44));
            }
#endif
        }

        bool _0x3e6b9c19 = false;
        InstallReferrer.GetReferrer((_0xb6af8a8c) =>
        {
            Debug.Log(_0x17dc8940._0x3fe00c49(new byte[24] { 76, 67, 114, 100, 99, 55, 69, 114, 113, 114, 101, 101, 114, 101, 74, 55, 112, 114, 99, 55, 245, 145, 133, 55 }, 23) + _0x54c08599);
            if (_0xb6af8a8c.IsSuccess)
            {
                _0x54c08599 = _0xb6af8a8c.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x17dc8940._0x3fe00c49(new byte[28] { 222, 209, 224, 246, 241, 165, 215, 224, 227, 224, 247, 247, 224, 247, 216, 165, 214, 240, 230, 230, 224, 246, 246, 165, 103, 3, 23, 165 }, 133) + _0x54c08599);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x17dc8940._0x3fe00c49(new byte[27] { 1, 14, 63, 41, 46, 122, 8, 63, 60, 63, 40, 40, 63, 40, 7, 122, 28, 59, 51, 54, 63, 62, 122, 184, 220, 200, 122 }, 90) + _0xb6af8a8c);
#endif
                }

                _0x54c08599 = "";
            }

            _0x3b8d2586 = true;
        });
        StartCoroutine(_0x52923465(2f));
        yield return new WaitUntil(() => _0x3b8d2586);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x54c08599}");
#endif
        }

        bool _0x04e69176 = _0x54c08599.Contains(_0x17dc8940._0x3fe00c49(new byte[6] { 135, 131, 140, 137, 132, 221 }, 224));
        _0x3e6b9c19 = _0x04e69176 || _0x54c08599.Contains(_0x17dc8940._0x3fe00c49(new byte[18] { 195, 210, 210, 209, 140, 203, 204, 209, 214, 195, 197, 208, 195, 207, 140, 193, 205, 207 }, 162)) || _0x54c08599.Contains(_0x17dc8940._0x3fe00c49(new byte[17] { 184, 169, 169, 170, 247, 191, 184, 186, 188, 187, 182, 182, 178, 247, 186, 182, 180 }, 217));
        _0xf7a63d2e = _0x04e69176 ? "" : (_0x3e6b9c19 ? "" : _0xf7a63d2e);
        _0xf7a63d2e = _0xf7a63d2e ?? "";
        _0x55e88141 = _0x55e88141 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0xf7a63d2e}");
#endif
        }
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0xd7ce878c)
    {
        if (_0xd7ce878c == null || _0xd7ce878c.Extra == null)
            return null;
        object _0x4b696661;
        if (!_0xd7ce878c.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x4b696661))
            return null;
        return _0x4b696661 as string;
    }

    private string _0x058f8a8d = "";
    private bool _0xa3cd5859()
    {
        _0xfbf86806.RemoveAll(_0x8c978792 => _0x8c978792 == null || !_0x8c978792.IsAlive);
        return _0xfbf86806.Count > 0;
    }

    // PART 3
    private string _0x638ece1d()
    {
        try
        {
            var _0x606540a9 = new AndroidJavaClass(_0x17dc8940._0x3fe00c49(new byte[30] { 23, 27, 25, 90, 1, 26, 29, 0, 13, 71, 16, 90, 4, 24, 21, 13, 17, 6, 90, 33, 26, 29, 0, 13, 36, 24, 21, 13, 17, 6 }, 116));
            var _0x267e6b60 = _0x606540a9.GetStatic<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[15] { 2, 20, 19, 19, 4, 15, 21, 32, 2, 21, 8, 23, 8, 21, 24 }, 97));
            var _0x0acf0ee7 = new AndroidJavaClass(_0x17dc8940._0x3fe00c49(new byte[57] { 173, 161, 163, 224, 169, 161, 161, 169, 162, 171, 224, 175, 160, 170, 188, 161, 167, 170, 224, 169, 163, 189, 224, 175, 170, 189, 224, 167, 170, 171, 160, 186, 167, 168, 167, 171, 188, 224, 143, 170, 184, 171, 188, 186, 167, 189, 167, 160, 169, 135, 170, 141, 162, 167, 171, 160, 186 }, 206));
            var _0x77de7b8e = _0x0acf0ee7.CallStatic<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[20] { 90, 88, 73, 124, 89, 75, 88, 79, 73, 84, 78, 84, 83, 90, 116, 89, 116, 83, 91, 82 }, 61), _0x267e6b60);
            var _0x89b2e506 = _0x77de7b8e.Call<string>(_0x17dc8940._0x3fe00c49(new byte[5] { 68, 70, 87, 106, 71 }, 35));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x89b2e506}");
#endif
            }

            return string.IsNullOrEmpty(_0x89b2e506) ? "" : _0x89b2e506;
        }
        catch
        {
            return "";
        }
    }

    private string _0xf6236ba3;
    private string _0x4f7be0ff()
    {
        string _0x4276adb1 = _0x17dc8940._0x3fe00c49(new byte[62] { 223, 220, 221, 218, 219, 216, 217, 214, 215, 212, 213, 210, 211, 208, 209, 206, 207, 204, 205, 202, 203, 200, 201, 198, 199, 196, 255, 252, 253, 250, 251, 248, 249, 246, 247, 244, 245, 242, 243, 240, 241, 238, 239, 236, 237, 234, 235, 232, 233, 230, 231, 228, 142, 143, 140, 141, 138, 139, 136, 137, 134, 135 }, 190);
        System.Random _0x69ea523b = new System.Random();
        int _0x8cce38f8 = _0x69ea523b.Next(8, 16);
        return new string (Enumerable.Repeat(_0x4276adb1, _0x8cce38f8).Select(_0x234899f8 => _0x234899f8[_0x69ea523b.Next(_0x234899f8.Length)]).ToArray());
    }

    private bool _0xfc06d0f7(int _0xb5882c30, string _0xd10358c3, string _0x1d5b8d63)
    {
        if (string.IsNullOrEmpty(_0x1d5b8d63))
            return false;
        if (!IsHttpUrl(_0x1d5b8d63))
            return true;
        if (string.IsNullOrEmpty(_0xd10358c3))
            return false;
        return _0xd10358c3.IndexOf(_0x17dc8940._0x3fe00c49(new byte[20] { 71, 80, 80, 93, 65, 77, 76, 76, 71, 65, 86, 75, 77, 76, 93, 80, 71, 81, 71, 86 }, 2), StringComparison.OrdinalIgnoreCase) >= 0 || _0xd10358c3.IndexOf(_0x17dc8940._0x3fe00c49(new byte[22] { 239, 248, 248, 245, 233, 229, 228, 228, 239, 233, 254, 227, 229, 228, 245, 248, 239, 236, 255, 249, 239, 238 }, 170), StringComparison.OrdinalIgnoreCase) >= 0 || _0xd10358c3.IndexOf(_0x17dc8940._0x3fe00c49(new byte[21] { 55, 32, 32, 45, 49, 61, 60, 60, 55, 49, 38, 59, 61, 60, 45, 49, 62, 61, 33, 55, 54 }, 114), StringComparison.OrdinalIgnoreCase) >= 0 || _0xd10358c3.IndexOf(_0x17dc8940._0x3fe00c49(new byte[22] { 182, 161, 161, 172, 166, 189, 184, 189, 188, 164, 189, 172, 166, 161, 191, 172, 160, 176, 187, 182, 190, 182 }, 243), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private bool _0x83a1b7ba()
    {
        if (_0x87d97cdf())
            return true;
        if (_0x3b4eca97 != null && _0x3b4eca97.CanGoBack)
        {
            WLog(_0x17dc8940._0x3fe00c49(new byte[36] { 96, 73, 90, 76, 95, 73, 90, 77, 8, 74, 73, 75, 67, 8, 5, 22, 8, 69, 73, 65, 70, 8, 127, 77, 74, 126, 65, 77, 95, 8, 111, 71, 106, 73, 75, 67 }, 40));
            _0x3b4eca97.GoBack();
            return true;
        }

        return false;
    }

    private async Task<bool> _0xe97cacb1()
    {
        {
#if B_LOGS
            Debug.Log(_0x17dc8940._0x3fe00c49(new byte[29] { 196, 203, 250, 236, 235, 194, 191, 214, 236, 207, 237, 246, 233, 254, 252, 230, 222, 241, 251, 204, 254, 233, 250, 251, 220, 247, 250, 252, 244 }, 159));
#endif
        }

        string _0xf0d910ea = "";
        for (int _0xf25690e3 = 0; _0xf25690e3 < 2; _0xf25690e3++)
        {
            if (await _0x4bbfb0b8(1, 100))
            {
                await _0x16e7042d(_0x17dc8940._0x3fe00c49(new byte[7] { 19, 29, 30, 18, 26, 20, 21 }, 113));
                _0x57af6bc3();
                return true;
            }

            _0xf0d910ea = await _0x83ba6443(1, 100);
            if (!string.IsNullOrEmpty(_0xf0d910ea))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xf0d910ea))
            {
                if (!string.IsNullOrEmpty(_0xf6236ba3))
                {
                    _0xf0d910ea = _0x19e58c9c(_0xf0d910ea, _0xf6236ba3);
                    {
#if B_LOGS
                        Debug.Log(_0x17dc8940._0x3fe00c49(new byte[53] { 80, 95, 110, 120, 127, 86, 43, 72, 106, 104, 99, 110, 111, 43, 109, 98, 101, 106, 103, 94, 121, 103, 43, 124, 98, 127, 99, 43, 120, 110, 101, 111, 98, 111, 43, 233, 141, 153, 43, 120, 99, 100, 124, 43, 92, 110, 105, 93, 98, 110, 124, 49, 43 }, 11) + _0xf0d910ea);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x17dc8940._0x3fe00c49(new byte[39] { 69, 74, 123, 109, 106, 67, 62, 93, 127, 125, 118, 123, 122, 62, 120, 119, 112, 127, 114, 75, 108, 114, 62, 252, 152, 140, 62, 109, 118, 113, 105, 62, 73, 123, 124, 72, 119, 123, 105 }, 30));
#endif
                    }
                }

                _0x9419421a = true;
                _0xdaf5b428(_0xf0d910ea);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x17dc8940._0x3fe00c49(new byte[44] { 222, 209, 224, 246, 241, 216, 165, 192, 253, 230, 224, 245, 241, 236, 234, 235, 165, 242, 237, 236, 233, 224, 165, 230, 237, 224, 230, 238, 236, 235, 226, 165, 246, 228, 243, 224, 225, 165, 233, 236, 235, 238, 191, 165 }, 133) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private bool _0x164ea5ca = false;
    // NATIVE WEB VIEW METHODS
    private UniWebView _0x3b4eca97 = null;
    private string _0xf6183f1e()
    {
        string _0x9e9d721a = _0x9d5b3ee4();
        if (string.IsNullOrEmpty(_0x9e9d721a))
            return _0x17dc8940._0x3fe00c49(new byte[7] { 130, 155, 157, 144, 212, 196, 207 }, 244);
        string _0x5e400dbc = _0x9e9d721a.Replace(_0x17dc8940._0x3fe00c49(new byte[1] { 13 }, 81), _0x17dc8940._0x3fe00c49(new byte[2] { 104, 104 }, 52)).Replace(_0x17dc8940._0x3fe00c49(new byte[1] { 93 }, 122), _0x17dc8940._0x3fe00c49(new byte[2] { 147, 232 }, 207));
        var _0xea75dd61 = Regex.Match(_0x9e9d721a, _0x17dc8940._0x3fe00c49(new byte[12] { 46, 5, 31, 2, 0, 8, 66, 69, 49, 9, 70, 68 }, 109));
        string _0xdcbf0e19 = _0xea75dd61.Success ? _0xea75dd61.Groups[1].Value : _0x17dc8940._0x3fe00c49(new byte[3] { 51, 48, 50 }, 2);
        return _0x17dc8940._0x3fe00c49(new byte[12] { 2, 76, 95, 68, 73, 94, 67, 69, 68, 2, 3, 81 }, 42) + _0x17dc8940._0x3fe00c49(new byte[8] { 55, 32, 51, 97, 52, 32, 124, 102 }, 65) + _0x5e400dbc + _0x17dc8940._0x3fe00c49(new byte[2] { 107, 119 }, 76) + _0x17dc8940._0x3fe00c49(new byte[30] { 70, 81, 66, 16, 64, 66, 95, 68, 95, 13, 126, 81, 70, 89, 87, 81, 68, 95, 66, 30, 64, 66, 95, 68, 95, 68, 73, 64, 85, 11 }, 48) + _0x17dc8940._0x3fe00c49(new byte[121] { 160, 179, 168, 165, 178, 175, 169, 168, 230, 162, 163, 160, 238, 169, 164, 172, 234, 173, 163, 191, 234, 176, 167, 170, 239, 189, 178, 180, 191, 189, 137, 164, 172, 163, 165, 178, 232, 162, 163, 160, 175, 168, 163, 150, 180, 169, 182, 163, 180, 178, 191, 238, 169, 164, 172, 234, 173, 163, 191, 234, 189, 161, 163, 178, 252, 160, 179, 168, 165, 178, 175, 169, 168, 238, 239, 189, 180, 163, 178, 179, 180, 168, 230, 176, 167, 170, 253, 187, 234, 165, 169, 168, 160, 175, 161, 179, 180, 167, 164, 170, 163, 252, 178, 180, 179, 163, 187, 239, 253, 187, 165, 167, 178, 165, 174, 238, 163, 239, 189, 187, 187 }, 198) + _0x17dc8940._0x3fe00c49(new byte[26] { 250, 251, 248, 182, 238, 236, 241, 234, 241, 178, 185, 235, 237, 251, 236, 223, 249, 251, 240, 234, 185, 178, 235, 255, 183, 165 }, 158) + _0x17dc8940._0x3fe00c49(new byte[52] { 64, 65, 66, 12, 84, 86, 75, 80, 75, 8, 3, 69, 84, 84, 114, 65, 86, 87, 77, 75, 74, 3, 8, 81, 69, 10, 86, 65, 84, 72, 69, 71, 65, 12, 11, 122, 105, 75, 94, 77, 72, 72, 69, 120, 11, 11, 8, 3, 3, 13, 13, 31 }, 36) + _0x17dc8940._0x3fe00c49(new byte[37] { 62, 63, 60, 114, 42, 40, 53, 46, 53, 118, 125, 42, 54, 59, 46, 60, 53, 40, 55, 125, 118, 125, 22, 51, 52, 47, 34, 122, 59, 40, 55, 44, 98, 54, 125, 115, 97 }, 90) + _0x17dc8940._0x3fe00c49(new byte[34] { 73, 72, 75, 5, 93, 95, 66, 89, 66, 1, 10, 91, 72, 67, 73, 66, 95, 10, 1, 10, 106, 66, 66, 74, 65, 72, 13, 100, 67, 78, 3, 10, 4, 22 }, 45) + _0x17dc8940._0x3fe00c49(new byte[30] { 128, 129, 130, 204, 148, 150, 139, 144, 139, 200, 195, 137, 133, 156, 176, 139, 145, 135, 140, 180, 139, 141, 138, 144, 151, 195, 200, 209, 205, 223 }, 228) + _0x17dc8940._0x3fe00c49(new byte[48] { 93, 91, 80, 82, 95, 72, 91, 9, 92, 72, 77, 20, 82, 75, 91, 72, 71, 77, 90, 19, 114, 82, 75, 91, 72, 71, 77, 19, 14, 106, 65, 91, 70, 68, 64, 92, 68, 14, 5, 95, 76, 91, 90, 64, 70, 71, 19, 14 }, 41) + _0xdcbf0e19 + _0x17dc8940._0x3fe00c49(new byte[35] { 123, 33, 112, 39, 62, 46, 61, 50, 56, 102, 123, 27, 51, 51, 59, 48, 57, 124, 31, 52, 46, 51, 49, 57, 123, 112, 42, 57, 46, 47, 53, 51, 50, 102, 123 }, 92) + _0xdcbf0e19 + _0x17dc8940._0x3fe00c49(new byte[238] { 225, 187, 234, 189, 164, 180, 167, 168, 162, 252, 225, 136, 169, 178, 251, 135, 249, 132, 180, 167, 168, 162, 225, 234, 176, 163, 180, 181, 175, 169, 168, 252, 225, 244, 242, 225, 187, 155, 234, 171, 169, 164, 175, 170, 163, 252, 178, 180, 179, 163, 234, 182, 170, 167, 178, 160, 169, 180, 171, 252, 225, 135, 168, 162, 180, 169, 175, 162, 225, 234, 161, 163, 178, 142, 175, 161, 174, 131, 168, 178, 180, 169, 182, 191, 144, 167, 170, 179, 163, 181, 252, 160, 179, 168, 165, 178, 175, 169, 168, 238, 239, 189, 180, 163, 178, 179, 180, 168, 230, 150, 180, 169, 171, 175, 181, 163, 232, 180, 163, 181, 169, 170, 176, 163, 238, 189, 167, 180, 165, 174, 175, 178, 163, 165, 178, 179, 180, 163, 252, 225, 167, 180, 171, 225, 234, 164, 175, 178, 168, 163, 181, 181, 252, 225, 240, 242, 225, 234, 171, 169, 164, 175, 170, 163, 252, 178, 180, 179, 163, 234, 171, 169, 162, 163, 170, 252, 225, 225, 234, 182, 170, 167, 178, 160, 169, 180, 171, 252, 225, 135, 168, 162, 180, 169, 175, 162, 225, 234, 182, 170, 167, 178, 160, 169, 180, 171, 144, 163, 180, 181, 175, 169, 168, 252, 225, 247, 242, 232, 246, 232, 246, 225, 234, 179, 167, 128, 179, 170, 170, 144, 163, 180, 181, 175, 169, 168, 252, 225 }, 198) + _0xdcbf0e19 + _0x17dc8940._0x3fe00c49(new byte[117] { 252, 226, 252, 226, 252, 226, 245, 175, 251, 233, 175, 175, 233, 157, 176, 184, 183, 177, 166, 252, 182, 183, 180, 187, 188, 183, 130, 160, 189, 162, 183, 160, 166, 171, 250, 162, 160, 189, 166, 189, 254, 245, 167, 161, 183, 160, 147, 181, 183, 188, 166, 150, 179, 166, 179, 245, 254, 169, 181, 183, 166, 232, 180, 167, 188, 177, 166, 187, 189, 188, 250, 251, 169, 160, 183, 166, 167, 160, 188, 242, 167, 179, 182, 233, 175, 254, 177, 189, 188, 180, 187, 181, 167, 160, 179, 176, 190, 183, 232, 166, 160, 167, 183, 175, 251, 233, 175, 177, 179, 166, 177, 186, 250, 183, 251, 169, 175 }, 210) + _0x17dc8940._0x3fe00c49(new byte[5] { 206, 154, 155, 154, 136 }, 179);
    }

    internal bool _0x7f5ab1dd(string _0x23401439)
    {
        return _0x23401439.StartsWith(_0x17dc8940._0x3fe00c49(new byte[9] { 232, 228, 247, 238, 224, 241, 191, 170, 170 }, 133), StringComparison.OrdinalIgnoreCase) || _0x23401439.StartsWith(_0x17dc8940._0x3fe00c49(new byte[24] { 199, 219, 219, 223, 220, 149, 128, 128, 223, 195, 206, 214, 129, 200, 192, 192, 200, 195, 202, 129, 204, 192, 194, 128 }, 175), StringComparison.OrdinalIgnoreCase) || _0x23401439.StartsWith(_0x17dc8940._0x3fe00c49(new byte[23] { 130, 158, 158, 154, 208, 197, 197, 154, 134, 139, 147, 196, 141, 133, 133, 141, 134, 143, 196, 137, 133, 135, 197 }, 234), StringComparison.OrdinalIgnoreCase);
    }

    private string _0xf7a63d2e { get; set; }

    private GameObject _0x3c6938f5;
    // WEB VIEW LOGIC
    public bool _0xd1cbb3db { get; set; }

    private void _0xf7a53bf4()
    {
        _0x164ea5ca = true;
        if (_0x3b4eca97 != null)
            _0x3b4eca97.SetUserAgent(_0x9d5b3ee4());
    }

    private string _0x14ad41c4()
    {
        try
        {
            using (var _0x617cac72 = new AndroidJavaClass(_0x17dc8940._0x3fe00c49(new byte[30] { 127, 115, 113, 50, 105, 114, 117, 104, 101, 47, 120, 50, 108, 112, 125, 101, 121, 110, 50, 73, 114, 117, 104, 101, 76, 112, 125, 101, 121, 110 }, 28)))
            {
                var _0xc987c7c1 = _0x617cac72.GetStatic<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[15] { 26, 12, 11, 11, 28, 23, 13, 56, 26, 13, 16, 15, 16, 13, 0 }, 121));
                var _0x83f6aee4 = _0xc987c7c1.Call<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[21] { 47, 45, 60, 9, 56, 56, 36, 33, 43, 41, 60, 33, 39, 38, 11, 39, 38, 60, 45, 48, 60 }, 72));
                using (var _0x3f86e9cf = new AndroidJavaClass(_0x17dc8940._0x3fe00c49(new byte[26] { 118, 121, 115, 101, 120, 126, 115, 57, 96, 114, 117, 124, 126, 99, 57, 64, 114, 117, 68, 114, 99, 99, 126, 121, 112, 100 }, 23)))
                {
                    return _0x3f86e9cf.CallStatic<string>(_0x17dc8940._0x3fe00c49(new byte[19] { 235, 233, 248, 200, 233, 234, 237, 249, 224, 248, 217, 255, 233, 254, 205, 235, 233, 226, 248 }, 140), _0x83f6aee4);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private Text _0xb637470a;
    internal bool isDestroyedForce = false;
    private async Task<bool> _0x4bbfb0b8(int _0x0c907468 = 5, int _0xa7423ad8 = 500)
    {
        List<EntityData> _0x42ed3f7c = new List<EntityData>();
        int _0x0a08bc85 = 0;
        do
        {
            try
            {
                _0x42ed3f7c = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x17dc8940._0x3fe00c49(new byte[8] { 24, 4, 9, 17, 13, 26, 33, 12 }, 104), _0x09689c98, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x17dc8940._0x3fe00c49(new byte[9] { 14, 20, 55, 21, 14, 17, 6, 4, 30 }, 103) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x17dc8940._0x3fe00c49(new byte[32] { 85, 90, 107, 125, 122, 83, 46, 127, 123, 107, 124, 119, 79, 125, 119, 96, 109, 92, 107, 125, 123, 98, 122, 125, 46, 107, 124, 124, 97, 124, 52, 46 }, 14) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xa7423ad8);
        }
        while (_0x42ed3f7c.Count == 0 && _0x0a08bc85++ < _0x0c907468);
        {
#if B_LOGS
            {
                Debug.Log(_0x17dc8940._0x3fe00c49(new byte[32] { 202, 197, 244, 226, 229, 204, 177, 216, 226, 193, 227, 248, 231, 240, 242, 232, 177, 192, 228, 244, 227, 232, 177, 227, 244, 226, 228, 253, 229, 226, 171, 177 }, 145) + JsonConvert.SerializeObject(_0x42ed3f7c, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x17dc8940._0x3fe00c49(new byte[38] { 203, 196, 245, 227, 228, 205, 176, 217, 227, 192, 226, 249, 230, 241, 243, 233, 176, 193, 229, 245, 226, 233, 176, 226, 245, 227, 229, 252, 228, 227, 176, 243, 255, 229, 254, 228, 170, 176 }, 144) + _0x42ed3f7c.Count);
            }
#endif
        }

        bool _0x4b85b2d6 = true;
        if (_0x42ed3f7c.Count == 0)
        {
            _0x4b85b2d6 = false;
        }
        else
        {
            _0x4b85b2d6 = _0x42ed3f7c.Any(_0x30b0f0c8 => _0x30b0f0c8.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x17dc8940._0x3fe00c49(new byte[25] { 82, 93, 108, 122, 125, 84, 41, 64, 122, 89, 123, 96, 127, 104, 106, 112, 41, 123, 108, 122, 124, 101, 125, 51, 41 }, 9) + _0x4b85b2d6);
            }
#endif
        }

        return _0x4b85b2d6;
    }

    private async Task _0x16e7042d(string _0xf3f51903)
    {
        if (_0xb65da46b || string.IsNullOrEmpty(_0x09689c98) || string.IsNullOrEmpty(_0xf3f51903) || _0x9419421a)
            return;
        _0xb65da46b = true;
        try
        {
            JObject _0x08a15813 = _0x62bd6d4b(_0xf3f51903, _0x09689c98, _0xe493ae58());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0xf3f51903} payload: {_0x08a15813}");
                }
#endif
            }

            var _0x0a5db236 = _0xd3008ec6(_0x08a15813.ToString(), _0x09689c98);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x17dc8940._0x3fe00c49(new byte[4] { 192, 195, 205, 200 }, 172) + _0x09689c98, _0x0a5db236 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x17dc8940._0x3fe00c49(new byte[24] { 115, 124, 109, 123, 124, 117, 8, 100, 71, 73, 76, 8, 88, 73, 91, 91, 8, 77, 90, 90, 71, 90, 18, 8 }, 40) + e.Message);
#endif
            }
        }
    }

    private bool TryOpenExternalLikeChrome(string _0xe4814b5d)
    {
        if (string.IsNullOrEmpty(_0xe4814b5d))
            return false;
        if (_0xe4814b5d.StartsWith(_0x17dc8940._0x3fe00c49(new byte[9] { 98, 101, 127, 110, 101, 127, 49, 36, 36 }, 11), StringComparison.OrdinalIgnoreCase))
            return _0xa1cc4b21(_0xe4814b5d);
        if (_0x7f5ab1dd(_0xe4814b5d))
            return _0x0d164da4(_0xe4814b5d, null);
        if (!_0xe4814b5d.StartsWith(_0x17dc8940._0x3fe00c49(new byte[7] { 111, 115, 115, 119, 61, 40, 40 }, 7), StringComparison.OrdinalIgnoreCase) && !_0xe4814b5d.StartsWith(_0x17dc8940._0x3fe00c49(new byte[8] { 55, 43, 43, 47, 44, 101, 112, 112 }, 95), StringComparison.OrdinalIgnoreCase) && !_0xe4814b5d.StartsWith(_0x17dc8940._0x3fe00c49(new byte[11] { 196, 199, 202, 208, 209, 159, 199, 201, 196, 203, 206 }, 165), StringComparison.OrdinalIgnoreCase))
        {
            return _0xff01e7c1(_0xe4814b5d);
        }

        return false;
    }

    private void _0x9f77225c(string _0xd7479606)
    {
        bool _0x17831ad3 = !string.IsNullOrEmpty(_0xd7479606);
        if (_0x17831ad3)
        {
            {
#if B_LOGS
                Debug.Log(_0x17dc8940._0x3fe00c49(new byte[13] { 160, 175, 158, 136, 143, 166, 219, 168, 147, 148, 140, 193, 219 }, 251) + _0xd7479606);
#endif
            }

            _0xdaf5b428(_0xd7479606);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x17dc8940._0x3fe00c49(new byte[39] { 141, 130, 179, 165, 162, 139, 246, 144, 183, 186, 186, 180, 183, 181, 189, 246, 52, 80, 68, 246, 145, 183, 187, 179, 246, 254, 184, 185, 246, 176, 191, 184, 183, 186, 246, 131, 132, 154, 255 }, 214));
#endif
            }

            _0x57af6bc3();
            return;
        }
    }

    // MAIN FLOW
    private bool _0x3b8d2586 { get; set; }
    private string _0x55e88141 { get; set; }

    internal bool isApplicationFocus = false;
    private IEnumerator _0xc20d6343(string _0x130acf43)
    {
        if (Permission.HasUserAuthorizedPermission(_0x130acf43))
            yield break;
        bool _0xdc35ebfc = false;
        var _0x62e317cc = new PermissionCallbacks();
        _0x62e317cc.PermissionGranted += _0x1341787a => _0xdc35ebfc = true;
        _0x62e317cc.PermissionDenied += _0x1341787a => _0xdc35ebfc = true;
        Permission.RequestUserPermission(_0x130acf43, _0x62e317cc);
        yield return new WaitUntil(() => _0xdc35ebfc);
    }

    private bool _0x32d49445(string _0x3d394e6b)
    {
        if (string.IsNullOrEmpty(_0x3d394e6b))
            return false;
        try
        {
            using (var _0xa7d0ac94 = new AndroidJavaClass(_0x17dc8940._0x3fe00c49(new byte[30] { 237, 225, 227, 160, 251, 224, 231, 250, 247, 189, 234, 160, 254, 226, 239, 247, 235, 252, 160, 219, 224, 231, 250, 247, 222, 226, 239, 247, 235, 252 }, 142)))
            using (var _0xeff0e2e8 = _0xa7d0ac94.GetStatic<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[15] { 88, 78, 73, 73, 94, 85, 79, 122, 88, 79, 82, 77, 82, 79, 66 }, 59)))
            using (var _0x9489a357 = _0xeff0e2e8.Call<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[17] { 106, 104, 121, 93, 108, 110, 102, 108, 106, 104, 64, 108, 99, 108, 106, 104, 127 }, 13)))
            using (var _0x42dfb5cd = _0x9489a357.Call<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[25] { 40, 42, 59, 3, 46, 58, 33, 44, 39, 6, 33, 59, 42, 33, 59, 9, 32, 61, 31, 46, 44, 36, 46, 40, 42 }, 79), _0x3d394e6b))
            {
                if (_0x42dfb5cd == null)
                    return false;
                WLog(_0x17dc8940._0x3fe00c49(new byte[37] { 217, 242, 232, 245, 247, 255, 214, 243, 241, 255, 186, 246, 251, 239, 244, 249, 242, 186, 243, 244, 233, 238, 251, 246, 246, 255, 254, 186, 234, 251, 249, 241, 251, 253, 255, 160, 186 }, 154) + _0x3d394e6b);
                _0x42dfb5cd.Call<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[8] { 155, 158, 158, 188, 150, 155, 157, 137 }, 250), 0x10000000);
                _0xeff0e2e8.Call(_0x17dc8940._0x3fe00c49(new byte[13] { 202, 205, 216, 203, 205, 248, 218, 205, 208, 207, 208, 205, 192 }, 185), _0x42dfb5cd);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private void _0x67b9b47a()
    {
        if (_0x3b4eca97 == null)
            return;
        if (_0x164ea5ca)
            _0x3b4eca97.SetUserAgent(_0x9d5b3ee4());
        else
            _0x3b4eca97.SetUserAgent("");
    }

    private string _0x395791da = "";
    private static bool IsPrivacyItemTrue(Item _0x8d5c6dc4)
    {
        if (_0x8d5c6dc4.Key != _0x17dc8940._0x3fe00c49(new byte[9] { 33, 59, 24, 58, 33, 62, 41, 43, 49 }, 72))
            return false;
        try
        {
            var _0x6c53c7fa = _0x8d5c6dc4.Value.GetAs<object>();
            return _0x6c53c7fa switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    // WS_SOURCE MONO
    public static _0xbd87a78f _0xba8b03bb { get; private set; }

    private string _0x92ab4f1a()
    {
        return _0x17dc8940._0x3fe00c49(new byte[12] { 134, 200, 219, 192, 205, 218, 199, 193, 192, 134, 135, 213 }, 174) + _0x17dc8940._0x3fe00c49(new byte[8] { 33, 54, 37, 119, 34, 54, 106, 112 }, 87) + WindowsDesktopUserAgent + _0x17dc8940._0x3fe00c49(new byte[2] { 149, 137 }, 178) + _0x17dc8940._0x3fe00c49(new byte[30] { 55, 32, 51, 97, 49, 51, 46, 53, 46, 124, 15, 32, 55, 40, 38, 32, 53, 46, 51, 111, 49, 51, 46, 53, 46, 53, 56, 49, 36, 122 }, 65) + _0x17dc8940._0x3fe00c49(new byte[121] { 172, 191, 164, 169, 190, 163, 165, 164, 234, 174, 175, 172, 226, 165, 168, 160, 230, 161, 175, 179, 230, 188, 171, 166, 227, 177, 190, 184, 179, 177, 133, 168, 160, 175, 169, 190, 228, 174, 175, 172, 163, 164, 175, 154, 184, 165, 186, 175, 184, 190, 179, 226, 165, 168, 160, 230, 161, 175, 179, 230, 177, 173, 175, 190, 240, 172, 191, 164, 169, 190, 163, 165, 164, 226, 227, 177, 184, 175, 190, 191, 184, 164, 234, 188, 171, 166, 241, 183, 230, 169, 165, 164, 172, 163, 173, 191, 184, 171, 168, 166, 175, 240, 190, 184, 191, 175, 183, 227, 241, 183, 169, 171, 190, 169, 162, 226, 175, 227, 177, 183, 183 }, 202) + _0x17dc8940._0x3fe00c49(new byte[26] { 224, 225, 226, 172, 244, 246, 235, 240, 235, 168, 163, 241, 247, 225, 246, 197, 227, 225, 234, 240, 163, 168, 241, 229, 173, 191 }, 132) + _0x17dc8940._0x3fe00c49(new byte[130] { 235, 234, 233, 167, 255, 253, 224, 251, 224, 163, 168, 238, 255, 255, 217, 234, 253, 252, 230, 224, 225, 168, 163, 168, 186, 161, 191, 175, 167, 216, 230, 225, 235, 224, 248, 252, 175, 193, 219, 175, 190, 191, 161, 191, 180, 175, 216, 230, 225, 185, 187, 180, 175, 247, 185, 187, 166, 175, 206, 255, 255, 227, 234, 216, 234, 237, 196, 230, 251, 160, 186, 188, 184, 161, 188, 185, 175, 167, 196, 199, 219, 194, 195, 163, 175, 227, 230, 228, 234, 175, 200, 234, 236, 228, 224, 166, 175, 204, 231, 253, 224, 226, 234, 160, 190, 189, 191, 161, 191, 161, 191, 161, 191, 175, 220, 238, 233, 238, 253, 230, 160, 186, 188, 184, 161, 188, 185, 168, 166, 180 }, 143) + _0x17dc8940._0x3fe00c49(new byte[30] { 215, 214, 213, 155, 195, 193, 220, 199, 220, 159, 148, 195, 223, 210, 199, 213, 220, 193, 222, 148, 159, 148, 228, 218, 221, 128, 129, 148, 154, 136 }, 179) + _0x17dc8940._0x3fe00c49(new byte[34] { 151, 150, 149, 219, 131, 129, 156, 135, 156, 223, 212, 133, 150, 157, 151, 156, 129, 212, 223, 212, 180, 156, 156, 148, 159, 150, 211, 186, 157, 144, 221, 212, 218, 200 }, 243) + _0x17dc8940._0x3fe00c49(new byte[30] { 220, 221, 222, 144, 200, 202, 215, 204, 215, 148, 159, 213, 217, 192, 236, 215, 205, 219, 208, 232, 215, 209, 214, 204, 203, 159, 148, 136, 145, 131 }, 184) + _0x17dc8940._0x3fe00c49(new byte[449] { 103, 97, 106, 104, 101, 114, 97, 51, 102, 114, 119, 46, 104, 113, 97, 114, 125, 119, 96, 41, 72, 104, 113, 97, 114, 125, 119, 41, 52, 80, 123, 97, 124, 126, 122, 102, 126, 52, 63, 101, 118, 97, 96, 122, 124, 125, 41, 52, 34, 33, 35, 52, 110, 63, 104, 113, 97, 114, 125, 119, 41, 52, 84, 124, 124, 116, 127, 118, 51, 80, 123, 97, 124, 126, 118, 52, 63, 101, 118, 97, 96, 122, 124, 125, 41, 52, 34, 33, 35, 52, 110, 63, 104, 113, 97, 114, 125, 119, 41, 52, 93, 124, 103, 46, 82, 44, 81, 97, 114, 125, 119, 52, 63, 101, 118, 97, 96, 122, 124, 125, 41, 52, 33, 39, 52, 110, 78, 63, 126, 124, 113, 122, 127, 118, 41, 117, 114, 127, 96, 118, 63, 99, 127, 114, 103, 117, 124, 97, 126, 41, 52, 68, 122, 125, 119, 124, 100, 96, 52, 63, 116, 118, 103, 91, 122, 116, 123, 86, 125, 103, 97, 124, 99, 106, 69, 114, 127, 102, 118, 96, 41, 117, 102, 125, 112, 103, 122, 124, 125, 59, 58, 104, 97, 118, 103, 102, 97, 125, 51, 67, 97, 124, 126, 122, 96, 118, 61, 97, 118, 96, 124, 127, 101, 118, 59, 104, 114, 97, 112, 123, 122, 103, 118, 112, 103, 102, 97, 118, 41, 52, 107, 43, 37, 52, 63, 113, 122, 103, 125, 118, 96, 96, 41, 52, 37, 39, 52, 63, 126, 124, 113, 122, 127, 118, 41, 117, 114, 127, 96, 118, 63, 126, 124, 119, 118, 127, 41, 52, 52, 63, 99, 127, 114, 103, 117, 124, 97, 126, 41, 52, 68, 122, 125, 119, 124, 100, 96, 52, 63, 99, 127, 114, 103, 117, 124, 97, 126, 69, 118, 97, 96, 122, 124, 125, 41, 52, 34, 38, 61, 35, 61, 35, 52, 63, 102, 114, 85, 102, 127, 127, 69, 118, 97, 96, 122, 124, 125, 41, 52, 34, 33, 35, 61, 35, 61, 35, 61, 35, 52, 110, 58, 40, 110, 110, 40, 92, 113, 121, 118, 112, 103, 61, 119, 118, 117, 122, 125, 118, 67, 97, 124, 99, 118, 97, 103, 106, 59, 99, 97, 124, 103, 124, 63, 52, 102, 96, 118, 97, 82, 116, 118, 125, 103, 87, 114, 103, 114, 52, 63, 104, 116, 118, 103, 41, 117, 102, 125, 112, 103, 122, 124, 125, 59, 58, 104, 97, 118, 103, 102, 97, 125, 51, 102, 114, 119, 40, 110, 63, 112, 124, 125, 117, 122, 116, 102, 97, 114, 113, 127, 118, 41, 103, 97, 102, 118, 110, 58, 40, 110, 112, 114, 103, 112, 123, 59, 118, 58, 104, 110 }, 19) + _0x17dc8940._0x3fe00c49(new byte[112] { 208, 209, 210, 156, 199, 215, 198, 209, 209, 218, 152, 147, 195, 221, 208, 192, 220, 147, 152, 133, 141, 134, 132, 157, 143, 208, 209, 210, 156, 199, 215, 198, 209, 209, 218, 152, 147, 220, 209, 221, 211, 220, 192, 147, 152, 133, 132, 140, 132, 157, 143, 208, 209, 210, 156, 199, 215, 198, 209, 209, 218, 152, 147, 213, 194, 213, 221, 216, 227, 221, 208, 192, 220, 147, 152, 133, 141, 134, 132, 157, 143, 208, 209, 210, 156, 199, 215, 198, 209, 209, 218, 152, 147, 213, 194, 213, 221, 216, 252, 209, 221, 211, 220, 192, 147, 152, 133, 132, 128, 132, 157, 143 }, 180) + _0x17dc8940._0x3fe00c49(new byte[45] { 150, 144, 155, 153, 149, 139, 140, 134, 141, 149, 204, 141, 140, 150, 141, 151, 129, 138, 145, 150, 131, 144, 150, 223, 151, 140, 134, 135, 132, 139, 140, 135, 134, 217, 159, 129, 131, 150, 129, 138, 202, 135, 203, 153, 159 }, 226) + _0x17dc8940._0x3fe00c49(new byte[721] { 188, 186, 177, 179, 190, 169, 186, 232, 167, 186, 161, 175, 245, 191, 161, 166, 172, 167, 191, 230, 165, 169, 188, 171, 160, 133, 173, 172, 161, 169, 230, 170, 161, 166, 172, 224, 191, 161, 166, 172, 167, 191, 225, 243, 191, 161, 166, 172, 167, 191, 230, 165, 169, 188, 171, 160, 133, 173, 172, 161, 169, 245, 174, 189, 166, 171, 188, 161, 167, 166, 224, 185, 225, 179, 190, 169, 186, 232, 187, 245, 155, 188, 186, 161, 166, 175, 224, 185, 225, 230, 188, 167, 132, 167, 191, 173, 186, 139, 169, 187, 173, 224, 225, 243, 161, 174, 224, 187, 230, 161, 166, 172, 173, 176, 135, 174, 224, 239, 184, 167, 161, 166, 188, 173, 186, 242, 232, 171, 167, 169, 186, 187, 173, 239, 225, 246, 245, 248, 180, 180, 187, 230, 161, 166, 172, 173, 176, 135, 174, 224, 239, 160, 167, 190, 173, 186, 242, 232, 166, 167, 166, 173, 239, 225, 246, 245, 248, 180, 180, 187, 230, 161, 166, 172, 173, 176, 135, 174, 224, 239, 165, 169, 176, 229, 191, 161, 172, 188, 160, 239, 225, 246, 245, 248, 180, 180, 187, 230, 161, 166, 172, 173, 176, 135, 174, 224, 239, 165, 169, 176, 229, 172, 173, 190, 161, 171, 173, 229, 191, 161, 172, 188, 160, 239, 225, 246, 245, 248, 225, 186, 173, 188, 189, 186, 166, 232, 179, 165, 169, 188, 171, 160, 173, 187, 242, 174, 169, 164, 187, 173, 228, 165, 173, 172, 161, 169, 242, 185, 228, 167, 166, 171, 160, 169, 166, 175, 173, 242, 166, 189, 164, 164, 228, 169, 172, 172, 132, 161, 187, 188, 173, 166, 173, 186, 242, 174, 189, 166, 171, 188, 161, 167, 166, 224, 225, 179, 181, 228, 186, 173, 165, 167, 190, 173, 132, 161, 187, 188, 173, 166, 173, 186, 242, 174, 189, 166, 171, 188, 161, 167, 166, 224, 225, 179, 181, 228, 169, 172, 172, 141, 190, 173, 166, 188, 132, 161, 187, 188, 173, 166, 173, 186, 242, 174, 189, 166, 171, 188, 161, 167, 166, 224, 225, 179, 181, 228, 186, 173, 165, 167, 190, 173, 141, 190, 173, 166, 188, 132, 161, 187, 188, 173, 166, 173, 186, 242, 174, 189, 166, 171, 188, 161, 167, 166, 224, 225, 179, 181, 228, 172, 161, 187, 184, 169, 188, 171, 160, 141, 190, 173, 166, 188, 242, 174, 189, 166, 171, 188, 161, 167, 166, 224, 225, 179, 186, 173, 188, 189, 186, 166, 232, 174, 169, 164, 187, 173, 243, 181, 181, 243, 161, 174, 224, 187, 230, 161, 166, 172, 173, 176, 135, 174, 224, 239, 184, 167, 161, 166, 188, 173, 186, 242, 232, 174, 161, 166, 173, 239, 225, 246, 245, 248, 180, 180, 187, 230, 161, 166, 172, 173, 176, 135, 174, 224, 239, 160, 167, 190, 173, 186, 242, 232, 160, 167, 190, 173, 186, 239, 225, 246, 245, 248, 225, 186, 173, 188, 189, 186, 166, 232, 179, 165, 169, 188, 171, 160, 173, 187, 242, 188, 186, 189, 173, 228, 165, 173, 172, 161, 169, 242, 185, 228, 167, 166, 171, 160, 169, 166, 175, 173, 242, 166, 189, 164, 164, 228, 169, 172, 172, 132, 161, 187, 188, 173, 166, 173, 186, 242, 174, 189, 166, 171, 188, 161, 167, 166, 224, 225, 179, 181, 228, 186, 173, 165, 167, 190, 173, 132, 161, 187, 188, 173, 166, 173, 186, 242, 174, 189, 166, 171, 188, 161, 167, 166, 224, 225, 179, 181, 228, 169, 172, 172, 141, 190, 173, 166, 188, 132, 161, 187, 188, 173, 166, 173, 186, 242, 174, 189, 166, 171, 188, 161, 167, 166, 224, 225, 179, 181, 228, 186, 173, 165, 167, 190, 173, 141, 190, 173, 166, 188, 132, 161, 187, 188, 173, 166, 173, 186, 242, 174, 189, 166, 171, 188, 161, 167, 166, 224, 225, 179, 181, 228, 172, 161, 187, 184, 169, 188, 171, 160, 141, 190, 173, 166, 188, 242, 174, 189, 166, 171, 188, 161, 167, 166, 224, 225, 179, 186, 173, 188, 189, 186, 166, 232, 174, 169, 164, 187, 173, 243, 181, 181, 243, 186, 173, 188, 189, 186, 166, 232, 167, 186, 161, 175, 224, 185, 225, 243, 181, 243, 181, 171, 169, 188, 171, 160, 224, 173, 225, 179, 181 }, 200) + _0x17dc8940._0x3fe00c49(new byte[5] { 197, 145, 144, 145, 131 }, 184);
    }

    private string _0x662ce995 = "";
    private readonly string[] _0xe1a1dd36 = new string[]
    {
        _0x17dc8940._0x3fe00c49(new byte[60] { 254, 145, 128, 190, 46, 90, 102, 107, 46, 124, 107, 107, 98, 125, 46, 111, 124, 107, 46, 102, 97, 122, 46, 124, 103, 105, 102, 122, 46, 96, 97, 121, 46, 236, 142, 157, 46, 106, 97, 96, 236, 142, 151, 122, 46, 99, 103, 125, 125, 46, 119, 97, 123, 124, 46, 125, 126, 103, 96, 47 }, 14),
        _0x17dc8940._0x3fe00c49(new byte[52] { 99, 12, 30, 19, 179, 218, 231, 179, 240, 252, 230, 255, 247, 179, 241, 246, 179, 234, 252, 230, 225, 179, 255, 230, 240, 248, 234, 179, 254, 252, 254, 246, 253, 231, 179, 113, 19, 0, 179, 228, 251, 234, 179, 224, 231, 252, 227, 179, 253, 252, 228, 172 }, 147),
        _0x17dc8940._0x3fe00c49(new byte[66] { 179, 203, 240, 190, 233, 222, 113, 19, 56, 54, 113, 38, 56, 63, 34, 113, 48, 35, 52, 113, 57, 56, 37, 37, 56, 63, 54, 113, 60, 62, 35, 52, 113, 62, 55, 37, 52, 63, 113, 37, 62, 53, 48, 40, 113, 179, 209, 194, 113, 34, 37, 48, 40, 113, 56, 63, 113, 37, 57, 52, 113, 54, 48, 60, 52, 127 }, 81),
        _0x17dc8940._0x3fe00c49(new byte[54] { 143, 224, 234, 237, 95, 43, 23, 22, 12, 95, 22, 12, 95, 15, 13, 22, 18, 26, 95, 11, 22, 18, 26, 95, 157, 255, 236, 95, 11, 23, 26, 95, 29, 26, 12, 11, 95, 15, 19, 30, 6, 26, 13, 12, 95, 15, 19, 30, 6, 95, 17, 16, 8, 81 }, 127),
        _0x17dc8940._0x3fe00c49(new byte[48] { 77, 34, 41, 24, 157, 228, 210, 200, 207, 157, 202, 212, 211, 211, 212, 211, 218, 157, 206, 201, 207, 216, 220, 214, 157, 222, 210, 200, 209, 217, 157, 223, 216, 157, 210, 211, 216, 157, 206, 205, 212, 211, 157, 220, 202, 220, 196, 147 }, 189),
        _0x17dc8940._0x3fe00c49(new byte[65] { 239, 128, 133, 159, 63, 85, 126, 124, 116, 111, 112, 107, 108, 63, 126, 109, 122, 63, 114, 112, 109, 122, 63, 126, 124, 107, 118, 105, 122, 63, 107, 112, 113, 118, 120, 119, 107, 63, 253, 159, 140, 63, 108, 107, 126, 102, 63, 126, 113, 123, 63, 107, 109, 102, 63, 102, 112, 106, 109, 63, 115, 106, 124, 116, 49 }, 31),
        _0x17dc8940._0x3fe00c49(new byte[55] { 165, 202, 219, 231, 117, 16, 35, 48, 39, 44, 117, 38, 37, 60, 59, 117, 54, 58, 32, 59, 33, 38, 117, 183, 213, 198, 117, 33, 61, 48, 117, 59, 48, 45, 33, 117, 58, 59, 48, 117, 54, 58, 32, 57, 49, 117, 55, 48, 117, 44, 58, 32, 39, 38, 123 }, 85),
        _0x17dc8940._0x3fe00c49(new byte[63] { 133, 202, 247, 136, 223, 232, 71, 55, 11, 6, 30, 2, 21, 20, 71, 21, 14, 0, 15, 19, 71, 9, 8, 16, 71, 6, 21, 2, 71, 16, 14, 9, 9, 14, 9, 0, 71, 133, 231, 244, 71, 3, 8, 9, 133, 231, 254, 19, 71, 16, 6, 11, 12, 71, 6, 16, 6, 30, 71, 30, 2, 19, 73 }, 103),
        _0x17dc8940._0x3fe00c49(new byte[51] { 221, 178, 162, 171, 13, 98, 67, 65, 84, 13, 89, 69, 66, 94, 72, 13, 90, 69, 66, 13, 94, 89, 76, 84, 13, 68, 67, 13, 89, 69, 72, 13, 74, 76, 64, 72, 13, 90, 68, 67, 13, 89, 69, 72, 13, 93, 95, 68, 87, 72, 3 }, 45),
        _0x17dc8940._0x3fe00c49(new byte[64] { 85, 45, 22, 88, 15, 56, 151, 250, 216, 218, 210, 217, 195, 194, 218, 151, 222, 196, 151, 210, 193, 210, 197, 206, 195, 223, 222, 217, 208, 151, 85, 55, 36, 151, 220, 210, 210, 199, 151, 196, 199, 222, 217, 217, 222, 217, 208, 151, 209, 216, 197, 151, 206, 216, 194, 197, 151, 212, 223, 214, 217, 212, 210, 153 }, 183)
    };
    private void _0x9cbbe39f()
    {
        {
#if B_LOGS
            Debug.Log(_0x17dc8940._0x3fe00c49(new byte[22] { 245, 250, 203, 221, 218, 243, 142, 253, 218, 193, 220, 203, 234, 203, 216, 199, 205, 203, 231, 192, 200, 193 }, 174));
#endif
        }

        _0x395791da = SystemInfo.deviceModel;
        _0x1b5664f0 = Application.version;
        _0xb8b65304 = Application.installMode;
        _0xc6dea4e9 = Application.installerName;
        _0x662ce995 = Application.identifier;
        _0x3b7d1bdf = _0x638ece1d();
        _0x17bd0834 = _0x14ad41c4();
        _0x5148cb16 = SystemInfo.deviceUniqueIdentifier;
        _0xfd84ae6b = SystemInfo.graphicsDeviceName;
        _0x1576cba3 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x1b5664f0 = _0x17dc8940._0x3fe00c49(new byte[5] { 22, 15, 22, 15, 22 }, 33);
                _0xb8b65304 = ApplicationInstallMode.Store;
                _0xc6dea4e9 = _0x17dc8940._0x3fe00c49(new byte[19] { 211, 223, 221, 158, 209, 222, 212, 194, 223, 217, 212, 158, 198, 213, 222, 212, 217, 222, 215 }, 176);
                _0x17bd0834 = _0x17dc8940._0x3fe00c49(new byte[8] { 117, 125, 96, 100, 105, 48, 101, 113 }, 16);
                _0x5148cb16 = Guid.NewGuid().ToString().Replace(_0x17dc8940._0x3fe00c49(new byte[1] { 6 }, 43), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x17dc8940._0x3fe00c49(new byte[17] { 246, 249, 200, 222, 217, 240, 141, 201, 200, 219, 224, 194, 201, 200, 193, 151, 141 }, 173) + _0x395791da);
            Debug.Log(_0x17dc8940._0x3fe00c49(new byte[19] { 71, 72, 121, 111, 104, 65, 60, 125, 108, 108, 74, 121, 110, 111, 117, 115, 114, 38, 60 }, 28) + _0x1b5664f0);
            Debug.Log(_0x17dc8940._0x3fe00c49(new byte[20] { 138, 133, 180, 162, 165, 140, 241, 184, 191, 162, 165, 176, 189, 189, 156, 190, 181, 180, 235, 241 }, 209) + _0xb8b65304);
            Debug.Log(_0x17dc8940._0x3fe00c49(new byte[23] { 123, 116, 69, 83, 84, 125, 0, 73, 78, 83, 84, 65, 76, 76, 69, 82, 115, 84, 79, 82, 69, 26, 0 }, 32) + _0xc6dea4e9);
            Debug.Log(_0x17dc8940._0x3fe00c49(new byte[14] { 227, 236, 221, 203, 204, 229, 152, 217, 200, 200, 241, 220, 130, 152 }, 184) + _0x662ce995);
            Debug.Log(_0x17dc8940._0x3fe00c49(new byte[14] { 237, 226, 211, 197, 194, 235, 150, 215, 210, 192, 255, 210, 140, 150 }, 182) + _0x3b7d1bdf);
            Debug.Log(_0x17dc8940._0x3fe00c49(new byte[18] { 134, 137, 184, 174, 169, 128, 253, 168, 174, 184, 175, 156, 186, 184, 179, 169, 231, 253 }, 221) + _0x17bd0834);
            Debug.Log(_0x17dc8940._0x3fe00c49(new byte[17] { 20, 27, 42, 60, 59, 18, 111, 60, 54, 60, 11, 42, 57, 6, 43, 117, 111 }, 79) + _0x5148cb16);
            Debug.Log(_0x17dc8940._0x3fe00c49(new byte[12] { 101, 106, 91, 77, 74, 99, 30, 89, 78, 75, 4, 30 }, 62) + _0xfd84ae6b);
            Debug.Log(_0x17dc8940._0x3fe00c49(new byte[12] { 114, 125, 76, 90, 93, 116, 9, 74, 89, 92, 19, 9 }, 41) + _0x1576cba3);
#endif
        }
    }

    private async Task _0xd6a7d778()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x6a187cf7 = _0x17dc8940._0x3fe00c49(new byte[5] { 254, 249, 244, 235, 253 }, 152);
        _0xe8b79f8a = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0xba391fcf = DateTime.UtcNow.Ticks.ToString();
        _0x058f8a8d = "";
        JObject _0x8972c27b = _0x62bd6d4b(_0x662ce995, _0x6c0f2beb, _0x3b7d1bdf, _0xcb802ecc, _0x54c08599, _0xf7a63d2e, _0x55e88141, _0x17bd0834, _0xbf9463a7, _0x5148cb16, _0x6a187cf7, _0x058f8a8d, _0x395791da, _0x1b5664f0, _0xb8b65304.ToString(), _0xc6dea4e9, _0xba391fcf, _0xe8b79f8a, _0x09689c98, _0xfd84ae6b, _0x1576cba3, _0x22b4fe6f, _0xe493ae58());
        var _0xe10f450b = _0xd3008ec6(_0x8972c27b.ToString(), _0x09689c98);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x8972c27b}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x17dc8940._0x3fe00c49(new byte[7] { 39, 54, 46, 59, 56, 54, 51 }, 87) + _0x09689c98, _0xe10f450b } });
            await Task.Delay(500);
            string _0x76b91f27 = "";
            for (int _0x670f211a = 0; _0x670f211a < 20; _0x670f211a++)
            {
                if (await _0x4bbfb0b8(1, 1))
                {
                    await _0x16e7042d(_0x17dc8940._0x3fe00c49(new byte[7] { 113, 127, 124, 112, 120, 118, 119 }, 19));
                    _0x57af6bc3();
                    return;
                }

                _0x76b91f27 = await _0x83ba6443(1, 500);
                if (!string.IsNullOrEmpty(_0x76b91f27))
                    break;
            }

            _0x9f77225c(_0x76b91f27);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x17dc8940._0x3fe00c49(new byte[22] { 253, 242, 227, 245, 242, 251, 134, 225, 195, 200, 195, 212, 199, 202, 134, 195, 212, 212, 201, 212, 156, 134 }, 166) + e.Message);
#endif
            }

            _0x57af6bc3();
        }
    }

    private bool _0xff01e7c1(string _0x2414dd2b)
    {
        try
        {
            using (var _0xa4a9f6a0 = new AndroidJavaClass(_0x17dc8940._0x3fe00c49(new byte[30] { 240, 252, 254, 189, 230, 253, 250, 231, 234, 160, 247, 189, 227, 255, 242, 234, 246, 225, 189, 198, 253, 250, 231, 234, 195, 255, 242, 234, 246, 225 }, 147)))
            using (var _0xb1528322 = _0xa4a9f6a0.GetStatic<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[15] { 36, 50, 53, 53, 34, 41, 51, 6, 36, 51, 46, 49, 46, 51, 62 }, 71)))
            using (var _0xcbb7b55b = new AndroidJavaClass(_0x17dc8940._0x3fe00c49(new byte[15] { 147, 156, 150, 128, 157, 155, 150, 220, 156, 151, 134, 220, 167, 128, 155 }, 242)))
            using (var _0x111fca2f = _0xcbb7b55b.CallStatic<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[5] { 181, 164, 183, 182, 160 }, 197), _0x2414dd2b))
            using (var _0xacf14e92 = new AndroidJavaObject(_0x17dc8940._0x3fe00c49(new byte[22] { 224, 239, 229, 243, 238, 232, 229, 175, 226, 238, 239, 245, 228, 239, 245, 175, 200, 239, 245, 228, 239, 245 }, 129), _0x17dc8940._0x3fe00c49(new byte[26] { 156, 147, 153, 143, 146, 148, 153, 211, 148, 147, 137, 152, 147, 137, 211, 156, 158, 137, 148, 146, 147, 211, 171, 180, 184, 170 }, 253), _0x111fca2f))
            {
                WLog(_0x17dc8940._0x3fe00c49(new byte[26] { 248, 211, 201, 212, 214, 222, 247, 210, 208, 222, 155, 212, 203, 222, 213, 155, 222, 195, 207, 222, 201, 213, 218, 215, 129, 155 }, 187) + _0x2414dd2b);
                _0xacf14e92.Call<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[11] { 43, 46, 46, 9, 43, 62, 47, 45, 37, 56, 51 }, 74), _0x17dc8940._0x3fe00c49(new byte[33] { 26, 21, 31, 9, 20, 18, 31, 85, 18, 21, 15, 30, 21, 15, 85, 24, 26, 15, 30, 28, 20, 9, 2, 85, 57, 41, 52, 44, 40, 58, 57, 55, 62 }, 123));
                _0xacf14e92.Call<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[8] { 154, 159, 159, 189, 151, 154, 156, 136 }, 251), 0x10000000);
                _0xb1528322.Call(_0x17dc8940._0x3fe00c49(new byte[13] { 89, 94, 75, 88, 94, 107, 73, 94, 67, 92, 67, 94, 83 }, 42), _0xacf14e92);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x17dc8940._0x3fe00c49(new byte[28] { 26, 49, 43, 54, 52, 60, 21, 48, 50, 60, 121, 60, 33, 45, 60, 43, 55, 56, 53, 121, 63, 56, 48, 53, 60, 61, 99, 121 }, 89) + e.Message);
            Application.OpenURL(_0x2414dd2b);
            return true;
        }
    }

    private async Task<bool> _0x37364526()
    {
        {
#if B_LOGS
            Debug.Log(_0x17dc8940._0x3fe00c49(new byte[37] { 180, 187, 138, 156, 155, 178, 207, 188, 134, 136, 129, 166, 129, 186, 129, 134, 155, 150, 188, 138, 157, 153, 134, 140, 138, 156, 174, 129, 128, 129, 150, 130, 128, 154, 156, 131, 150 }, 239));
#endif
        }

        try
        {
            var _0x6e4a803c = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x6e4a803c);
            {
#if B_LOGS
                Debug.Log(_0x17dc8940._0x3fe00c49(new byte[32] { 222, 209, 224, 246, 241, 216, 165, 208, 235, 236, 241, 252, 214, 224, 247, 243, 236, 230, 224, 246, 165, 204, 235, 236, 241, 236, 228, 233, 236, 255, 224, 225 }, 133));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x17dc8940._0x3fe00c49(new byte[20] { 221, 204, 218, 221, 169, 220, 231, 224, 253, 240, 218, 236, 251, 255, 224, 234, 236, 250, 179, 169 }, 137) + ex.Message);
#endif
            }

            _0xba8b03bb?._0x57af6bc3();
            return true;
        }

        bool _0x0b91fe69 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x0b91fe69 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x17dc8940._0x3fe00c49(new byte[37] { 71, 72, 121, 111, 104, 65, 60, 79, 117, 123, 114, 49, 117, 114, 60, 93, 114, 115, 114, 101, 113, 115, 105, 111, 50, 60, 76, 112, 125, 101, 121, 110, 60, 85, 88, 38, 60 }, 28) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x09689c98 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x17dc8940._0x3fe00c49(new byte[25] { 48, 33, 55, 48, 68, 55, 13, 3, 10, 73, 13, 10, 68, 37, 17, 16, 12, 68, 33, 54, 54, 43, 54, 94, 68 }, 100) + ex.Message);
#endif
                }

                _0xba8b03bb?._0x57af6bc3();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x17dc8940._0x3fe00c49(new byte[28] { 137, 152, 142, 137, 253, 142, 180, 186, 179, 240, 180, 179, 253, 143, 184, 172, 168, 184, 174, 169, 253, 152, 143, 143, 146, 143, 231, 253 }, 221) + ex.Message);
#endif
                }

                _0xba8b03bb?._0x57af6bc3();
                return true;
            }
        }
        while (!_0x0b91fe69);
        return false;
    }

    private string _0x1576cba3 = "";
    private void _0x7e7c2d11()
    {
        using (var _0xc6aad8fb = new AndroidJavaClass(_0x17dc8940._0x3fe00c49(new byte[30] { 192, 204, 206, 141, 214, 205, 202, 215, 218, 144, 199, 141, 211, 207, 194, 218, 198, 209, 141, 246, 205, 202, 215, 218, 243, 207, 194, 218, 198, 209 }, 163)))
        using (var _0x34b32a07 = _0xc6aad8fb.GetStatic<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[15] { 170, 188, 187, 187, 172, 167, 189, 136, 170, 189, 160, 191, 160, 189, 176 }, 201)))
        using (var _0x4fdf6c28 = _0x34b32a07.Call<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[9] { 108, 110, 127, 66, 101, 127, 110, 101, 127 }, 11)))
        {
            if (_0x4fdf6c28 == null)
                return;
            using (var _0x6497a569 = _0x4fdf6c28.Call<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[9] { 145, 147, 130, 179, 142, 130, 132, 151, 133 }, 246)))
            {
                if (_0x6497a569 == null)
                    return;
                using (var _0x017d1b5b = new AndroidJavaObject(_0x17dc8940._0x3fe00c49(new byte[19] { 142, 147, 134, 207, 139, 146, 142, 143, 207, 171, 178, 174, 175, 174, 131, 139, 132, 130, 149 }, 225)))
                using (var _0xb918b857 = _0x6497a569.Call<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[6] { 169, 167, 187, 145, 167, 182 }, 194)))
                using (var _0x692eab5a = _0xb918b857.Call<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[8] { 120, 101, 116, 99, 112, 101, 126, 99 }, 17)))
                {
                    while (_0x692eab5a.Call<bool>(_0x17dc8940._0x3fe00c49(new byte[7] { 107, 98, 112, 77, 102, 123, 119 }, 3)))
                    {
                        string _0xebd481a7 = _0x692eab5a.Call<string>(_0x17dc8940._0x3fe00c49(new byte[4] { 65, 74, 87, 91 }, 47));
                        using (var _0x7bcbcc03 = _0x6497a569.Call<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[3] { 35, 33, 48 }, 68), _0xebd481a7))
                        {
                            _0x017d1b5b.Call<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[3] { 99, 102, 103 }, 19), _0xebd481a7, _0x7bcbcc03);
                        }
                    }

                    string _0x4cd65377 = _0x017d1b5b.Call<string>(_0x17dc8940._0x3fe00c49(new byte[8] { 35, 56, 4, 35, 37, 62, 57, 48 }, 87));
                    if (!string.IsNullOrEmpty(_0x4cd65377))
                    {
                        _0x1dea5538(_0x4cd65377);
                        _0xd004ac0f(_0x4cd65377);
                    }
                }
            }
        }
    }

    private string Decrypt(string _0x965918e9, string _0xd6a79c58)
    {
        try
        {
            var _0x3cd05e3f = Convert.FromBase64String(_0x965918e9);
            using var _0xd62225c4 = Aes.Create();
            _0xd62225c4.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xd6a79c58));
            var _0x989f3d25 = new byte[16];
            Buffer.BlockCopy(_0x3cd05e3f, 0, _0x989f3d25, 0, 16);
            _0xd62225c4.IV = _0x989f3d25;
            using var _0x39cdd7a3 = new MemoryStream(_0x3cd05e3f, 16, _0x3cd05e3f.Length - 16);
            using var _0xd2a3b896 = new CryptoStream(_0x39cdd7a3, _0xd62225c4.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0xef440402 = new StreamReader(_0xd2a3b896, Encoding.UTF8);
            return _0xef440402.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private async void Start()
    {
        await _0xa0aa2c2d();
    }

    private void OnApplicationFocus(bool _0x83ee2dcf)
    {
        isApplicationFocus = _0x83ee2dcf;
        if (_0x83ee2dcf && _0xd1cbb3db)
        {
            _0x7e7c2d11();
        }
    }

    private Task _0x9f719cfd(IEnumerator _0x93b07fc0)
    {
        var _0x27fcceef = new TaskCompletionSource<bool>();
        StartCoroutine(_0x4c758732(_0x93b07fc0, _0x27fcceef));
        return _0x27fcceef.Task;
    }

    private UniWebViewPopup _0xae5aaeb7()
    {
        for (int _0x9af5ce22 = _0xfbf86806.Count - 1; _0x9af5ce22 >= 0; _0x9af5ce22--)
        {
            var _0xb2fd5dfc = _0xfbf86806[_0x9af5ce22];
            if (_0xb2fd5dfc != null && _0xb2fd5dfc.IsAlive)
                return _0xb2fd5dfc;
            _0xfbf86806.RemoveAt(_0x9af5ce22);
        }

        return null;
    }

    private bool _0x0d164da4(string _0xf7c71491, string _0x0c811dd4)
    {
        string _0x1dd84547 = _0x02f1bdb8(_0xf7c71491);
        if (string.IsNullOrEmpty(_0x1dd84547))
            _0x1dd84547 = _0x0c811dd4;
        if (_0x32d49445(_0x1dd84547))
            return true;
        string _0x1b01d2ee = string.IsNullOrEmpty(_0x1dd84547) ? _0x17dc8940._0x3fe00c49(new byte[29] { 78, 82, 82, 86, 85, 28, 9, 9, 86, 74, 71, 95, 8, 65, 73, 73, 65, 74, 67, 8, 69, 73, 75, 9, 85, 82, 73, 84, 67 }, 38) : _0x17dc8940._0x3fe00c49(new byte[46] { 174, 178, 178, 182, 181, 252, 233, 233, 182, 170, 167, 191, 232, 161, 169, 169, 161, 170, 163, 232, 165, 169, 171, 233, 181, 178, 169, 180, 163, 233, 167, 182, 182, 181, 233, 162, 163, 178, 167, 175, 170, 181, 249, 175, 162, 251 }, 198) + _0x1dd84547;
        WLog(_0x17dc8940._0x3fe00c49(new byte[35] { 0, 43, 49, 44, 46, 38, 15, 42, 40, 38, 99, 46, 34, 49, 40, 38, 55, 99, 37, 34, 47, 47, 33, 34, 32, 40, 99, 34, 48, 99, 52, 38, 33, 121, 99 }, 67) + _0x1b01d2ee);
        return _0xff01e7c1(_0x1b01d2ee);
    }

    private IEnumerator _0x52923465(float _0xb266d30c)
    {
        yield return new WaitForSeconds(_0xb266d30c);
        if (!_0x3b8d2586)
        {
            _0x3b8d2586 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x54c08599}");
                }
#endif
            }
        }
    }

    private IEnumerator _0x9817d4eb(string _0x9025da79)
    {
        if (_0x3b4eca97 != null && _0xd1cbb3db)
            yield break;
        _0x3b4eca97 = gameObject.AddComponent<UniWebView>();
        _0x4692018d(_0x3b4eca97);
        _0xdfc5581a(_0x3b4eca97);
        _0x3b4eca97.BackgroundColor = Color.clear;
        var _0xc22a0997 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x5fd33bef();
        yield return new WaitForEndOfFrame();
        _0xd1cbb3db = true;
        _0x6d65c73b();
        _0xdc3d2bea(true);
        _0xe2c63157 = false;
        _0x164ea5ca = false;
        _0xfbf86806.Clear();
        _0x06b5d64e = -1;
        firstLoadShown = false;
        _0x5be055d5 = false;
        _0x2d637911 = false;
        _0x3b4eca97.SetUserAgent("");
        _0x6f0216df = Time.realtimeSinceStartup;
        _0x3b4eca97.Stop();
        _0x3b4eca97.Load(_0x9025da79);
        _0x3b4eca97.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x17dc8940._0x3fe00c49(new byte[25] { 242, 222, 214, 209, 159, 232, 218, 221, 233, 214, 218, 200, 159, 246, 209, 214, 203, 214, 222, 211, 159, 236, 215, 208, 200 }, 191));
    }

    private bool _0x6a4e9c70()
    {
        var _0x3ff09698 = Keyboard.current;
        return _0x3ff09698 != null && _0x3ff09698.escapeKey.wasPressedThisFrame;
    }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0xd3008ec6(string _0x935bc2b7, string _0xe7e8d334)
    {
        try
        {
            using var _0x496d39f9 = Aes.Create();
            _0x496d39f9.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xe7e8d334));
            _0x496d39f9.GenerateIV();
            using var _0xad38bdea = new MemoryStream();
            _0xad38bdea.Write(_0x496d39f9.IV, 0, _0x496d39f9.IV.Length);
            using (var _0x4780ad49 = new CryptoStream(_0xad38bdea, _0x496d39f9.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x5a0360d5 = Encoding.UTF8.GetBytes(_0x935bc2b7);
                _0x4780ad49.Write(_0x5a0360d5, 0, _0x5a0360d5.Length);
                _0x4780ad49.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0xad38bdea.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x57af6bc3();
    }

    private static string ReadPushField(Dictionary<string, object> _0x439b95d9, string _0x42f14092)
    {
        if (_0x439b95d9 == null || string.IsNullOrEmpty(_0x42f14092))
            return string.Empty;
        if (_0x439b95d9.TryGetValue(_0x17dc8940._0x3fe00c49(new byte[16] { 247, 246, 237, 240, 255, 240, 250, 248, 237, 240, 246, 247, 221, 248, 237, 248 }, 153), out var raw))
        {
            try
            {
                var _0x1599cabf = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x1599cabf != null && _0x1599cabf.TryGetValue(_0x42f14092, out var nestedVal))
                {
                    var _0x64dfef32 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x64dfef32))
                        return _0x64dfef32;
                }
            }
            catch
            {
            }
        }

        if (_0x439b95d9.TryGetValue(_0x42f14092, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private Canvas _0xa8a14f6a;
    private int _0x06b5d64e = -1;
    internal bool IsAboutBlank(string _0x3bfe3b4c)
    {
        if (string.IsNullOrEmpty(_0x3bfe3b4c))
            return false;
        return _0x3bfe3b4c.StartsWith(_0x17dc8940._0x3fe00c49(new byte[11] { 17, 18, 31, 5, 4, 74, 18, 28, 17, 30, 27 }, 112), StringComparison.OrdinalIgnoreCase);
    }

    // WEB VIEW LOGIC END
    internal void _0xe6522d3c()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x9c42d035 = new AndroidNotificationChannel
        {
            Id = _0x17dc8940._0x3fe00c49(new byte[15] { 223, 222, 221, 218, 206, 215, 207, 228, 216, 211, 218, 213, 213, 222, 215 }, 187),
            Name = _0x17dc8940._0x3fe00c49(new byte[15] { 31, 62, 61, 58, 46, 55, 47, 123, 24, 51, 58, 53, 53, 62, 55 }, 91),
            Importance = Importance.High,
            Description = _0x17dc8940._0x3fe00c49(new byte[21] { 119, 85, 94, 85, 66, 81, 92, 16, 94, 95, 68, 89, 86, 89, 83, 81, 68, 89, 95, 94, 67 }, 48)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x9c42d035);
        // Build notification
        var _0x10dedb19 = new AndroidNotification
        {
            Title = _0xe1a1dd36[UnityEngine.Random.Range(0, _0xe1a1dd36.Length)],
            Text = _0x17dc8940._0x3fe00c49(new byte[21] { 80, 99, 116, 49, 104, 126, 100, 49, 98, 100, 99, 116, 49, 101, 126, 49, 116, 105, 120, 101, 46 }, 17),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x10dedb19, _0x17dc8940._0x3fe00c49(new byte[15] { 10, 11, 8, 15, 27, 2, 26, 49, 13, 6, 15, 0, 0, 11, 2 }, 110));
    }

    private bool _0xa1cc4b21(string _0xa7da5e96)
    {
        try
        {
            using (var _0x8fae6c92 = new AndroidJavaClass(_0x17dc8940._0x3fe00c49(new byte[30] { 7, 11, 9, 74, 17, 10, 13, 16, 29, 87, 0, 74, 20, 8, 5, 29, 1, 22, 74, 49, 10, 13, 16, 29, 52, 8, 5, 29, 1, 22 }, 100)))
            using (var _0xaa319715 = _0x8fae6c92.GetStatic<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[15] { 252, 234, 237, 237, 250, 241, 235, 222, 252, 235, 246, 233, 246, 235, 230 }, 159)))
            using (var _0xd5b0b495 = _0xaa319715.Call<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[17] { 179, 177, 160, 132, 181, 183, 191, 181, 179, 177, 153, 181, 186, 181, 179, 177, 166 }, 212)))
            using (var _0x59141056 = new AndroidJavaClass(_0x17dc8940._0x3fe00c49(new byte[22] { 148, 155, 145, 135, 154, 156, 145, 219, 150, 154, 155, 129, 144, 155, 129, 219, 188, 155, 129, 144, 155, 129 }, 245)))
            using (var _0xfc0656d8 = _0x59141056.CallStatic<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[8] { 47, 62, 45, 44, 58, 10, 45, 54 }, 95), _0xa7da5e96, 1))
            {
                string _0x24c41b1c = _0xfc0656d8.Call<string>(_0x17dc8940._0x3fe00c49(new byte[14] { 162, 160, 177, 150, 177, 183, 172, 171, 162, 128, 189, 177, 183, 164 }, 197), _0x17dc8940._0x3fe00c49(new byte[20] { 59, 43, 54, 46, 42, 60, 43, 6, 63, 56, 53, 53, 59, 56, 58, 50, 6, 44, 43, 53 }, 89));
                string _0x0369c24d = _0xfc0656d8.Call<string>(_0x17dc8940._0x3fe00c49(new byte[10] { 163, 161, 176, 148, 165, 167, 175, 165, 163, 161 }, 196));
                _0xfc0656d8.Call<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[11] { 67, 70, 70, 97, 67, 86, 71, 69, 77, 80, 91 }, 34), _0x17dc8940._0x3fe00c49(new byte[33] { 165, 170, 160, 182, 171, 173, 160, 234, 173, 170, 176, 161, 170, 176, 234, 167, 165, 176, 161, 163, 171, 182, 189, 234, 134, 150, 139, 147, 151, 133, 134, 136, 129 }, 196));
                _0xfc0656d8.Call<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[11] { 203, 220, 212, 214, 207, 220, 252, 193, 205, 203, 216 }, 185), _0x17dc8940._0x3fe00c49(new byte[20] { 208, 192, 221, 197, 193, 215, 192, 237, 212, 211, 222, 222, 208, 211, 209, 217, 237, 199, 192, 222 }, 178));
                if (_0xfc0656d8.Call<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[15] { 59, 44, 58, 38, 37, 63, 44, 8, 42, 61, 32, 63, 32, 61, 48 }, 73), _0xd5b0b495) != null)
                {
                    WLog(_0x17dc8940._0x3fe00c49(new byte[24] { 216, 243, 233, 244, 246, 254, 215, 242, 240, 254, 187, 244, 235, 254, 245, 187, 242, 245, 239, 254, 245, 239, 161, 187 }, 155) + _0xa7da5e96);
                    _0xfc0656d8.Call<AndroidJavaObject>(_0x17dc8940._0x3fe00c49(new byte[8] { 250, 255, 255, 221, 247, 250, 252, 232 }, 155), 0x10000000);
                    _0xaa319715.Call(_0x17dc8940._0x3fe00c49(new byte[13] { 23, 16, 5, 22, 16, 37, 7, 16, 13, 18, 13, 16, 29 }, 100), _0xfc0656d8);
                    return true;
                }

                if (_0x32d49445(_0x0369c24d))
                    return true;
                if (!string.IsNullOrEmpty(_0x24c41b1c))
                {
                    WLog(_0x17dc8940._0x3fe00c49(new byte[28] { 115, 88, 66, 95, 93, 85, 124, 89, 91, 85, 16, 89, 94, 68, 85, 94, 68, 16, 86, 81, 92, 92, 82, 81, 83, 91, 10, 16 }, 48) + _0x24c41b1c);
                    if (_0x7f5ab1dd(_0x24c41b1c))
                        return _0x0d164da4(_0x24c41b1c, _0x0369c24d);
                    return _0xff01e7c1(_0x24c41b1c);
                }

                WLog(_0x17dc8940._0x3fe00c49(new byte[30] { 246, 221, 199, 218, 216, 208, 249, 220, 222, 208, 149, 220, 219, 193, 208, 219, 193, 149, 219, 218, 149, 221, 212, 219, 209, 217, 208, 199, 143, 149 }, 181) + _0xa7da5e96);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x17dc8940._0x3fe00c49(new byte[26] { 61, 22, 12, 17, 19, 27, 50, 23, 21, 27, 94, 23, 16, 10, 27, 16, 10, 94, 24, 31, 23, 18, 27, 26, 68, 94 }, 126) + e.Message);
            return true;
        }
    }

    private string _0x6a187cf7 = "";
    private bool _0x005f5c27 = false;
    private RectTransform _0x7c830429;
    private string _0xe493ae58()
    {
        float _0xde70107b = Time.realtimeSinceStartup;
        if (_0xde70107b < 0f)
            _0xde70107b = 0f;
        int _0x65cadb65 = (int)(_0xde70107b * 1000f);
        int _0xc8e04e17 = _0x65cadb65 / 60000;
        int _0x3f6b29a4 = (_0x65cadb65 / 1000) % 60;
        int _0x1e80a81c = _0x65cadb65 % 1000;
        return string.Format(_0x17dc8940._0x3fe00c49(new byte[21] { 180, 255, 245, 255, 255, 178, 245, 180, 254, 245, 255, 255, 178, 245, 180, 253, 245, 255, 255, 255, 178 }, 207), _0xc8e04e17, _0x3f6b29a4, _0x1e80a81c);
    }

    private Canvas _0xa3d41345()
    {
        if (_0xa8a14f6a != null)
            return _0xa8a14f6a;
        var _0xc4cf2445 = gameObject.GetComponentInChildren<Canvas>();
        if (_0xc4cf2445 == null)
        {
            var _0xb46314d0 = new GameObject(_0x17dc8940._0x3fe00c49(new byte[6] { 52, 22, 25, 1, 22, 4 }, 119), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0xc4cf2445 = _0xb46314d0.GetComponent<Canvas>();
            _0xc4cf2445.transform.SetParent(transform, false);
            _0xc4cf2445.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0xa8a14f6a = _0xc4cf2445;
        return _0xa8a14f6a;
    }

    private void OnApplicationPause(bool _0xb9255be4)
    {
        isApplicationPause = _0xb9255be4;
    }

    private bool _0x87d97cdf()
    {
        var _0x67f014e5 = _0xae5aaeb7();
        if (_0x67f014e5 == null)
            return false;
        WLog(_0x17dc8940._0x3fe00c49(new byte[31] { 127, 86, 69, 83, 64, 86, 69, 82, 23, 85, 86, 84, 92, 23, 26, 9, 23, 71, 88, 71, 66, 71, 23, 112, 88, 117, 86, 84, 92, 13, 23 }, 55) + _0x67f014e5.Id);
        _0x67f014e5.GoBack();
        return true;
    }

    internal Vector2 lastSize = Vector2.zero;
    internal Rect lastSafe = Rect.zero;
    private void _0xdfc5581a(UniWebView _0x5f421594)
    {
        if (_0x22fbc21c)
            return;
        _0x22fbc21c = true;
        _0x5f421594.AddUrlScheme(_0x17dc8940._0x3fe00c49(new byte[2] { 81, 66 }, 37));
        _0x5f421594.AddUrlScheme(_0x17dc8940._0x3fe00c49(new byte[6] { 191, 184, 162, 179, 184, 162 }, 214));
        _0x5f421594.AddUrlScheme(_0x17dc8940._0x3fe00c49(new byte[6] { 15, 3, 16, 9, 7, 22 }, 98));
        _0x5f421594.OnMessageReceived += (_0x12a41c42, _0x6417da18) =>
        {
            if (TryOpenExternalLikeChrome(_0x6417da18.RawMessage))
            {
                _0xdc3d2bea(false);
                return;
            }
        };
        _0x5f421594.RegisterShouldHandleRequest(_0x3708ca50 =>
        {
            string _0x5a3a282e = _0x3708ca50 != null ? _0x3708ca50.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x5a3a282e))
                return true;
            WLog(_0x17dc8940._0x3fe00c49(new byte[21] { 69, 126, 121, 99, 122, 114, 94, 119, 120, 114, 122, 115, 68, 115, 103, 99, 115, 101, 98, 44, 54 }, 22) + _0x5a3a282e);
            if (TryOpenExternalLikeChrome(_0x5a3a282e))
            {
                _0xdc3d2bea(false);
                return false;
            }

            if (_0x3708ca50 != null && _0x3708ca50.IsMainFrame && IsGoogleAuthFlowUrl(_0x5a3a282e) && !_0x164ea5ca)
            {
                WLog(_0x17dc8940._0x3fe00c49(new byte[62] { 125, 81, 89, 94, 16, 103, 85, 82, 102, 89, 85, 71, 16, 84, 85, 68, 85, 83, 68, 85, 84, 16, 119, 95, 95, 87, 92, 85, 16, 81, 69, 68, 88, 16, 101, 98, 124, 16, 29, 14, 16, 66, 85, 92, 95, 81, 84, 16, 71, 89, 68, 88, 16, 119, 95, 95, 87, 92, 85, 16, 101, 113 }, 48));
                _0x164ea5ca = true;
                _0xdc3d2bea(true);
                _0x3b4eca97.SetUserAgent(_0x9d5b3ee4());
                _0x3b4eca97.Load(_0x5a3a282e);
                return false;
            }

            return true;
        });
        _0x5f421594.OnLoadingErrorReceived += (_0x12a41c42, _0x2f3cf62c, _0x6417da18, _0x549a0364) =>
        {
            WLog(_0x17dc8940._0x3fe00c49(new byte[25] { 167, 139, 131, 132, 202, 189, 143, 136, 188, 131, 143, 157, 202, 175, 152, 152, 133, 152, 208, 202, 137, 133, 142, 143, 215 }, 234) + _0x2f3cf62c + _0x17dc8940._0x3fe00c49(new byte[9] { 58, 119, 127, 105, 105, 123, 125, 127, 39 }, 26) + _0x6417da18);
            string _0x8693db20 = GetFailingUrl(_0x549a0364);
            if (string.IsNullOrEmpty(_0x8693db20) || IsAboutBlank(_0x8693db20))
                return;
            _ = _0x16e7042d(_0x17dc8940._0x3fe00c49(new byte[8] { 23, 22, 63, 5, 18, 18, 15, 18 }, 96));
            WLog(_0x17dc8940._0x3fe00c49(new byte[45] { 71, 107, 99, 100, 42, 93, 111, 104, 92, 99, 111, 125, 42, 108, 107, 99, 102, 99, 100, 109, 42, 95, 88, 70, 42, 39, 52, 42, 101, 122, 111, 100, 42, 111, 114, 126, 111, 120, 100, 107, 102, 102, 115, 48, 42 }, 10) + _0x8693db20);
            StopCurrentFailedLoad(_0x12a41c42);
            _0x43354825(_0x8693db20);
        };
        _0x5f421594.OnPageStarted += (_0x12a41c42, _0x63902397) =>
        {
            _0x65ee6443 = 0;
            if (_0xe2c63157 && IsAboutBlank(_0x63902397))
            {
                WLog(_0x17dc8940._0x3fe00c49(new byte[27] { 254, 220, 203, 217, 207, 220, 195, 142, 207, 204, 193, 219, 218, 148, 204, 194, 207, 192, 197, 142, 221, 218, 207, 220, 218, 203, 202 }, 174));
                return;
            }

            WLog(_0x17dc8940._0x3fe00c49(new byte[29] { 223, 243, 251, 252, 178, 197, 247, 240, 196, 251, 247, 229, 178, 221, 252, 194, 243, 245, 247, 193, 230, 243, 224, 230, 247, 246, 168, 178, 185 }, 146) + (Time.realtimeSinceStartup - _0x6f0216df).ToString(_0x17dc8940._0x3fe00c49(new byte[5] { 107, 117, 107, 107, 107 }, 91)) + _0x17dc8940._0x3fe00c49(new byte[2] { 213, 134 }, 166) + _0x63902397);
            if (TryOpenExternalLikeChrome(_0x63902397))
            {
                StopCurrentFailedLoad(_0x12a41c42);
                return;
            }

            if (ContainsIgnoreCase(_0x63902397, _0x17dc8940._0x3fe00c49(new byte[8] { 51, 62, 62, 54, 121, 54, 39, 39 }, 87)) || ContainsIgnoreCase(_0x63902397, _0x17dc8940._0x3fe00c49(new byte[15] { 126, 111, 119, 32, 121, 103, 106, 105, 107, 122, 32, 108, 98, 97, 105 }, 14)) || _0x63902397.StartsWith(_0x17dc8940._0x3fe00c49(new byte[25] { 164, 184, 184, 188, 191, 246, 227, 227, 174, 188, 171, 160, 163, 174, 173, 160, 170, 173, 186, 226, 160, 165, 186, 169, 227 }, 204), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x12a41c42);
                OpenUrlExternally(_0x63902397);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x63902397))
            {
                _0xdc3d2bea(true);
                WLog(_0x17dc8940._0x3fe00c49(new byte[41] { 247, 223, 223, 215, 220, 213, 144, 209, 197, 196, 216, 144, 214, 220, 223, 199, 144, 212, 213, 196, 213, 211, 196, 213, 212, 144, 157, 142, 144, 219, 213, 213, 192, 144, 198, 217, 195, 217, 210, 220, 213 }, 176));
                return;
            }

            _0x5be055d5 = true;
            _0xdc3d2bea(true);
            WLog(_0x17dc8940._0x3fe00c49(new byte[43] { 107, 89, 94, 106, 85, 89, 75, 28, 80, 83, 93, 88, 85, 82, 91, 19, 78, 89, 88, 85, 78, 89, 95, 72, 85, 82, 91, 28, 17, 2, 28, 87, 89, 89, 76, 28, 74, 85, 79, 85, 94, 80, 89 }, 60));
        };
        _0x5f421594.OnPageCommitted += (_0x12a41c42, _0x63902397) =>
        {
            if (_0xe2c63157 && IsAboutBlank(_0x63902397))
                return;
            WLog(_0x17dc8940._0x3fe00c49(new byte[31] { 153, 181, 189, 186, 244, 131, 177, 182, 130, 189, 177, 163, 244, 155, 186, 132, 181, 179, 177, 151, 187, 185, 185, 189, 160, 160, 177, 176, 238, 244, 255 }, 212) + (Time.realtimeSinceStartup - _0x6f0216df).ToString(_0x17dc8940._0x3fe00c49(new byte[5] { 79, 81, 79, 79, 79 }, 127)) + _0x17dc8940._0x3fe00c49(new byte[2] { 131, 208 }, 240) + _0x63902397);
            if (!firstLoadShown && IsHttpUrl(_0x63902397))
            {
                firstLoadShown = true;
                _0x5be055d5 = false;
                _0xdc3d2bea(false);
                _0x94951a24();
                _0x5fd33bef();
                _0x12a41c42.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x16e7042d(_0x17dc8940._0x3fe00c49(new byte[9] { 230, 231, 206, 254, 225, 244, 255, 244, 245 }, 145));
                WLog(_0x17dc8940._0x3fe00c49(new byte[39] { 38, 10, 2, 5, 75, 60, 14, 9, 61, 2, 14, 28, 75, 24, 3, 4, 28, 5, 75, 4, 5, 75, 8, 4, 6, 6, 2, 31, 31, 14, 15, 75, 8, 4, 5, 31, 14, 5, 31 }, 107));
            }
        };
        _0x5f421594.OnPageProgressChanged += (_0x12a41c42, _0xced90d36) =>
        {
            if (_0xe2c63157)
                return;
            if (!firstLoadShown && _0xced90d36 >= 0.65f)
            {
                firstLoadShown = true;
                _0x5be055d5 = false;
                _0xdc3d2bea(false);
                _0x94951a24();
                _0x5fd33bef();
                _0x12a41c42.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x16e7042d(_0x17dc8940._0x3fe00c49(new byte[9] { 98, 99, 74, 122, 101, 112, 123, 112, 113 }, 21));
                WLog(_0x17dc8940._0x3fe00c49(new byte[32] { 180, 152, 144, 151, 217, 174, 156, 155, 175, 144, 156, 142, 217, 138, 145, 150, 142, 151, 217, 155, 128, 217, 137, 139, 150, 158, 139, 156, 138, 138, 195, 217 }, 249) + _0xced90d36);
            }
        };
        _0x5f421594.OnPageFinished += (_0x12a41c42, _0x2f3cf62c, _0x63902397) =>
        {
            if (_0xe2c63157 && IsAboutBlank(_0x63902397))
            {
                _0xe2c63157 = false;
                WLog(_0x17dc8940._0x3fe00c49(new byte[28] { 116, 86, 65, 83, 69, 86, 73, 4, 69, 70, 75, 81, 80, 30, 70, 72, 69, 74, 79, 4, 66, 77, 74, 77, 87, 76, 65, 64 }, 36));
                return;
            }

            WLog(_0x17dc8940._0x3fe00c49(new byte[24] { 177, 157, 149, 146, 220, 171, 153, 158, 170, 149, 153, 139, 220, 186, 149, 146, 149, 143, 148, 153, 152, 198, 220, 215 }, 252) + (Time.realtimeSinceStartup - _0x6f0216df).ToString(_0x17dc8940._0x3fe00c49(new byte[5] { 60, 34, 60, 60, 60 }, 12)) + _0x17dc8940._0x3fe00c49(new byte[7] { 255, 172, 239, 227, 232, 233, 177 }, 140) + _0x2f3cf62c + _0x17dc8940._0x3fe00c49(new byte[5] { 132, 209, 214, 200, 153 }, 164) + _0x63902397);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x5be055d5 = false;
                _0xdc3d2bea(false);
                _0x94951a24();
                _0x5fd33bef();
                _0x12a41c42.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x16e7042d(_0x17dc8940._0x3fe00c49(new byte[9] { 198, 199, 238, 222, 193, 212, 223, 212, 213 }, 177));
                WLog(_0x17dc8940._0x3fe00c49(new byte[33] { 12, 32, 40, 47, 97, 22, 36, 35, 23, 40, 36, 54, 97, 39, 40, 51, 50, 53, 97, 45, 46, 32, 37, 97, 34, 46, 44, 49, 45, 36, 53, 36, 37 }, 65));
            }
            else if (_0x5be055d5)
            {
                _0x5be055d5 = false;
                _0xdc3d2bea(false);
                _0x12a41c42.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x17dc8940._0x3fe00c49(new byte[40] { 187, 151, 159, 152, 214, 161, 147, 148, 160, 159, 147, 129, 214, 165, 158, 153, 129, 214, 151, 144, 130, 147, 132, 214, 154, 153, 151, 146, 159, 152, 145, 214, 144, 159, 152, 159, 133, 158, 147, 146 }, 246));
            }
            else
            {
                _0xdc3d2bea(false);
            }

            if (_0x164ea5ca && !IsGoogleAuthFlowUrl(_0x63902397) && !IsGoogleAuthFlowUrl(_0x63902397))
            {
                WLog(_0x17dc8940._0x3fe00c49(new byte[48] { 105, 65, 65, 73, 66, 75, 14, 79, 91, 90, 70, 14, 93, 75, 75, 67, 93, 14, 72, 71, 64, 71, 93, 70, 75, 74, 14, 3, 16, 14, 92, 75, 93, 90, 65, 92, 75, 14, 74, 75, 72, 79, 91, 66, 90, 14, 123, 111 }, 46));
                _0x164ea5ca = false;
                _0x3b4eca97.SetUserAgent("");
            }
        };
        _0x5f421594.OnShouldClose += _0x12a41c42 =>
        {
            WLog(_0x17dc8940._0x3fe00c49(new byte[41] { 33, 46, 31, 9, 14, 39, 90, 55, 27, 19, 20, 90, 45, 31, 24, 44, 19, 31, 13, 90, 53, 20, 41, 18, 21, 15, 22, 30, 57, 22, 21, 9, 31, 90, 19, 20, 12, 21, 17, 31, 30 }, 122));
            _0x260890d7();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x5f421594.SetPopupPageEventEnabled(true);
        bool _0xdde1a49b = false;
        bool _0xd9c69881 = false;
        _0x5f421594.OnMultipleWindowOpened += (_0x12a41c42, _0x6c057c4b) =>
        {
            _0x12a41c42.ScrollTo(0, 0, false);
            WLog(_0x17dc8940._0x3fe00c49(new byte[43] { 166, 169, 152, 142, 137, 160, 221, 176, 156, 148, 147, 221, 170, 152, 159, 171, 148, 152, 138, 221, 176, 136, 145, 137, 148, 141, 145, 152, 170, 148, 147, 153, 146, 138, 221, 178, 141, 152, 147, 152, 153, 199, 221 }, 253) + _0x6c057c4b);
            var _0x5b8ef7d3 = _0x5f421594.GetPopupWindow(_0x6c057c4b);
            if (_0x5b8ef7d3 == null)
                return;
            _0xfbf86806.Add(_0x5b8ef7d3);
            Debug.Log($"[Test] Popup ID: {_0x5b8ef7d3.Id}");
            _0x5b8ef7d3.OnPageStarted += (_0xceda8b0b, _0x63902397) =>
            {
                WLog(_0x17dc8940._0x3fe00c49(new byte[36] { 200, 199, 246, 224, 231, 206, 179, 195, 252, 227, 230, 227, 179, 196, 246, 241, 197, 250, 246, 228, 179, 220, 253, 195, 242, 244, 246, 192, 231, 242, 225, 231, 246, 247, 169, 179 }, 147) + _0x63902397);
                _0x65ee6443 = 0;
                if (string.IsNullOrEmpty(_0x63902397) || IsAboutBlank(_0x63902397))
                    return;
                if (IsGoogleAuthFlowUrl(_0x63902397))
                {
                    WLog(_0x17dc8940._0x3fe00c49(new byte[57] { 18, 29, 44, 58, 61, 20, 105, 25, 38, 57, 60, 57, 105, 14, 38, 38, 46, 37, 44, 105, 40, 60, 61, 33, 105, 47, 37, 38, 62, 105, 100, 119, 105, 58, 57, 38, 38, 47, 105, 14, 38, 38, 46, 37, 44, 105, 10, 33, 59, 38, 36, 44, 105, 28, 8, 115, 105 }, 73) + _0x63902397);
                    _0xdde1a49b = false;
                    _0xf7a53bf4();
                    if (_0xceda8b0b != null && _0xceda8b0b.IsAlive)
                        _0xceda8b0b.EvaluateJavaScript(_0xf6183f1e());
                    return;
                }

                if (_0x3b4eca97 == null)
                    return;
                if (!_0xdde1a49b)
                {
                    _0xdde1a49b = true;
                    _0x3b4eca97.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x17dc8940._0x3fe00c49(new byte[39] { 205, 194, 243, 229, 226, 203, 182, 198, 249, 230, 227, 230, 182, 247, 230, 230, 250, 239, 182, 193, 255, 248, 242, 249, 225, 229, 182, 242, 243, 229, 253, 226, 249, 230, 182, 195, 215, 172, 182 }, 150) + _0x63902397);
                }

                if (_0xceda8b0b != null && _0xceda8b0b.IsAlive)
                    _0xceda8b0b.EvaluateJavaScript(_0x92ab4f1a());
                if (!_0xd9c69881 && _0xceda8b0b != null && _0xceda8b0b.IsAlive && IsHttpUrl(_0x63902397))
                {
                    _0xd9c69881 = true;
                }
            };
            _0x5b8ef7d3.OnPageFinished += (_0xceda8b0b, _0x549a0364) =>
            {
                string _0x37c31c8e = _0x549a0364 != null ? _0x549a0364.data : string.Empty;
                WLog(_0x17dc8940._0x3fe00c49(new byte[35] { 53, 58, 11, 29, 26, 51, 78, 62, 1, 30, 27, 30, 78, 57, 11, 12, 56, 7, 11, 25, 78, 40, 7, 0, 7, 29, 6, 11, 10, 84, 78, 27, 28, 2, 83 }, 110) + _0x37c31c8e);
                if (_0xceda8b0b == null || !_0xceda8b0b.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x37c31c8e))
                {
                    _0xf7a53bf4();
                    _0xceda8b0b.EvaluateJavaScript(_0xf6183f1e());
                    return;
                }

                if (!_0xdde1a49b)
                    return;
                _0xceda8b0b.EvaluateJavaScript(_0x92ab4f1a());
            };
        };
        _0x5f421594.OnMultipleWindowClosed += (_0x12a41c42, _0x6c057c4b) =>
        {
            _0xfbf86806.RemoveAll(_0x8c978792 => _0x8c978792 == null || _0x8c978792.Id == _0x6c057c4b || !_0x8c978792.IsAlive);
            _0xdc3d2bea(false);
            if (_0xfbf86806.Count == 0 && _0x3b4eca97 != null)
            {
                _0xdde1a49b = false;
                _0xd9c69881 = false;
                _0x67b9b47a();
            }

            WLog(_0x17dc8940._0x3fe00c49(new byte[43] { 240, 255, 206, 216, 223, 246, 139, 230, 202, 194, 197, 139, 252, 206, 201, 253, 194, 206, 220, 139, 230, 222, 199, 223, 194, 219, 199, 206, 252, 194, 197, 207, 196, 220, 139, 232, 199, 196, 216, 206, 207, 145, 139 }, 171) + _0x6c057c4b);
        };
        _0x5f421594.RegisterOnRequestMediaCapturePermission(_0x3708ca50 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private string _0xc6dea4e9 = "";
    private int _0x86077119 = 5, _0x8edc16f9 = 5, _0x98dfedd8 = 5, _0x26f82651 = 5;
    private IEnumerator _0x4c758732(IEnumerator _0x6e0fd6ec, TaskCompletionSource<bool> _0x0beb85bb)
    {
        yield return _0x6e0fd6ec;
        _0x0beb85bb.SetResult(true);
    }

    private Action _0x4cbd40f5;
    internal void Update()
    {
        if (_0x3b4eca97 == null)
            return;
        if (_0x6a4e9c70())
            _0x260890d7();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x5fd33bef();
        if (_0x005f5c27 && _0x7c830429 != null)
            _0x7c830429.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private int _0x65ee6443 = 0;
    internal string _0x02f1bdb8(string _0xd2995f41)
    {
        int _0x58fe04a9 = _0xd2995f41.IndexOf(_0x17dc8940._0x3fe00c49(new byte[3] { 168, 165, 252 }, 193), StringComparison.OrdinalIgnoreCase);
        if (_0x58fe04a9 < 0)
            return null;
        string _0xc89a1f03 = _0xd2995f41.Substring(_0x58fe04a9 + 3);
        int _0xfbf468f2 = _0xc89a1f03.IndexOf('&');
        return _0xfbf468f2 >= 0 ? _0xc89a1f03.Substring(0, _0xfbf468f2) : _0xc89a1f03;
    }

    private string _0xcb802ecc = "";
    private void _0xdaf5b428(string _0xc92ee4af)
    {
        _0x7e7c2d11();
        StartCoroutine(_0x9817d4eb(_0xc92ee4af));
    }

    private IEnumerator _0x430fd6c6()
    {
        yield return _0xc20d6343(Permission.Camera);
    }

    private string _0x3b7d1bdf = "";
    private void _0x4692018d(UniWebView _0xd22a8b85)
    {
        _0xd22a8b85.BackgroundColor = Color.clear;
        _0xd22a8b85.SetSupportMultipleWindows(true, true);
        _0xd22a8b85.SetBackButtonEnabled(false);
        _0x3b4eca97.SetUserAgent(_0x9d5b3ee4());
    }

    private string _0x54c08599 = "";
    private bool OpenUrlExternally(string _0x7d011600)
    {
        return _0xff01e7c1(_0x7d011600);
    }

    internal bool isApplicationPause = false;
    private void _0xdc3d2bea(bool _0xd8dbcd5b)
    {
        _0x6d65c73b();
        _0x3c6938f5.SetActive(_0xd8dbcd5b);
        _0x005f5c27 = _0xd8dbcd5b;
        if (_0xd8dbcd5b)
        {
            _0x3c6938f5.transform.SetAsLastSibling();
            if (_0x7c830429 != null)
                _0x7c830429.localRotation = Quaternion.identity;
        }
    }

    private void _0x94951a24()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private string _0xadb376dc;
    private bool _0x9419421a = false;
    private string _0xe8b79f8a = "";
    private string _0x17bd0834 = "";
    private void Awake()
    {
        if (_0xba8b03bb != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0xba8b03bb = gameObject.GetComponent<_0xbd87a78f>();
        DontDestroyOnLoad(gameObject);
        _0xcb802ecc = _0xf7a63d2e = _0x55e88141 = "";
        _0xc4c119be = "";
        _0xd1cbb3db = false;
    }

    private void WLog(string _0xd7446b9a)
    {
#if B_LOGS
        {
            Debug.Log(_0x17dc8940._0x3fe00c49(new byte[7] { 224, 239, 222, 200, 207, 230, 155 }, 187) + _0xd7446b9a);
        }
#endif
    }

    private bool _0x06c2a066 = false;
    private void _0xd069d43d()
    {
        if (_0x2d637911)
        {
            WLog(_0x17dc8940._0x3fe00c49(new byte[18] { 73, 116, 101, 120, 44, 109, 96, 126, 105, 109, 104, 117, 44, 127, 100, 99, 123, 98 }, 12));
            return;
        }

        _0xdc3d2bea(false);
        WLog(_0x17dc8940._0x3fe00c49(new byte[46] { 109, 65, 73, 78, 0, 119, 69, 66, 118, 73, 69, 87, 0, 112, 85, 83, 72, 0, 110, 79, 84, 73, 70, 73, 67, 65, 84, 73, 79, 78, 0, 8, 72, 65, 82, 68, 87, 65, 82, 69, 0, 66, 65, 67, 75, 9 }, 32));
        ++_0x65ee6443;
        _0xe6522d3c();
        if (_0x65ee6443 <= 1)
            return;
        if (_0xa3cd5859())
        {
            WLog(_0x17dc8940._0x3fe00c49(new byte[37] { 169, 148, 133, 152, 204, 159, 135, 133, 156, 156, 137, 136, 204, 193, 210, 204, 156, 131, 156, 153, 156, 159, 204, 159, 152, 133, 128, 128, 204, 131, 156, 137, 130, 137, 136, 214, 204 }, 236) + _0xfbf86806.Count);
            return;
        }

        Application.Quit();
    }

    private string _0x09689c98 = "";
    private string _0xfd84ae6b = "";
    internal bool IsHttpUrl(string _0xba0e96b7)
    {
        if (string.IsNullOrEmpty(_0xba0e96b7))
            return false;
        return _0xba0e96b7.StartsWith(_0x17dc8940._0x3fe00c49(new byte[7] { 156, 128, 128, 132, 206, 219, 219 }, 244), StringComparison.OrdinalIgnoreCase) || _0xba0e96b7.StartsWith(_0x17dc8940._0x3fe00c49(new byte[8] { 45, 49, 49, 53, 54, 127, 106, 106 }, 69), StringComparison.OrdinalIgnoreCase);
    }

    internal bool firstLoadShown = false;
    private ApplicationInstallMode _0xb8b65304 = ApplicationInstallMode.Unknown;
    internal Button _0x9cb9e0dc(string _0xa16bb1c6, Transform _0x6c19ed2a)
    {
        var _0xfa0c5774 = new GameObject(_0xa16bb1c6 + _0x17dc8940._0x3fe00c49(new byte[3] { 21, 35, 57 }, 87), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x885d8217 = _0xfa0c5774.GetComponent<RectTransform>();
        _0x885d8217.SetParent(_0x6c19ed2a, false);
        var _0x71eafc97 = _0xfa0c5774.GetComponent<Image>();
        _0x71eafc97.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x51fa7575 = _0xfa0c5774.GetComponent<Button>();
        var _0x3b4eab0e = _0x51fa7575.colors;
        _0x3b4eab0e.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x3b4eab0e.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x51fa7575.colors = _0x3b4eab0e;
        var _0x4bcc688e = new GameObject(_0x17dc8940._0x3fe00c49(new byte[4] { 55, 6, 27, 23 }, 99), typeof(RectTransform), typeof(Text));
        var _0x43c6a14e = _0x4bcc688e.GetComponent<RectTransform>();
        _0x43c6a14e.SetParent(_0xfa0c5774.transform, false);
        _0x43c6a14e.anchorMin = Vector2.zero;
        _0x43c6a14e.anchorMax = Vector2.one;
        _0x43c6a14e.offsetMin = _0x43c6a14e.offsetMax = Vector2.zero;
        var _0xa31d267e = _0x4bcc688e.GetComponent<Text>();
        _0xa31d267e.text = _0xa16bb1c6;
        _0xa31d267e.alignment = TextAnchor.MiddleCenter;
        _0xa31d267e.color = Color.black;
        _0xa31d267e.font = Resources.GetBuiltinResource<Font>(_0x17dc8940._0x3fe00c49(new byte[9] { 68, 119, 108, 100, 105, 43, 113, 113, 99 }, 5));
        _0xa31d267e.fontSize = 28;
        WLog(_0x17dc8940._0x3fe00c49(new byte[14] { 1, 48, 39, 35, 54, 39, 0, 55, 54, 54, 45, 44, 98, 101 }, 66) + _0xa16bb1c6 + _0x17dc8940._0x3fe00c49(new byte[1] { 222 }, 249));
        return _0x51fa7575;
    }

    private static readonly string WindowsDesktopUserAgent = _0x17dc8940._0x3fe00c49(new byte[111] { 186, 152, 141, 158, 155, 155, 150, 216, 194, 217, 199, 215, 223, 160, 158, 153, 147, 152, 128, 132, 215, 185, 163, 215, 198, 199, 217, 199, 204, 215, 160, 158, 153, 193, 195, 204, 215, 143, 193, 195, 222, 215, 182, 135, 135, 155, 146, 160, 146, 149, 188, 158, 131, 216, 194, 196, 192, 217, 196, 193, 215, 223, 188, 191, 163, 186, 187, 219, 215, 155, 158, 156, 146, 215, 176, 146, 148, 156, 152, 222, 215, 180, 159, 133, 152, 154, 146, 216, 198, 197, 199, 217, 199, 217, 199, 217, 199, 215, 164, 150, 145, 150, 133, 158, 216, 194, 196, 192, 217, 196, 193 }, 247);
    internal bool IsGoogleAuthFlowUrl(string _0xba568e66)
    {
        if (string.IsNullOrEmpty(_0xba568e66))
            return false;
        return _0xba568e66.IndexOf(_0x17dc8940._0x3fe00c49(new byte[19] { 36, 38, 38, 42, 48, 43, 49, 54, 107, 34, 42, 42, 34, 41, 32, 107, 38, 42, 40 }, 69), StringComparison.OrdinalIgnoreCase) >= 0 || _0xba568e66.IndexOf(_0x17dc8940._0x3fe00c49(new byte[16] { 243, 241, 241, 253, 231, 252, 230, 225, 188, 245, 253, 253, 245, 254, 247, 188 }, 146), StringComparison.OrdinalIgnoreCase) >= 0 || _0xba568e66.IndexOf(_0x17dc8940._0x3fe00c49(new byte[21] { 11, 3, 3, 11, 0, 9, 25, 31, 9, 30, 15, 3, 2, 24, 9, 2, 24, 66, 15, 3, 1 }, 108), StringComparison.OrdinalIgnoreCase) >= 0 || _0xba568e66.IndexOf(_0x17dc8940._0x3fe00c49(new byte[11] { 41, 61, 58, 47, 58, 39, 45, 96, 45, 33, 35 }, 78), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0xba391fcf = "";
    private string _0x5148cb16 = "";
    private IEnumerator _0x24df196d(Dictionary<string, object> _0x96eeaf2f)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x17dc8940._0x3fe00c49(new byte[30] { 71, 72, 121, 111, 104, 65, 60, 90, 121, 104, 127, 116, 60, 89, 100, 104, 110, 125, 60, 76, 105, 111, 116, 60, 88, 125, 104, 125, 38, 60 }, 28) + string.Join(_0x17dc8940._0x3fe00c49(new byte[1] { 5 }, 12), _0x96eeaf2f));
#endif
            }
        }

        string _0xf45be016 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x96eeaf2f != null && _0x96eeaf2f.TryGetValue(_0x17dc8940._0x3fe00c49(new byte[16] { 130, 131, 152, 133, 138, 133, 143, 141, 152, 133, 131, 130, 168, 141, 152, 141 }, 236), out var raw))
        {
            try
            {
                var _0x588d3a94 = raw?.ToString();
                var _0xf6cf7a7f = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x588d3a94);
                if (_0xf6cf7a7f != null && _0xf6cf7a7f.TryGetValue(_0x17dc8940._0x3fe00c49(new byte[6] { 125, 107, 96, 106, 103, 106 }, 14), out var val))
                {
                    _0xf45be016 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x17dc8940._0x3fe00c49(new byte[30] { 136, 135, 182, 160, 167, 243, 131, 166, 160, 187, 142, 243, 153, 128, 156, 157, 243, 163, 178, 161, 160, 182, 243, 182, 161, 161, 188, 161, 233, 243 }, 211) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0xf45be016) && _0x96eeaf2f != null && _0x96eeaf2f.TryGetValue(_0x17dc8940._0x3fe00c49(new byte[6] { 23, 1, 10, 0, 13, 0 }, 100), out var lab))
        {
            _0xf45be016 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x17dc8940._0x3fe00c49(new byte[38] { 167, 168, 153, 143, 136, 220, 172, 137, 143, 148, 161, 220, 186, 153, 136, 159, 148, 153, 152, 220, 143, 153, 146, 152, 149, 152, 220, 154, 142, 147, 145, 220, 150, 143, 147, 146, 198, 220 }, 252) + _0xf45be016);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0xf45be016))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x17dc8940._0x3fe00c49(new byte[38] { 9, 6, 55, 33, 38, 114, 2, 39, 33, 58, 15, 114, 5, 51, 59, 38, 114, 38, 61, 114, 61, 34, 55, 60, 114, 37, 59, 38, 58, 114, 33, 55, 60, 54, 59, 54, 104, 114 }, 82) + _0xf45be016);
            }
#endif
        }

        _0xf6236ba3 = _0xf45be016;
        yield return new WaitUntil(() => _0xd1cbb3db);
        var _0xf25a65fb = _0x83ba6443(2, 100);
        yield return new WaitUntil(() => _0xf25a65fb.IsCompleted);
        string _0x00d8890b = _0xf25a65fb.Result;
        if (!string.IsNullOrEmpty(_0x00d8890b))
        {
            string _0xe143b248 = _0x19e58c9c(_0x00d8890b, _0xf45be016);
            {
#if B_LOGS
                Debug.Log(_0x17dc8940._0x3fe00c49(new byte[33] { 63, 48, 1, 23, 16, 68, 52, 17, 23, 12, 57, 68, 54, 1, 8, 11, 5, 0, 68, 51, 1, 6, 50, 13, 1, 19, 68, 19, 13, 16, 12, 94, 68 }, 100) + _0xe143b248);
#endif
            }

            _0x3b4eca97.Load(_0xe143b248);
        }
    }

    private void StopCurrentFailedLoad(UniWebView _0x9d8dc69a)
    {
        _0xdc3d2bea(false);
        if (_0x9d8dc69a == null)
            return;
        _0x9d8dc69a.Stop();
        if (_0x9d8dc69a.CanGoBack)
            _0x9d8dc69a.GoBack();
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0xcf33aa56()
    {
        var _0x36948208 = _0x17dc8940._0x3fe00c49(new byte[40] { 17, 13, 13, 9, 10, 67, 86, 86, 14, 14, 14, 87, 26, 21, 22, 12, 29, 31, 21, 24, 11, 28, 87, 26, 22, 20, 86, 26, 29, 23, 84, 26, 30, 16, 86, 13, 11, 24, 26, 28 }, 121);
        using (UnityWebRequest _0xf7bd47f9 = UnityWebRequest.Get(_0x36948208))
        {
            await _0xf7bd47f9.SendWebRequest();
            string[] _0x23cf4cec = _0xf7bd47f9.downloadHandler.text.Split('\n');
            foreach (string _0xd5fe49c8 in _0x23cf4cec)
            {
                if (_0xd5fe49c8.StartsWith(_0x17dc8940._0x3fe00c49(new byte[3] { 181, 172, 225 }, 220)))
                {
                    string _0x18910979 = _0xd5fe49c8.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x18910979} from {_0x36948208}");
                        }
#endif
                    }

                    return _0x18910979;
                }
            }
        }

        return "";
    }

    public void _0x57af6bc3()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x17dc8940._0x3fe00c49(new byte[18] { 84, 91, 106, 124, 123, 82, 47, 67, 110, 122, 97, 108, 103, 47, 72, 110, 98, 106 }, 15));
#endif
        }

        _0x5d8952ef.Instance?._0xa7d5d502();
        _0x5bd4077c.Instance._0x1c0e34af(_0x56576ecc._0x7463064a.DEFAULT);
    }

    private async Task<bool> _0x5e1ffe1d()
    {
        _0x5d8952ef.Instance?._0x701812b3();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x24ba3e1f) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x17dc8940._0x3fe00c49(new byte[32] { 98, 109, 92, 74, 77, 100, 25, 108, 87, 80, 77, 64, 25, 105, 76, 74, 81, 25, 119, 86, 77, 80, 95, 80, 90, 88, 77, 80, 86, 87, 3, 25 }, 57) + string.Join(_0x17dc8940._0x3fe00c49(new byte[1] { 110 }, 103), _0x24ba3e1f));
                }
#endif
            }
        };
        try
        {
            _0xcb802ecc = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x17dc8940._0x3fe00c49(new byte[31] { 254, 241, 192, 214, 209, 248, 133, 227, 196, 204, 201, 192, 193, 133, 209, 202, 133, 194, 192, 209, 133, 213, 208, 214, 205, 133, 209, 202, 206, 192, 203 }, 165));
                }
#endif
            }

            _0xcb802ecc = "";
        }

        _0x06c2a066 = !string.IsNullOrEmpty(_0xcb802ecc);
        _0x22b4fe6f = _0xe493ae58();
        {
#if B_LOGS
            Debug.Log(_0x17dc8940._0x3fe00c49(new byte[25] { 60, 51, 2, 20, 19, 58, 71, 50, 9, 14, 19, 30, 71, 55, 18, 20, 15, 71, 51, 8, 12, 2, 9, 93, 71 }, 103) + _0xcb802ecc);
#endif
        }

        _0x5d8952ef.Instance?._0x991b3d12();
        return false;
    }

    private bool _0x2d637911 = false;
    private bool _0x5be055d5 = false;
    private string _0x22b4fe6f = "";
}

internal static class _0x17dc8940
{
    internal static string _0x3fe00c49(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}