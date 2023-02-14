namespace OpenAPI.JWT.Template
{
    /// <summary>
    /// Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args) => new StartUp().Main(args);
    }

    /// <summary>
    /// StartUp
    /// </summary>
    public class StartUp : JWT.StartUp
    {
        /// <summary>
        /// 
        /// </summary>
        protected override string Title => "Title";
        /// <summary>
        /// 
        /// </summary>
        protected override Version Version => new ("1.0.0.0");
        /// <summary>
        /// 
        /// </summary>
        protected override string Description => "Description";

        /// <summary>
        /// WebApplicationBuilder_Process
        /// </summary>
        /// <param name="builder"></param>
        protected override void WebApplicationBuilder_Process(WebApplicationBuilder builder)
        {
            base.WebApplicationBuilder_Process(builder);
        }
        /// <summary>
        /// WebApplication_Process
        /// </summary>
        /// <param name="app"></param>
        protected override void WebApplication_Process(WebApplication app)
        {
            base.WebApplication_Process(app);
        }
    }
}