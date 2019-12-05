using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public Animator StateMachine;

    public Image StoryBackground;
    public TextMeshProUGUI StoryText;

    public Sprite North;
    public Sprite South;
    public Sprite West;
    public Sprite East;

    public string SelectedLevelName;

    
    public void MainPlayButtonPressed()
    {
        StateMachine.SetInteger("State", 1);
    }
    public void PlaySelectedLevel()
    {
        SceneManager.LoadScene(SelectedLevelName);
    }

    public void BackButtonPressed()
    {
        StateMachine.SetInteger("State", 1);
    }

    public void ShowStory(string levelName)
    {
        SelectedLevelName = levelName;
        if (levelName == "Vestur")
        {
            StoryBackground.sprite = West;
            StoryText.text = Intro + WestStory;
        }
        else if (levelName == "Austur")
        {
            StoryBackground.sprite = East;
            StoryText.text = Intro + EastStory;
        }
        else if (levelName == "Suður")
        {
            StoryBackground.sprite = South;
            StoryText.text = Intro + SouthStory;
        }
        else if (levelName == "Norður")
        {
            StoryBackground.sprite = North;
            StoryText.text = Intro + NorthStory;
        }
        StateMachine.SetInteger("State", 2);
    }
    public const string Intro = @"Norrænir menn trúðu lengi að landvættir héldu vörð um og að þeir væru guðlegar verur. Þeir vildu ekki fæla þær í burtu og því var bannað með lögum að sigla að landi með gapandi höfðum eða gínandi trjónum.

Haraldur Noregskonungur vildi fara hamförum til Íslands og freista hvað skyldi vera þar. Hann fór í hvalslíki og sá hann að fjöll og hólar voru öll full af landvættum.

";

    public const string EastStory = "Er Haraldur kom fyrir Vopnafjörð fór hann inn í fjörðinn og gekk á land. Er hann fór ofan úr dalnum rakst hann á dreka mikinn sem króaði hann af í helli.";
    public const string NorthStory = "Haraldur fór nú vestur fyrir land í Eyjafjörð. Fór hann upp á fjall þar sem tók á móti honum fugl svo mikill að vængirnir út fjöllin tveggja vegna.";
    public const string WestStory = "Hélt Haraldur lengra vestur og fór inn Breiðafjörð, þar tók á móti honum Griðungur mikill og tók að gella ógurlega";
    public const string SouthStory = "Fór Haraldur suður um Reykjanes og gekk á land þar. Hélt hann austur og var þá ekki nema sandur og öræfi. Er hann nálgaðist Dyrhólaey stóð fyrir framan hann bergrisi með járnstaf og bar höfuðið hærra en fjöllin";
}
