namespace CustomCritters.Framework.CritterData
{
    internal class LightModel
    {
        public string VanillaLightId = "sconceLight";
        public float Radius { get; set; } = 0.5f;
        public LightColorModel Color { get; set; } = new();
    }
}
