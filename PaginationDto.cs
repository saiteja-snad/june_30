namespace Banking_Management_System.DTOS
{
    public class PaginationDto
    {
        private int pageNo;
        private int pageSize;

        public int PageNo { get => pageNo; set => pageNo = value; }
        public int PageSize { get => pageSize; set => pageSize = value; }
    }
}
