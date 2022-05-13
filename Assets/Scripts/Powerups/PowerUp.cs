using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class PowerUp : MonoBehaviour
{
    [SerializeField] private int m_coolDownDuration = 3;

    [SerializeField] private Image m_powerUpButton;

    private float m_currentCoolDown = 0; 

    protected bool m_isAvailable => m_currentCoolDown <= 0;

    private void Update()
    {


        if(m_currentCoolDown >= 0)
        {
            m_currentCoolDown -= Time.deltaTime;
            m_powerUpButton.fillAmount = 1 - m_currentCoolDown / m_coolDownDuration;

            
            

        }
    }

    public virtual void OnPowerUpClick()
    {
        // if m_isAcailabe falre, (Not True);
        if (!m_isAvailable) return;

        m_currentCoolDown = m_coolDownDuration;

    }


}
