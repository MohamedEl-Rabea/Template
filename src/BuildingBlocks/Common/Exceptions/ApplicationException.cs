namespace CompanyName.ProjectName.BuildingBlocks.Common
{
    public class ApplicationExceptionBase : Exception
    {
        public Guid RequestId { get; set; }

        public ApplicationExceptionBase(Guid requestId, Exception exception)
            : base(null, exception)
        {
            RequestId = requestId;
        }
        public ApplicationExceptionBase()
        {

        }
        public ApplicationExceptionBase(string message) : base(message)
        {

        }

        public virtual string GetDetails()
        {
            return StackTrace;
        }
    }

}