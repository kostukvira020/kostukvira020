using UnityEngine;

public class _0x77ebfb7d : MonoBehaviour
{
    public bool IsLevelIncrementOnWin;
    public bool IsSkipSplashEnabled;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsStoryEnabled;
    public bool IsLevelSelectorEnabled;
    public bool IsBestScoreEnabled;
    public bool IsCheckScoreEnabled;
    public bool IsTimerEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x77ebfb7d>();
            DontDestroyOnLoad(this.gameObject);
            this._0xf627da67();
        }
        else
        {
            this._0x374dd4ac();
            Destroy(this.gameObject);
        }
    }

    public static _0x77ebfb7d Instance;
    private void _0xf627da67()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    private void _0x374dd4ac()
    {
    }

    public bool IsTutorialEnabled;
}