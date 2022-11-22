namespace Core.App.Api.Data
{
    public class JwtAuthManager
    {
        private readonly string _apiAuthKey;
        private readonly JwtAuthManager _jwtAuthManager;   
        private readonly IDictionary<string, string> _authUserKeys = new Dictionary<string, string>()
        {
            {"test","password"},
            {"test1","pwd"}
        };
        public JwtAuthManager(string Key)
        {
           this._apiAuthKey = Key;
        }   
    }
}
