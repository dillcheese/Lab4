using System;
using UnityEngine;

public class ClickHealth : MonoBehaviour
{
    public static event Action clicked;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Debug.Log("WOrk");
            rb.AddForce(Vector3.up * 8f, ForceMode.VelocityChange);
            HealthText.Instance.useHealth(1);

            #region observer

            clicked?.Invoke();

            #endregion observer
        }
    }
}