using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Parkour : MonoBehaviour
{
    /// <summary>¶‰EˆÚ“®‚·‚é—Í</summary>
    [SerializeField] float YmovePower = 5f;
    [SerializeField] float XmovePower = 5f;
    [SerializeField] GameObject _actionPanel;
    [SerializeField] GameObject _cleartPanel;
    [SerializeField] GameObject _overPanel;
    bool _actionTrriger = false;
    //   [SerializeField] Countdown3 Countdown3;
    Rigidbody2D m_rb = default;
    Animator _anim;
    [SerializeField, Tooltip("…•½•ûŒü‚Ì“ü—Í’l")] float m_h;
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Šeí“ü—Í‚ğó‚¯æ‚é
        // “ü—Í‚ğó‚¯æ‚é
        m_h = Input.GetAxisRaw("Vertical");
        _anim.SetFloat("Speed", XmovePower);
        var xyPower = new Vector2(XmovePower, YmovePower * m_h);
        m_rb.velocity = xyPower;

        if (Input.GetKeyUp(KeyCode.Space) && _actionTrriger)
        {
            gameObject.GetComponent<Collider2D>().enabled = false;
            GetComponent<Jumping>().StartJump();
        }
        if(!_actionTrriger)
        {
            gameObject.GetComponent<Collider2D>().enabled = true;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            _overPanel.SetActive(true);
            gameObject.SetActive(false);
        }
        else if (collision.gameObject.tag == "Finish")
        {
            _cleartPanel.SetActive(true);
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            _actionTrriger = true;
            _actionPanel.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _actionTrriger = false;
        _actionPanel.SetActive(false);
    }
}
