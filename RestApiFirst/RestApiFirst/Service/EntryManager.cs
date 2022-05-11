using RestApiFirst.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestApiFirst.Service
{
    public class EntryManager
    {
		IRestService restService;

		public EntryManager(IRestService service)
		{
			restService = service;
		}

		public Task<List<EntryModel>> GetTasksAsync()
		{
			return restService.GetDataAsync();
		}
	}
}
