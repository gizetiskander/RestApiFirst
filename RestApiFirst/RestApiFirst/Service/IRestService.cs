using RestApiFirst.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestApiFirst.Service
{
    public interface IRestService
    {
        Task<List<EntryModel>> GetDataAsync();
    }
}
