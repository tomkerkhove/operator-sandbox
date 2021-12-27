using System.Threading.Tasks;
using Sandbox.Generated.Operator.Entities;
using k8s.Models;
using KubeOps.Operator.Finalizer;
using Microsoft.Extensions.Logging;

namespace Sandbox.Generated.Operator.Finalizer
{
    public class DemoFinalizer : IResourceFinalizer<V1DemoEntity>
    {
        private readonly ILogger<DemoFinalizer> _logger;

        public DemoFinalizer(ILogger<DemoFinalizer> logger)
        {
            _logger = logger;
        }

        public Task FinalizeAsync(V1DemoEntity entity)
        {
            _logger.LogInformation($"entity {entity.Name()} called {nameof(FinalizeAsync)}.");

            return Task.CompletedTask;
        }
    }
}
