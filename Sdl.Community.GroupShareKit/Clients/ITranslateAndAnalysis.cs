﻿using Sdl.Community.GroupShareKit.Models.Response;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Sdl.Community.GroupShareKit.Clients
{
    /// <summary>
    /// A client for GroupShare's TranslateAndAnalysis API.
    /// </summary>
    public interface ITranslateAndAnalysis
    {
        /// <summary>
        /// Initiates a new translate and analysis job
        /// </summary>
        /// <returns><see cref="int"/></returns>
        Task<int> GetTranslateAndAnalysisJob(TranslationAndAnalysisJobRequest request);

        /// <summary>
        /// Gets a new translation job specified translate and analysis job.
        /// </summary>
        /// <returns><see cref="int"/></returns>
        Task<int> GetTranslationJob(string jobId, MultipartFormDataContent request);

        /// <summary>
        /// Gets the status for a translation job.
        /// </summary>
        /// <returns><see cref="int"/></returns>
        Task<Translation> GetTranslationStatus(string translateJob);

        /// <summary>
        /// Downloads the translated document.
        /// </summary>
        /// <returns><see cref="int"/></returns>
        Task<byte[]> DownloadTranslationDocument(string translateJob);

        ///// <summary>
        ///// Gets a new translation job specified translate and analysis job.
        ///// </summary>
        ///// <returns><see cref="int"/></returns>
        //Task<int> GetAnalysisJob(string jobId);
        Task<int> GetAnalysisJob(string jobId);

        /// <summary>
        /// Gets the status for a analysis job.
        /// </summary>
        /// <returns><see cref="int"/></returns>
        Task<Analysis> GetAnalysisStatus(string analysisJob);
    }
}
