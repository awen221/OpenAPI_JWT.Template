new StartUp().Main(args);

/// <summary>
/// StartUp
/// </summary>
public class StartUp : OpenAPI_JWT.StartUp
{
    /// <summary>
    /// 
    /// </summary>
    protected override string Title => "OpenAPI_JWT";
    /// <summary>
    /// 
    /// </summary>
    protected override Version Version => new("1.0.0.0");
    /// <summary>
    /// 
    /// </summary>
    protected override string Description => "OpenAPI_JWT Description";
}