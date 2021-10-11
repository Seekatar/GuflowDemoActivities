﻿using CCC.CAS.Workflow3Messages.Messages;
using CCC.CAS.Workflow3Service.Services;
using Guflow;
using Guflow.Decider;
using Guflow.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CCC.CAS.Workflow3Service.Activities
{
    [ActivityDescription("1.4",
        DefaultTaskListName = "defaultTaskList",
        DefaultHeartbeatTimeoutInSeconds = 10000,
        DefaultScheduleToCloseTimeoutInSeconds = 1000,
        DefaultScheduleToStartTimeoutInSeconds = 1000,
        DefaultStartToCloseTimeoutInSeconds = 1000
        )]
    public class PpoProcessorB : PpoProcessor<PpoProcessorB>
    {
        public PpoProcessorB(IOptions<AwsWorkflowOptions> config, ILogger<PpoProcessorB> logger, Domain domain) : base(config, logger, domain)
        {
        }

        public static Identity Identity => Identity.New(nameof(PpoProcessorB), "1.4");

    }
}
