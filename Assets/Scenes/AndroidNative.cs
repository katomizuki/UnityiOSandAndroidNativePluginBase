
using UnityEngine;
using UnityEngine.UI;
public class AndroidNative : MonoBehaviour
{
    private AndroidJavaObject _plugin;
    private const string PackageName = "com.example.mylibrary";
    private const string ClassName = "UnityAndroidPlugin";
    [SerializeField] private Text _text;
    
    void Start()
    {
       _plugin = new AndroidJavaObject($"{PackageName}.{ClassName}");
       var text = _plugin.Call<int>("ReturnInt") + "Android確認";
       _text.text = text;
       Debug.Log(text);
    }

    private void OnDestroy()
    {
       _plugin.Dispose();
       _plugin = null;
    }
}
