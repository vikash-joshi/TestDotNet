using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_web_api.single_scope_transient
{
    public interface ISingleton
    {
        string GetGuidOps();

    }
        public interface IScoped
    {
        string GetGuidOps();

    }
        public interface ITransient
    {
        string GetGuidOps();

    }

    public class OperationService:ITransient , IScoped,ISingleton
    {
        private static int _counter = 0;
    private readonly string _operationId;

    public OperationService()
    {
        _operationId = "My ateime"+DateTime.Now;
    }

    public string GetGuidOps() => _operationId.ToString();

    }
}