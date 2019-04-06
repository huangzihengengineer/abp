﻿using System;
using Volo.ClientSimulation.Scenarios;

namespace Volo.ClientSimulation.Clients
{
    public interface IClient
    {
        IScenario Scenario { get; }

        event EventHandler Stopped;

        ClientState State { get; }

        void Start();

        void Stop();
    }
}