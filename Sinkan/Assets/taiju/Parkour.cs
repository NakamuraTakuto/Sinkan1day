using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Parkour : MonoBehaviour
{
    /// <summary>���E�ړ������</summary>
    [SerializeField] float YmovePower = 5f;
    [SerializeField] float XmovePower = 5f;
    //   [SerializeField] Countdown3 Countdown3;
    Rigidbody2D m_rb = default;
    [SerializeField, Tooltip("���������̓��͒l")] float m_h;
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // �e����͂��󂯎��
        // ���͂��󂯎��
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
