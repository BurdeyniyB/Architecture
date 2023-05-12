using System;
using UnityEngine;


namespace Assets.Save_game_in_file
{
    [Serializable]
    public class GameData
    {
        public int speed { get; private set; }
        public Vector3 position;
        public Quaternion rotation;

        public GameData()
        {
            speed = 10;
            position = Vector3.up; 
            rotation = Quaternion.identity;
        }
    }
}
