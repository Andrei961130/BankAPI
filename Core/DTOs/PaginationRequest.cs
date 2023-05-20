
namespace Core.DTOs
{
    public class PaginationRequest
    {
        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public PaginationRequest()
        {
            PageNumber = 1;
            PageSize = 5;
        }

        public PaginationRequest(int? pageNumber, int? pageSize)
            : this()
        {
            if (pageNumber.HasValue)
            {
                PageNumber = pageNumber.Value;
            }

            if (pageSize.HasValue)
            {
                PageSize = pageSize.Value;
            }
        }
    }
}
