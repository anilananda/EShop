namespace EShop.Model
{
    public class User : Audit
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int LoginFaildAttemptCount { get; set; }
        public bool IsLock { get; set; }
    }
}
