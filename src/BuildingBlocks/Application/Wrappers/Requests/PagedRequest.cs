namespace CompanyName.ProjectName.BuilidingBlocks.Application.Wrappers
{
    public class PagedRequest<T>
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public dynamic Filter { get; set; }
        public IEnumerable<Sort> Sort { get; set; }

        public virtual IFilter<T> GetFilter() { return Filter; }
    }
}
