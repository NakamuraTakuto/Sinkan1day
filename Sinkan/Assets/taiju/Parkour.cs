using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Parkour : MonoBehaviour
{
    /// <summary>¶‰EˆÚ“®‚·‚é—Í</summary>
    [SerializeField] float YmovePower = 5f;
    [SerializeField] float XmovePower = 5f;
    //   [SerializeField] Countdown3 Countdown3;
    Rigidbody2D m_rb = default;
    [SerializeField, Tooltip("…•½•ûŒü‚Ì“ü—Í’l")] float m_h;
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Šeí“ü—Í‚ğó‚¯æ‚é
        // “ü—Í‚ğó‚¯æ‚é
        m_h = Input.GetAxisRaw("Vertical");

        m_rb.velocity = new Vector2(XmovePower, YmovePower * m_h);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //         Countdown3.StylishgaugePlus();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        OnTriggerStay(other);
    }
}
