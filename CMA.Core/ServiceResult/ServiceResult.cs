namespace CMA.Core.ServiceResult
{
    public class ServiceResult<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public static ServiceResult<T> SuccessResult(T data, string message = "Success")
        {
            return new ServiceResult<T>
            {
                Success = true,
                Message = message,
                Data = data
            };
        }

        public static ServiceResult<T> ErrorResult(string message)
        {
            return new ServiceResult<T>
            {
                Success = false,
                Message = message,
                Data = default
            };
        }
    }

    public class ServiceResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public static ServiceResult SuccessResult(string message = "Success")
        {
            return new ServiceResult { Success = true, Message = message };
        }

        public static ServiceResult ErrorResult(string message)
        {
            return new ServiceResult { Success = false, Message = message };
        }
    }

}
