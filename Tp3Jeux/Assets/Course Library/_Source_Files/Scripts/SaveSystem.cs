using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void SaveGameState(GameState gameState){
        var serializedSave = JsonConvert.SerializeObject(gameState);
        var path = Path.Combine(Application.persistentDataPath,$"game.save");
        File.WriteAllText(path,serializedSave);
    }   

    public static GameState CheckAndLoadGameStateData(){

        var path = Path.Combine(Application.persistentDataPath,$"game.save");

        if (CheckHasState()) {
            var serializedSave = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<GameState>(serializedSave);
        }
        else
        {
            return null;
        }

    }

    public static bool CheckHasState() {
        var path = Path.Combine(Application.persistentDataPath, $"game.save");

        bool retour = false;

        if (File.Exists(path))
        {
            var serializedSave = File.ReadAllText(path);
            retour = true;
        }
        return retour;
    }

    public class GameState{

        public int score;

        public int nbVie;

        public int difficulte; 

    }
}
