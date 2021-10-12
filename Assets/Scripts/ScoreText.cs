using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public int _score = 50;
    private Text _text;

    public static ScoreText Instance { get; private set; }

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
        _score -= value;
        _text.text = "Health: " + _score.ToString();
    }
}