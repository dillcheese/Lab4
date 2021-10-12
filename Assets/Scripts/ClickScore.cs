using System;
using UnityEngine;

public class ClickScore : MonoBehaviour
{
    public static event Action clicked;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("WOrk");

            ScoreText.Instance.useHealth(1);
            #region observer
            clicked?.Invoke();
            #endregion
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("WOrk");

        ScoreText.Instance.useHealth(1);
        # region observer
        clicked?.Invoke();
        # endregion
    }
}