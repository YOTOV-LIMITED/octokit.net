﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Octokit
{
    public interface ICommitCommentReactionsClient
    {
        /// <summary>
        /// Creates a reaction for a specified Commit Comment
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#create-reaction-for-a-commit-comment</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The comment id</param>
        /// <param name="reaction">The reaction to create</param>
        /// <returns></returns>
        Task<Reaction> Create(string owner, string name, int number, NewReaction reaction);

        /// <summary>
        /// Get all reactions for a specified Commit Comment
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#list-reactions-for-a-commit-comment</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The comment id</param>        
        /// <returns></returns>
        Task<IReadOnlyList<Reaction>> GetAll(string owner, string name, int number);
    }
}
