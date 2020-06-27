namespace DotEnvToJson.App.Models
{
    public class Env
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public bool SlotSetting => false;
    }
}
