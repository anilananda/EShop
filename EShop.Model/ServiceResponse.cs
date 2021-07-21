namespace EShop.Model
{
    public class ServiceResponse<T>
    {
        public bool IsSuccess { get; set; }
        public T ResponseData { get; set; }
        public string ErrorMessage { get; set; }
    }
}
