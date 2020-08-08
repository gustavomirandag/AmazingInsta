using AmazingInsta.Microservices.IamMicroservice.Admin.Api.ExceptionHandling;

namespace AmazingInsta.Microservices.IamMicroservice.Admin.Api.Resources
{
    public class ApiErrorResources : IApiErrorResources
    {
        public virtual ApiError CannotSetId()
        {
            return new ApiError
            {
                Code = nameof(CannotSetId),
                Description = ApiErrorResource.CannotSetId
            };
        }
    }
}





