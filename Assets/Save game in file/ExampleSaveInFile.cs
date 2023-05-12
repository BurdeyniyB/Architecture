using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Save_game_in_file
{
    internal class ExampleSaveInFile : MonoBehaviour
    {
        public GameObject cube;
        private Storage _storage;
        private GameData _gameData;

        private void Start()
        {
            _storage = new Storage();
            Load();
        }

        public void Save()
        {
            _gameData.position = cube.transform.position;
            _gameData.rotation = cube.transform.rotation;

            _storage.Save(_gameData);
            Debug.Log("Game saved");
        }

        public void Load()
        {
            _gameData = (GameData)_storage.Load(new GameData());

            cube.transform.position = _gameData.position;
            cube.transform.rotation = _gameData.rotation;
            Debug.Log(message: $"Loaded speed = {_gameData.speed}");
        }
    }
}
