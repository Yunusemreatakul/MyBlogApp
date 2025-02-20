﻿using MediatR;
using MyPath.Application.Features.CQRSMediator.Result.CommentBlogResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Application.Features.CQRSMediator.Queries.CommentBlogQueries
{
    public class GetCommentBlogByIdQuery:IRequest<GetCommentBlogByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCommentBlogByIdQuery(int id)
        {
            Id = id;
        }
    }
}
