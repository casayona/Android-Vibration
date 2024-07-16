using UnityEngine;
using System.Runtime.InteropServices;
using AndroidNativeCore;

public class Android : MonoBehaviour
{
    private long[] vibratePattern = { 0, 100, 1000 };

    // iOS native plugin import
#if UNITY_IOS
    [DllImport("__Internal")]
    private static extern void _Vibrate();
#endif

    public void vibrate()
    {
#if UNITY_ANDROID
        Vibrator.Vibrate(500);
#elif UNITY_IOS
        _Vibrate();
#endif
    }

    public void vibratePatterns()
    {
#if UNITY_ANDROID
        Vibrator.Vibrate(vibratePattern, 0);
#endif
    }

    public void vibrateCancel()
    {
#if UNITY_ANDROID
        Vibrator.Cansel();
#endif
    }
}
