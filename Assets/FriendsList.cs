using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ReSharper disable once CheckNamespace

[Serializable]
public class FriendData
{
    public int friendID;
    public string name;
    public Texture2D photo;
}

public class FriendsList : MonoBehaviour
{
    public List<FriendData> friendsData;
    
}