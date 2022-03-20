using Newtonsoft.Json;

public class Data
{
    [JsonProperty("player_data")]
    public PlayerData playerData { get; set; }

    [JsonProperty("pulpit_data")]
    public PulpitData pulpitData { get; set; }

    public class PlayerData
    {
        [JsonProperty("speed")]
        public float speed { get; set; }
    }

    public class PulpitData
    {
        [JsonProperty("min_pulpit_destroy_time")]
        public float minDestroyTime { get; set; }

        [JsonProperty("max_pulpit_destroy_time")]
        public float maxDestroyTime { get; set; }

        [JsonProperty("pulpit_spawn_time")]
        public float spawnTime { get; set; }
    }
}
