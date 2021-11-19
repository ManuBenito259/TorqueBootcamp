using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class FriendNameController : MonoBehaviour
{
    public FriendsList friends;
    public TMP_Text text;
    public TMP_Dropdown dropdown;

    
    private void Start()
    {
        dropdown.onValueChanged.AddListener(SetNameOnValueChange);
        
        SetNameOnValueChange(dropdown.value);
    }
    
    
    public void SetNameOnValueChange(int index)
    {
        Debug.Log("dropdown change on value: " + index);
        text.SetText(friends.friendsData[index].name);
    }
}
