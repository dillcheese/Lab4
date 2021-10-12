using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    public int _health = 50;
    private Text _text;

    public static HealthText Instance { get; private set; }

    private void Awake()
    {
        _text = GetComponent<Text>();
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
        }
        Instance = this;
        if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void useHealth(int value)
    {
        _health -= value;
        _text.text = "Health: " + _health.ToString();
    }
}