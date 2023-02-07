using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public Transform CamTransform;
    public GameObject DirectionLight;
    public Transform LightTransform;

    //int PlayerLives = 3;

    //Dictionary<string, int> ItemInventory = new Dictionary<string, int>()
    //{
    //    {"Potion", 5},
    //    {"Antidote", 7 },
    //    {"Aspirin", 1 }
    //};

    //int DiceRoll = 7;
    //public string CharacterAction = "Attack";
    //public bool PureOfHeart = true;
    //public bool HasSecretIncantation = false;
    //public string RareItem = "Relic Stone";
    //public int CurrentGold = 6;
    //public int CurrentAge = 30;
    //public int AddedAge = 1;

    // Start is called before the first frame update
    void Start()
    {
        CamTransform = this.GetComponent<Transform>();
        Debug.Log(CamTransform.localPosition);

        DirectionLight = GameObject.Find("Directional Light");
        LightTransform = DirectionLight.GetComponent<Transform>();
        Debug.Log(LightTransform.localPosition);


        //HealthStatus();


        //foreach (KeyValuePair<string, int> kvp in ItemInventory)
        //{
        //    Debug.LogFormat("Item: {0} - {1}gold", kvp.Key, kvp.Value);

        //    if(kvp.Value < CurrentGold || kvp.Value == CurrentGold)
        //    {
        //        Debug.Log("You can afford this");
        //    }
        //    else
        //    {
        //        Debug.Log("You're too poor for this");
        //    }
        //}

        //FindPartyMember();

        //QuestPartyMembers.Add("Craven the Necromancer");
        //Debug.LogFormat("Party Members:" + QuestPartyMembers, QuestPartyMembers.Count);

        //Debug.LogFormat("Items: {0}", ItemInventory.Count);

        //RollDice();

        //PrintCharacterAction();
        //OpenTreasureChest();
        //Thievery();

        //Debug.Log(30 + 1);
        //Debug.Log(CurrentAge+ 1);
        //ComputeAge();


        //Character hero = new Character();
        //Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);

        //Character heroine = new Character("Agatha");
        //heroine.PrintStatsInfo();
        //Debug.LogFormat("Hero: {0} - {1} EXP", heroine.name, heroine.exp);

        //Character hero2 = hero;
        //hero2.name = "Sir Krane";
        //hero.PrintStatsInfo();
        //hero2.PrintStatsInfo();

        //Weapon huntingBow = new Weapon("Hunting Bow", 105);

        //Paladin knight = new Paladin ("Sir Arthur", huntingBow);
        //knight.PrintStatsInfo();


        
        //Weapon warBow = huntingBow;
        //warBow.name = "War Bow";
        //warBow.damage= 155;
        //huntingBow.PrintWeaponStats();
        //warBow.PrintWeaponStats();

        //int CharacterLevel = 32;

        //int NextSkillLevel = GenerateCharacter("Spike", CharacterLevel);

        //Debug.Log(NextSkillLevel);
        //Debug.Log(GenerateCharacter("Faye", CharacterLevel));


    }

    //public void HealthStatus()
    //{
    //    while (PlayerLives > 0)
    //    {
    //        Debug.Log("Still alive");
    //        PlayerLives--;
    //    }

    //    Debug.Log("Player KO'd");
    //}

    //public void FindPartyMember()
    //{
    //    List<string> QuestPartyMembers = new List<string>()
    //      { "Grim the Barbarian",
    //        "Merlin the Wise",
    //        "Sterling the Knight" };

    //    Debug.LogFormat("Party Members: {0}", QuestPartyMembers.Count);

    //    foreach (string partyMember in QuestPartyMembers)
    //    {
    //        Debug.LogFormat("{0} - Here!", partyMember);
    //    }

    //    for (int i = 0; i < QuestPartyMembers.Count; i++)
    //    {
    //        Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);

    //        if (QuestPartyMembers[i] == "Merlin the Wise")
    //        {
    //            Debug.Log("Glad you're here Merlin");
    //        }
    //    }
    //}

    //public void RollDice()
    //{
    //    switch(DiceRoll)
    //    {
    //        case 7:

    //        case 15:
    //            Debug.Log("Mediocre damage, not bad");
    //            break;
    //        case 20:
    //            Debug.Log("Critical hit");
    //            break;
    //        default:
    //            Debug.Log("You missed");
    //            break;



    //    }
    //}

    private void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Minus))
        //{
        //    CurrentAge--;
        //    Debug.Log(CurrentAge);
        //}

        //if(Input.GetKeyDown(KeyCode.T))
        //{
        //    CurrentAge++;
        //    Debug.Log(CurrentAge);
        //}
    }

    //public void PrintCharacterAction()
    //{
        //switch(CharacterAction)
        //{
        //    case "Heal":
        //        Debug.Log("Potion sent");
        //        break;
        //    case "Attack":
        //        Debug.Log("To arms");
        //        break;
        //    default:
        //        Debug.Log("Shields up");
        //        break;
        //}
    //}

    //public void OpenTreasureChest()
    //{
    //    if(PureOfHeart && RareItem == "Relic Stone")
    //    {
    //        if (!HasSecretIncantation)
    //        {
    //            Debug.Log("You have the spirit but not the knowledge");
    //        }
    //        else
    //        {
    //            Debug.Log("Congrats!");
    //        }
    //    }
    //    else
    //    {
    //        Debug.Log("Get Lost!");
    //    }
    //}


    //public void Thievery()
    //{
    //    if(CurrentGold > 50)
    //    {
    //        Debug.Log("You're rolling in it");
    //    }
    //    else if(CurrentGold < 15)
    //    {
    //        Debug.Log("Not much to steal...");
    //    }
    //    else
    //    {
    //        Debug.Log("Your purse is in the sweet spot");
    //    }
    //}

    /// <summary>
    /// Computes a modifed age integer
    /// </summary>
    //void ComputeAge()
    //{
    //    //Debug.Log(CurrentAge + AddedAge);
    //    CurrentAge++;
    //    Debug.Log(CurrentAge);
    //}

    //public int GenerateCharacter(string name, int level)
    //{
    //    //Debug.LogFormat("Character: {0} - Level: {1}", name, level);
    //    return level += 5;

    //}
}

