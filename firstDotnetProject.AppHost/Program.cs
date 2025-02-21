var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.firstDotnetProject_ApiService>("apiservice");

builder.AddProject<Projects.firstDotnetProject_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
