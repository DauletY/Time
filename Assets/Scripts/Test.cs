using SM = System;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    private const string Format = "dd/MM/yyyy";
    public Text _now = null;
    public Text _time = null;

    private void OnEnable() => Camera.main.backgroundColor = Color.HSVToRGB(Random.Range(0, 1f), 1.3f, 0.1f);
    void Start() => DateNow();
    private void Update() => StartTime();
    public void DateNow() => _now.text = SM.DateTime.Now.ToString(Format);
    public void StartTime() => _time.text = string.Format("{0:HH:mm:ss tt}", SM.DateTime.Now);

}

