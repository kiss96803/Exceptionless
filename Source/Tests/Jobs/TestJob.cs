using System;
using System.Threading.Tasks;
using Foundatio.Jobs;

namespace Exceptionless.Api.Tests.Jobs {
    public class TestJob : JobBase {
        public static int RunCount;
        protected override Task<JobResult> RunInternalAsync(JobRunContext context) {
            RunCount++;
            return Task.FromResult(JobResult.Success);
        }
    }
}