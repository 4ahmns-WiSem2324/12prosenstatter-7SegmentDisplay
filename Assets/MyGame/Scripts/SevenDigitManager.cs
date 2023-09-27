using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SevenDigitManager : MonoBehaviour
{
    public GameObject[] sevenDigit;


    void Start()
    {
        sevenDigit[0].SetActive(true);
        sevenDigit[1].SetActive(true);
        sevenDigit[2].SetActive(true);
        sevenDigit[3].SetActive(true);
        sevenDigit[4].SetActive(true);
        sevenDigit[5].SetActive(true);
        sevenDigit[6].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ButtonClick1()
    {
        sevenDigit[0].SetActive(false);
        sevenDigit[1].SetActive(true);
        sevenDigit[2].SetActive(true);
        sevenDigit[3].SetActive(false);
        sevenDigit[4].SetActive(false);
        sevenDigit[5].SetActive(false);
        sevenDigit[6].SetActive(false);
    }

    public void ButtonClick2()
    {
        sevenDigit[0].SetActive(true);
        sevenDigit[1].SetActive(true);
        sevenDigit[2].SetActive(false);
        sevenDigit[3].SetActive(true);
        sevenDigit[4].SetActive(true);
        sevenDigit[5].SetActive(false);
        sevenDigit[6].SetActive(true);
    }

    public void ButtonClick3()
    {
        sevenDigit[0].SetActive(true);
        sevenDigit[1].SetActive(true);
        sevenDigit[2].SetActive(true);
        sevenDigit[3].SetActive(true);
        sevenDigit[4].SetActive(false);
        sevenDigit[5].SetActive(false);
        sevenDigit[6].SetActive(true);
    }

    public void ButtonClick4()
    {
        sevenDigit[0].SetActive(false);
        sevenDigit[1].SetActive(true);
        sevenDigit[2].SetActive(true);
        sevenDigit[3].SetActive(false);
        sevenDigit[4].SetActive(false);
        sevenDigit[5].SetActive(true);
        sevenDigit[6].SetActive(true);
    }

    public void ButtonClick5()
    {
        sevenDigit[0].SetActive(true);
        sevenDigit[1].SetActive(false);
        sevenDigit[2].SetActive(true);
        sevenDigit[3].SetActive(true);
        sevenDigit[4].SetActive(false);
        sevenDigit[5].SetActive(true);
        sevenDigit[6].SetActive(true);
    }

    public void ButtonClick6()
    {
        sevenDigit[0].SetActive(true);
        sevenDigit[1].SetActive(false);
        sevenDigit[2].SetActive(true);
        sevenDigit[3].SetActive(true);
        sevenDigit[4].SetActive(true);
        sevenDigit[5].SetActive(true);
        sevenDigit[6].SetActive(true);
    }

    public void ButtonClick7()
    {
        sevenDigit[0].SetActive(true);
        sevenDigit[1].SetActive(true);
        sevenDigit[2].SetActive(true);
        sevenDigit[3].SetActive(false);
        sevenDigit[4].SetActive(false);
        sevenDigit[5].SetActive(false);
        sevenDigit[6].SetActive(false);
    }

    public void ButtonClick8()
    {
        sevenDigit[0].SetActive(true);
        sevenDigit[1].SetActive(true);
        sevenDigit[2].SetActive(true);
        sevenDigit[3].SetActive(true);
        sevenDigit[4].SetActive(true);
        sevenDigit[5].SetActive(true);
        sevenDigit[6].SetActive(true);
    }

    public void ButtonClick9()
    {
        sevenDigit[0].SetActive(true);
        sevenDigit[1].SetActive(true);
        sevenDigit[2].SetActive(true);
        sevenDigit[3].SetActive(true);
        sevenDigit[4].SetActive(false);
        sevenDigit[5].SetActive(true);
        sevenDigit[6].SetActive(true);
    }

    public void ButtonClick0()
    {
        sevenDigit[0].SetActive(true);
        sevenDigit[1].SetActive(true);
        sevenDigit[2].SetActive(true);
        sevenDigit[3].SetActive(true);
        sevenDigit[4].SetActive(true);
        sevenDigit[5].SetActive(true);
        sevenDigit[6].SetActive(false);
    }

    public void ButtonClickReset()
    {
        sevenDigit[0].SetActive(true);
        sevenDigit[1].SetActive(true);
        sevenDigit[2].SetActive(true);
        sevenDigit[3].SetActive(true);
        sevenDigit[4].SetActive(true);
        sevenDigit[5].SetActive(true);
        sevenDigit[6].SetActive(true);
    }

    public void ButtonClickAnim()
    {
        new WaitForSeconds(1f);
        sevenDigit[0].SetActive(true);
        new WaitForSeconds(1f);
        sevenDigit[1].SetActive(true);
        new WaitForSeconds(1f);
        sevenDigit[2].SetActive(true);
        new WaitForSeconds(1f);
        sevenDigit[3].SetActive(true);
        new WaitForSeconds(1f);
        sevenDigit[4].SetActive(true);
        new WaitForSeconds(1f);
        sevenDigit[5].SetActive(true);
        new WaitForSeconds(1f);
        sevenDigit[6].SetActive(true);
    }
}
