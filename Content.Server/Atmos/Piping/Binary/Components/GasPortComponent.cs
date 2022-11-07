namespace Content.Server.Atmos.Piping.Binary.Components
{
    [RegisterComponent]
    public sealed class GasPortComponent : Component
    {
        [ViewVariables(VVAccess.ReadWrite)]
        [DataField("pipe")]
        public string PipeName { get; set; } = "connected";

        [ViewVariables(VVAccess.ReadOnly)]
        public GasMixture Buffer { get; } = new();
    }
}