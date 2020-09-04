using System;
using System.Collections.Generic;
using System.Text;
using WebCoreApp.Infrastructure.SharedKernel;

namespace WebCoreApp.Data.Entities
{
    public class VoteLog : DomainEntity<int>
    {
        public int VoteForId { get; set; }

        public string UserName { get; set; }

        public float Vote { get; set; }

        public VoteLog()
        {

        }
        public VoteLog(int voteForId, string username, float vote)
        {
            VoteForId = voteForId;
            UserName = username;
            Vote = vote;
        }

        public VoteLog(int id, int voteForId, string username, float vote)
        {
            Id = id;
            VoteForId = voteForId;
            UserName = username;
            Vote = vote;
        }

    }
}
