# TeqBench .NET Service App Solution/Project Template

![Build Status Badge](.badges/build-status.svg) ![Build Number Badge](.badges/build-number.svg) ![Coverage](.badges/code-coverage.svg)

## Overview

Template for a .NET service application solution/project. Update all following instances of `TeqBench.Dev.Templates.DotNet.ServiceApp`:

- Solution name
    - TeqBench.Dev.Templates.DotNet.ServiceApp.sln
- Project names
    - TeqBench.Dev.Templates.DotNet.ServiceApp.csproj
    - TeqBench.Dev.Templates.DotNet.ServiceApp.Tests.csproj
- RootNamespace in TeqBench.Dev.Templates.DotNet.ServiceApp.csproj
- AssemblyName in TeqBench.Dev.Templates.DotNet.ServiceApp.csproj

Also have to update Project's settings.

- Add branch protect for the `main` branch.
    - Navigate to `Settings > Branches`.
    - Select `Add rule`.
    - Select `Require a pull request before merging`.
        - Select `Require approvals`.
        - Select `Allow specified actors to bypass required pull requests`.
            - Add user `devops-teqbench`.
    - Select `Require status checks to pass before merging`.
        - `Require branches to be up to date before merging`.
        - Add the status check `` after running manual build one time from repo Actions.
    - Select `Require conversation resolution before merging`.
    - Leave all other settings as default values.
    - Select `Save`.
- Update Actions configuration.
    - Navigate to `Settings > Actions > General`.
    - Select `Allow teqbench, and select non-teqbench, actions and reusable workflows`
        - Select `Allow actions created by GitHub`.
    - Select `Save`.
    - Leave all other settings as default values.

## Contents
- [Developer Environment Setup](#Developer+Environment+Setup)
- [Usage](#Usage)
- [License](#License)

## Developer Environment Setup

### General
- [Branching Strategy & Practices](https://github.com/teqbench/teqbench.docs/wiki/Branching-Strategy)

### .NET
- [General Tooling](https://github.com/teqbench/teqbench.docs/wiki/.NET-General-Tooling)
- [Configurations](https://github.com/teqbench/teqbench.docs/wiki/.NET-Configuration-Standards)
- [Coding Standards](https://github.com/teqbench/teqbench.docs/wiki/.NET-Coding-Standards)
- [Solutions](https://github.com/teqbench/teqbench.docs/wiki/.NET-Solutions)
- [Projects](https://github.com/teqbench/teqbench.docs/wiki/.NET-Projects)
- [Building](https://github.com/teqbench/teqbench.docs/wiki/.NET-Build-Process)
- [Package & Deployment](https://github.com/teqbench/teqbench.docs/wiki/.NET-Package-Deploy)
- [Versioning](https://github.com/teqbench/teqbench.docs/wiki/.NET-Versioning-Standards)

## Licensing

[License](https://github.com/teqbench/teqbench.docs/wiki/License)
