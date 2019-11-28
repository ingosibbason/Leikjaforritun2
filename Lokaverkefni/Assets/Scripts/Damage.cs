using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    public GameObject player1; //Haraldur
    public GameObject player2; //Griðungur
    public GameObject player3; //Risi
    public GameObject player4; //Dreki
    public GameObject player5; //Fugl

    public int P1Life;
    public int P2Life;
    public int P3Life;
    public int P4Life;
    public int P5Life;

    public GameObject p1Wins;
    public GameObject pOtherWins;

    public GameObject[] p1Health;
    public GameObject[] pOtherHealth;

    //private Rigidbody2D theRB;

    void Start()
    {

        //theRB = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        
        if(P1Life <= 0)
        {
            player1.SetActive(false);
            pOtherWins.SetActive(true);
        }
        if(P2Life <= 0)
        {
            player2.SetActive(false);
            p1Wins.SetActive(true);
        }
        if(P3Life <= 0)
        {
            player3.SetActive(false);
            p1Wins.SetActive(true);
        }
        if(P4Life <= 0)
        {
            player4.SetActive(false);
            p1Wins.SetActive(true);
        }
        if(P5Life <= 0)
        {
            player5.SetActive(false);
            p1Wins.SetActive(true);
        }

    }
    public void HurtP1()
    {
        P1Life -= 1;

        for(int i = 0; i < p1Health.Length; i++)
        {
            if(P1Life > i)
            {
                p1Health[i].SetActive(true);
            } else {
                p1Health[i].SetActive(false);

            }
        }
    }
    public void HurtP2()
    {
        P2Life -= 1;

        for (int i = 0; i < pOtherHealth.Length; i++)
        {
            if (P2Life > i)
            {
                pOtherHealth[i].SetActive(true);
            }
            else
            {
                pOtherHealth[i].SetActive(false);

            }
        }

    }
    public void HurtP3()
    {
        P3Life -= 1;

        for (int i = 0; i < pOtherHealth.Length; i++)
        {
            if (P3Life > i)
            {
                pOtherHealth[i].SetActive(true);
            }
            else
            {
                pOtherHealth[i].SetActive(false);

            }
        }

    }
    public void HurtP4()
    {
        P4Life -= 1;

        for (int i = 0; i < pOtherHealth.Length; i++)
        {
            if (P4Life > i)
            {
                pOtherHealth[i].SetActive(true);
            }
            else
            {
                pOtherHealth[i].SetActive(false);

            }
        }

    }
    public void HurtP5()
    {
        P5Life -= 1;

        for (int i = 0; i < pOtherHealth.Length; i++)
        {
            if (P5Life > i)
            {
                pOtherHealth[i].SetActive(true);
            }
            else
            {
                pOtherHealth[i].SetActive(false);

            }
        }

    }
}