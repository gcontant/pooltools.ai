var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.web>("playerApi");

builder.Build().Run();
