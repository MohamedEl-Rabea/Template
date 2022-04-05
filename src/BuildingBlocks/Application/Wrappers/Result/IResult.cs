﻿namespace CompanyName.ProjectName.BuilidingBlocks.Application.Wrappers
{
    public interface IResult
    {
        Guid RequestId { get; set; }

        List<string> Errors { get; set; }

        List<string> Messages { get; set; }

        bool Succeeded { get; set; }
    }

    public interface IResult<out T> : IResult
    {
        T Data { get; }
    }
}
