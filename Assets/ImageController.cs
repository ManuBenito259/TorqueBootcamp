using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    public FriendsList friends;
    public Image image;
    public TMP_Dropdown dropdown;

    private void Start()
    {
        dropdown.onValueChanged.AddListener(SetImageOnValueChange);
        
        SetImageOnValueChange(dropdown.value);
    }

    public void SetImageOnValueChange(int index)
    {
        var tex = friends.friendsData[index].photo;
        image.sprite = Sprite.Create(tex, new Rect(0f,0f, tex.width,tex.height), new Vector2(0.5f, 0.5f));
    }
}
