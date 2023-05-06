﻿using HorizonPollyC.Models.Configuration;
using System.Net.Http.Json;

namespace HorizonPollyC.Services.Configuration
{
    public partial class ProcessService : IGeneric<ProcessVM>
    {
        private readonly HttpClient httpClient;
        private readonly IConfiguration _configuration;
        string BaseURIConfig;

        public ProcessService(HttpClient client, IConfiguration Configuration)
        {
            httpClient = client;
            _configuration = Configuration;
            BaseURIConfig = _configuration["BaseURLConfig"];
        }
        public async Task<IEnumerable<ProcessVM>> Get()
        {
            var result = await httpClient.GetFromJsonAsync<IEnumerable<ProcessVM>>(BaseURIConfig + "Process/Process");
            return result;
        }


        public async Task<string> Update(ProcessVM model)
        {
            var result = await httpClient.PostAsJsonAsync(BaseURIConfig + "Process/UpdateProcess", model);
            return result.ToString();
        }
    }
}
