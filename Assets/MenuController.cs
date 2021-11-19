using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public TMP_Dropdown menu;
    public FriendsList friends;
    public Image image;



    private void OnEnable()
    {
        menu = GetComponent<TMP_Dropdown>();
        List<TMP_Dropdown.OptionData> list = new List<TMP_Dropdown.OptionData>();


        foreach (var friend in friends.friendsData)
        {
            var tex = friend.photo;
            var sprite = Sprite.Create(friend.photo, new Rect(0f,0f, tex.width, tex.height), new Vector2(0.5f, 0.5f));
            


            list.Add(new TMP_Dropdown.OptionData(friend.name,
                sprite));
        }


        menu.options =(list);
    }
}

 
