namespace Matgr.ProductsAPI.Dtos
{
    public class ProductResponseDto
    {
        public bool IsSuccess { get; set; } = true;

        public object Resualt { get; set; }

        public string DispalyMessage { get; set; } = string.Empty;

        public List<string> ErrorMessages { get; set; }







    }
}
